using System;
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
        public frmMain()
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
        }

        private void cmdParcourirDest_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename = dialog.SelectedPath;
                }
                else
                {
                    return;
                }

                ListView lv = new ListView();
                txtDestination.Text = filename;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readCSV()
        {
            using (var reader = new StreamReader(@txtInfosEtus.Text))
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
                        ligne.SubItems.Add(values[2]);
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
                txtInfosEtus.Text = filename;
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
            /*if (lvEtus.SelectedItems[0].Tag)
            {

            }*/
        }
    }
}
