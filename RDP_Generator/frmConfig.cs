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
        string fichierRDPdefault = Environment.CurrentDirectory + "\\test.rdp";
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
            frmAjoutModifConfig form = new frmAjoutModifConfig("Ajout", "null");
            form.ShowDialog();
        }

        private void cmdParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                dossier = ofd.FileName;
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            splitSettings = GetConfig.GetConfigArray();
            Remplir_ListView();
        }

        private void Remplir_ListView()
        {
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
            frmAjoutModifConfig frm = new frmAjoutModifConfig("Modif", lvConfigs.SelectedItems[0].Index, lvConfigs.SelectedItems[0].Tag.ToString());
            frm.ShowDialog();
        }
    }
}
