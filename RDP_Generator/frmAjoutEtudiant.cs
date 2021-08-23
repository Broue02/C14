using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP_Generator
{
    public partial class frmAjoutEtudiant : Form
    {
        ListView lvEtudiants;

        /// <summary>
        /// Initialisation des variables
        /// </summary>
        /// <param name="lvEtu"></param>
        public frmAjoutEtudiant(ListView lvEtu)
        {
            InitializeComponent();
            cmdAnnuler.FlatAppearance.BorderSize = 0;

            lvEtudiants = lvEtu;
        }

        /// <summary>
        /// Événement Load. Centre le formulaire à l'écran à l'ouverture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAjoutEtudiant_Load(object sender, EventArgs e)
        {
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
        /// Bouton OK. Valide les informations puis ajout l'étudiant dans le ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (!Valider_Form())
                return;

            string Da, Ordinateur;

            Da = txtDA.Text.Trim();
            Ordinateur = txtOrdinateur.Text.Trim();

            ListViewItem item = new ListViewItem();

            item.Text = Da;
            item.SubItems.Add(Ordinateur);

            lvEtudiants.Items.Add(item);

            MessageBox.Show("Étudiant(e) ajouté(e) avec succès!", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// Méthode de validation des informations du formulaire.
        /// </summary>
        /// <returns></returns>
        private bool Valider_Form()
        {
            bool ok = true;

            if (txtDA.Text.Trim() == "")
            {
                erp.SetError(txtDA, "Da obligatoire");
                ok = false;
            }

            if (txtOrdinateur.Text.Trim() == "")
            {
                erp.SetError(txtOrdinateur, "Nom de l'ordinateur obligatoire");
                ok = false;
            }

            return ok;
        }
    }
}
