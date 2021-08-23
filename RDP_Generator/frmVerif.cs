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
        public DialogResult result;

        public frmVerif(ArrayList configList)
        {
            InitializeComponent();
            cmdAnnuler.FlatAppearance.BorderSize = 0;
            splitSettings = configList;
        }

        /// <summary>
        /// Événement Load. Rempli le ListView et initialise le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVerif_Load(object sender, EventArgs e)
        {
            Remplir_ListView();
            cmdOk.DialogResult = DialogResult.OK;
            cmdAnnuler.DialogResult = DialogResult.Cancel;
            cmdQuitter.DialogResult = DialogResult.Cancel;
            this.CenterToScreen();

        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        /// <summary>
        /// Mouse Down du header. Initie le déplacement du formulaire
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
        /// Mouse Move du header. Effectue les calculs et le déplacement du formulaire.
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
        /// Mouse Up du header. Lève le flag de déplacement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        /// <summary>
        /// Bouton Quitter. Ferme le formulaire sans sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Bouton Minimiser. Minimise le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Procédure remplissant le ListView avec la configuration RDP à montrer à l'utilisateur.
        /// </summary>
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

        /// <summary>
        /// Bouton OK. Ferme le formulaire en retournant DialogResult.OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
