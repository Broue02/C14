using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP_Generator
{
    public partial class frmMain : Form
    {
        private string destination = "";
        private string fichierEtudiants = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\configTemp.rdp"))
                File.Delete(Environment.CurrentDirectory + "\\configTemp.rdp");

            Application.Exit();
        }

        private void cmdMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void cmdConfig_Click(object sender, EventArgs e)
        {
            frmConfig form = new frmConfig();
            form.ShowDialog();

            if (File.Exists(Environment.CurrentDirectory + "\\configTemp.rdp"))
            {
                picConfigOK.BackgroundImage = Properties.Resources.check_ok;
                picConfigOK.Visible = true;
            }
            else
            {
                picConfigOK.BackgroundImage = Properties.Resources.check_err;
                picConfigOK.Visible = true;
            }
        }

        private void cmdParcourirDest_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.SelectedPath = Environment.CurrentDirectory;
                dialog.Description = "Veuillez sélectionner le dossier de destination.";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename = dialog.SelectedPath;
                }
                else
                {
                    return;
                }

                ListView lv = new ListView();
                destination = filename;
                //txtDestination.Text = filename;

                string[] folders = filename.Split('\\');
                txtDestination.Text = folders[folders.Length - 1] + "\\";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readCSV()
        {
            //using (var reader = new StreamReader(@txtInfosEtus.Text))
            using (var reader = new StreamReader(fichierEtudiants))
            {
                var nbr = 0;
                ListViewItem ligne = new ListViewItem();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (nbr != 0)
                    {
                        ligne = new ListViewItem(values[0]);
                        ligne.SubItems.Add(values[2]);
                        ligne.SubItems.Add(values[1]);
                        ligne.Tag = nbr;

                        lvEtus.Items.Add(ligne);
                    }
                    nbr += 1;
                }
            }
        }

        private void cmdParcourirInfos_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "CSV File";
                dialog.Filter = "CSV Files (*.csv)|*.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename = dialog.FileName;
                }
                else
                {
                    return;
                }

                ListView lv = new ListView();
                fichierEtudiants = filename;

                string[] folders = filename.Split('\\');
                txtInfosEtus.Text = folders[folders.Length - 1];

                lvEtus.Items.Clear();
                readCSV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lvEtus.SelectedItems.Count < 1)
                return;

            lvEtus.SelectedItems[0].Remove();
        }

        private void lvEtus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEtus.SelectedItems.Count == 0)
            {
                cmdSupprimer.Enabled = false;
            }
            else
            {
                cmdSupprimer.Enabled = true;
            }
        }

        private bool Verif_Form()
        {
            err.Clear();
            bool ok = true;

            if(txtDestination.Text.Trim() == "")
            {
                err.SetError(txtDestination, "Destination de configuration obligatoire");
                ok = false;
            }

            if(txtInfosEtus.Text.Trim() == "")
            {
                err.SetError(txtInfosEtus, "Liste d'étudiants obligatoire");
                ok = false;
            }

            if(lvEtus.Items.Count == 0)
            {
                err.SetError(lvEtus, "Liste d'étudiants obligatoire");
                ok = false;
            }

            if(!File.Exists(Environment.CurrentDirectory + "\\configTemp.rdp"))
            {
                err.SetError(cmdConfig, "Fichier de configuration obligatoire");
                ok = false;
            }

            return ok;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (!Verif_Form())
                return;

            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\configTemp.rdp", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            StreamReader reader = new StreamReader(fs);

            string allConfigs = reader.ReadToEnd();
            string[] splitChars = { "\r\n", "\n" };

            string[] configsLines = allConfigs.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            reader.Close();
            fs.Close();

            if (!Verifier_Configuration(configsLines))
                return;

            //Verifier_Configuration(configsLines);


            foreach (ListViewItem etudiant in lvEtus.Items)
            {
                //string destination = txtDestination.Text.Replace("\\\\", "\\");
                FileStream fsWriter = new FileStream(destination + "\\\\" + etudiant.SubItems[0].Text + ".rdp", FileMode.Create, FileAccess.Write, FileShare.None);
                StreamWriter writer = new StreamWriter(fsWriter);

                string line = "";

                foreach (string lineRaw in configsLines)
                {

                    // *******************************
                    // Gérer Hostname (rajouter potentiellement à username et full address)
                    // *******************************

                    line = lineRaw;

                    if (line.Contains("username"))
                        line += etudiant.SubItems[0].Text;

                    if (line.Contains("full address"))
                        line += etudiant.SubItems[2].Text;

                    writer.WriteLine(line);


                }

                writer.Close();
                fsWriter.Close();
            }

            File.Delete(Environment.CurrentDirectory + "\\configTemp.rdp");

            DialogResult result;

            result = MessageBox.Show("Création des configurations réussie! \n\nVoulez-vous quitter le programme?", "Succès!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                this.Close();
            else
            {
                lvEtus.Items.Clear();
                txtDestination.Text = "";
                txtInfosEtus.Text = "";
                picConfigOK.Visible = false;
                err.Clear();
            }
        }

        private bool Verifier_Configuration(string[] configLines)
        {
            string line = "";
            ArrayList testConfig = new ArrayList();

            if (lvEtus.Items.Count == 0)
                return false;

            for(int i = 0; i < configLines.Length; i++)
            {
                line = configLines[i];

                if (line.Contains("username"))
                    line += lvEtus.Items[0].SubItems[0].Text;

                if (line.Contains("full address"))
                    line += lvEtus.Items[0].SubItems[2].Text;

                testConfig.Add(line);
            }

            frmVerif frm = new frmVerif(testConfig);

            DialogResult result;
            result = frm.ShowDialog();

            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }
    }
}
