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
        public frmAjoutEtudiant()
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

        private void cmdOK_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach( Form f in fc)
            {
                if (f.Name == "frmMain")
                {
                    frmMain fm = (frmMain)f;

                    /*if (Valider_Form() == false)
                        return;*/

                    string Da, Courriel, Ordinateur;

                    Da = txtDA.Text.Trim();
                    Courriel = txtCourriel.Text.Trim();
                    Ordinateur = txtOrdinateur.Text.Trim();

                    Etudiant etu = new Etudiant(Da, Courriel, Ordinateur);

                    
                }
            }
        }

        private bool Valider_Form()
        {
            bool ok = true;

            if (txtDA.Text.Trim() == "")
            {
                erp.SetError(txtDA, "Da obligatoire");
                ok = false;
            }

            if (txtCourriel.Text.Trim() == "")
            {
                erp.SetError(txtCourriel, "Courriel obligatoire");
                ok = false;
            }

            if (txtOrdinateur.Text.Trim() == "")
            {
                erp.SetError(txtOrdinateur, "Nom de l'ordinateur obligatoire");
                ok = false;
            }

            return ok;
        }

        private void frmAjoutEtudiant_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
