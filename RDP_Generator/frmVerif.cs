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
    public partial class frmVerif : Form
    {
        string dossier = "";
        string fichierRDPdefault = Environment.CurrentDirectory + "\\test.rdp";
        ArrayList splitSettings = new ArrayList();
        public frmVerif(ArrayList configList)
        {
            InitializeComponent();
            cmdAnnuler.FlatAppearance.BorderSize = 0;
            splitSettings = configList;
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

        

       

        private void frmConfig_Load(object sender, EventArgs e)
        {

        }

        


        private void Remplir_ListView()
        {
            lvConfigs.Items.Clear();

            ListViewItem ligne = new ListViewItem();

            foreach(string config in splitSettings)
            {
                ligne = new ListViewItem(config);

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
                SaveFileDialog test = new SaveFileDialog();
                test.FileName = dossier;
                test.Title = "Sauvegardez votre fichier RDP:";

                string saveSetting = "";

                if (test.ShowDialog() == DialogResult.OK)
                {
                    Stream s = File.Open(test.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);

                    foreach (Settings setting in splitSettings)
                    {
                        saveSetting += setting.settingName + ":" + setting.settingType + ":" + setting.settingValue + "\n";
                    }

                    sw.Write(saveSetting);

                    sw.Close();
                    s.Close();
                }
            }
        }
    }
}
