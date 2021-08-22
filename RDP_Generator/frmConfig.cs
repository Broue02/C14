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
    public partial class frmConfig : Form
    {
        string dossier = "";
        string fichierRDPdefault = Environment.CurrentDirectory;
        ArrayList splitSettings = new ArrayList();
        public frmConfig()
        {
            InitializeComponent();
            cmdAnnuler.FlatAppearance.BorderSize = 0;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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
            this.Close();
        }

        private void cmdMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Assurez-vous d'entrer des configurations existantes lors de l'ajout d'une ligne de configuration", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (choice == DialogResult.Yes)
            {
                frmAjoutModifConfig form = new frmAjoutModifConfig("Ajout", 0 ,"null", dossier);
                form.ShowDialog();
            }
            
        }

        private void cmdParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                dossier = ofd.FileName;

                string[] dossierSplit = dossier.Split('\\');
                txtConfig.Text = dossierSplit[dossierSplit.Length - 1];

                splitSettings = GetConfig.GetConfigArray(dossier);
                Remplir_ListView();

                cmdAjouter.Enabled = true;
                cmdModifier.Enabled = true;
                cmdDefaut.Enabled = true;
                cmdEnregistrer.Enabled = true;
                cmdOk.Enabled = true;
            }
        }

        public void UpdateElement(Settings element, int index)
        {
            ListViewItem ligne = new ListViewItem(element.settingName);
            ligne.SubItems.Add(element.settingType);
            ligne.SubItems.Add(element.settingValue);

            ligne.Tag = element.settingName;


            foreach (Settings setting in splitSettings)
            {
                if (setting.settingName == lvConfigs.Items[index].Text)
                {
                    setting.settingName = element.settingName;
                    setting.settingType = element.settingType;
                    setting.settingValue = element.settingValue;
                }
            }

            Remplir_ListView();
        }

        public void AddElement(Settings element, string tag)
        {
            ListViewItem ligne = new ListViewItem(element.settingName);

            ligne.SubItems.Add(element.settingType);
            ligne.SubItems.Add(element.settingValue);
            ligne.Tag = tag;

            lvConfigs.Items.Add(ligne);

            splitSettings.Add(element);
            Remplir_ListView();
        }

        private void Remplir_ListView()
        {
            lvConfigs.Items.Clear();

            ListViewItem ligne = new ListViewItem();

            foreach(Settings config in splitSettings)
            {
                ligne = new ListViewItem(config.settingName);

                if (config.settingType == "i")
                {
                    ligne.SubItems.Add("Integer");
                }
                else
                    ligne.SubItems.Add("String");

                ligne.SubItems.Add(config.settingValue);
                ligne.Tag = config.settingName;

                lvConfigs.Items.Add(ligne);
            }
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            frmAjoutModifConfig frm = new frmAjoutModifConfig("Modif", lvConfigs.SelectedItems[0].Index, lvConfigs.SelectedItems[0].Tag.ToString(), dossier);
            frm.ShowDialog();
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            ListViewItem ligne = lvConfigs.SelectedItems[0];

            splitSettings.RemoveAt(ligne.Index);
            lvConfigs.Items[lvConfigs.SelectedItems[0].Index].Remove();

            Remplir_ListView();
        }

        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            if (splitSettings.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = dossier;
                sfd.Title = "Sauvegardez votre fichier RDP:";

                string saveSetting = "";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream s = File.Open(sfd.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);

                    foreach (Settings setting in splitSettings)
                    {
                        saveSetting += setting.settingName + ":" + setting.settingType + ":" + setting.settingValue + "\n";
                    }

                    sw.Write(saveSetting);

                    sw.Close();
                    s.Close();

                    MessageBox.Show("Fichier de configuration enregistré à l'emplacement spécifié!", "Enregistrement...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            string fichier = fichierRDPdefault + "\\configTemp.rdp";
            if (File.Exists(fichier))
            {
                File.Delete(fichier);
            }

            Stream s = File.Open(fichier, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(s);
            string saveSetting = "";

            foreach(Settings setting in splitSettings)
            {
                saveSetting += setting.settingName + ":" + setting.settingType + ":" + setting.settingValue + "\n";
            }

            sw.Write(saveSetting);

            sw.Close();
            s.Close();

            MessageBox.Show("Fichier de configuration temporaire enregistré!", "Enregistrement...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
