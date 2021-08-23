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
        public string nomDomaine = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        /// <summary>
        /// Événement Load. Centre le formulaire à l'écran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        /// <summary>
        /// Mouse Down sur le header. Permet de déplacer le formulaire sur le tiens de la souris.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        /// <summary>
        /// Mouse Move sur le header. Effectue le calcul du déplacement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        /// <summary>
        /// Mouse Up du header. Enlève le flag de déplacement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        /// <summary>
        /// Bouton Quitter. Détruit le fichier temporaire s'il existe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\configTemp.rdp"))
                File.Delete(Environment.CurrentDirectory + "\\configTemp.rdp");

            Application.Exit();
        }

        /// <summary>
        /// Bouton Minimiser. Minimise le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton Config. Ouvre le formulaire de Configuration du RDP. Change le PictureBox en conséquence de la configuration présente ou non.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bouton Parcourir Destination. Ouvre un FolderBrowserDialog pour aller chercher l'emplacement de sauvegarde des RDP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdParcourirDest_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.SelectedPath = Environment.CurrentDirectory;
                dialog.Description = "Veuillez sélectionner le dossier de destination.";

                if (dialog.ShowDialog() == DialogResult.OK)
                    filename = dialog.SelectedPath;
                else
                    return;

                ListView lv = new ListView();
                destination = filename;

                string[] folders = filename.Split('\\');
                txtDestination.Text = folders[folders.Length - 1] + "\\";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Procédure lisant le fichier CSV importé et l'affichant dans le tableau d'étudiants.
        /// </summary>
        private void readCSV()
        {
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
                        ligne.SubItems.Add(values[1]);
                        ligne.Tag = nbr;

                        lvEtus.Items.Add(ligne);
                    }
                    nbr += 1;
                }
            }
        }

        /// <summary>
        /// Bouton Parcourir Infos Étudiants. Ouvre un OpenFileDialog pour aller chercher un fichier CSV de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bouton Supprimer. Enlève un élément de la liste d'étudiants.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lvEtus.SelectedItems.Count < 1)
                return;

            lvEtus.SelectedItems[0].Remove();
        }

        /// <summary>
        /// Événement de changement de sélection. Barre ou débarre le bouton supprimer en conséquence de la présence d'étudiants.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Méthode de vérification des données du formulaire. Vérifie qu'il y a assez d'informations présentes pour créer un RDP
        /// </summary>
        /// <returns></returns>
        private bool Verif_Form()
        {
            err.Clear();
            bool ok = true;

            if(txtDestination.Text.Trim() == "")
            {
                err.SetError(txtDestination, "Destination de configuration obligatoire");
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

        /// <summary>
        /// Bouton OK. Vérifie le formulaire, ouvre le formulaire de vérification de RDP pour l'utilisateur, puis crée les RDP.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOK_Click(object sender, EventArgs e)
        {
            // Vérification du formulaire
            if (!Verif_Form())
                return;

            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\configTemp.rdp", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            StreamReader reader = new StreamReader(fs);

            string allConfigs = reader.ReadToEnd();
            string[] splitChars = { "\r\n", "\n" };

            string[] configsLines = allConfigs.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            reader.Close();
            fs.Close();

            // Vérification des configurations pour l'utilsateur.
            if (!Verifier_Configuration(configsLines))
                return;

            string domaine = "";
            int lineCounter = 0;

            // Vérification si la ligne détient les informations de domaine.
            if (configsLines[0].Contains("domaine:s:"))
            {
                domaine = "@" + configsLines[0].Split(':').Last();
                lineCounter = 1;
            }

            //Parcours chaque étudiant dans le ListView. Crée un RDP pour chacun d'eux selon le fichier de configuration.
            foreach (ListViewItem etudiant in lvEtus.Items)
            {
                FileStream fsWriter = new FileStream(destination + "\\\\" + etudiant.SubItems[0].Text + ".rdp", FileMode.Create, FileAccess.Write, FileShare.None);
                StreamWriter writer = new StreamWriter(fsWriter);

                string line = "";

                for (int i = lineCounter; i < configsLines.Length; i++)
                {

                    line = configsLines[i];

                    if (line.Contains("username"))
                        line += etudiant.SubItems[0].Text + domaine;

                    if (line.Contains("full address"))
                        line += etudiant.SubItems[1].Text;

                    writer.WriteLine(line);


                }

                writer.Close();
                fsWriter.Close();
            }

            //Suppression du fichier temporaire et remise à zéro des variables/contrôles.
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

        /// <summary>
        /// Ouvre un formulaire de vérification de la configuration pour l'utilisateur avant la création finale des RDP.
        /// </summary>
        /// <param name="configLines">Tableau de toutes les lignes de configuration</param>
        /// <returns></returns>
        private bool Verifier_Configuration(string[] configLines)
        {
            string line = "";
            string domaine = "";
            int lineCounter = 0;
            ArrayList testConfig = new ArrayList();

            if (lvEtus.Items.Count == 0)
                return false;

            if (configLines[0].Contains("domaine:s:"))
            {
                domaine = "@" + configLines[0].Split(':').Last();
                lineCounter = 1;
            }

            // Parcours chacune des lignes de configs. Fait quelques manipulations au besoin.
            for(int i = lineCounter; i < configLines.Length; i++)
            { 
                line = configLines[i];

                if (line.Contains("username"))
                {
                    if (line.Split(':').Last() != "")
                    {
                        string[] strUsername = line.Split(':');

                        line = strUsername[0] + ':' + strUsername[1] + ':';
                        configLines[i] = line;
                    }
                    line += lvEtus.Items[0].SubItems[0].Text + domaine;
                }

                if (line.Contains("full address"))
                {
                    if (line.Split(':').Last() != "")
                    {
                        string[] fullAddress = line.Split(':');

                        line = fullAddress[0] + ':' + fullAddress[1] + ':';
                        configLines[i] = line;
                    }
                    line += lvEtus.Items[0].SubItems[1].Text;
                }

                testConfig.Add(line);
            }

            // Ouverture du formulaire de vérification. 
            frmVerif frm = new frmVerif(testConfig);

            DialogResult result;
            result = frm.ShowDialog();

            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Bouton Ajouter. Ouvre le formulaire AjoutEtudiant pour créer un nouvel entrée dans le ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutEtudiant frm = new frmAjoutEtudiant(lvEtus);
            frm.ShowDialog();
        }
    }
}
