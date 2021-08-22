using System;
using System.Collections;
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
    public partial class frmAjoutModifConfig : Form
    {
        string actionParam = "";
        string settingTag;
        int settingIndex = 0;
        string Settingsdossier = "";
        ArrayList settings = new ArrayList();
        public frmAjoutModifConfig(string action, int index, string tag, ArrayList splitSettings)
        {
            InitializeComponent();
            cmdAnnuler.FlatAppearance.BorderSize = 0;
            this.CenterToScreen();

            settingTag = tag;
            actionParam = action;
            settingIndex = index;
            settings = splitSettings;
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
            this.Close();
        }

        private void frmAjoutModifConfig_Load(object sender, EventArgs e)
        {
            switch (actionParam)
            {
                case "Modif":
                    lblHeader.Text = "Modification de paramètre";
                    break;
                case "Ajout":
                    lblHeader.Text = "Ajout d'un paramètre";
                    break;
            }

            Remplir_Formulaire();
        }

        private void Remplir_Formulaire()
        {
            if (settings is null)
                return;

           foreach (Settings param in settings)
            {
                if (param.settingName == settingTag)
                {
                    txtConfig.Text = param.settingName;

                    if (param.settingType == "i")
                        cmbType.SelectedIndex = 0;
                    else
                        cmbType.SelectedIndex = 1;

                    txtValue.Text = param.settingValue;
                }
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;


            foreach (Form f in fc)
            {
                if (f.Name == "frmConfig")
                {
                    frmConfig f1 = (frmConfig)f;

                    if (Valider_Form() == false)
                        return;

                    if (actionParam == "Modif")
                    {
                        string config, value, type;

                        config = txtConfig.Text.Trim();
                        value = txtValue.Text.Trim();

                        if (cmbType.Text == "Integer")
                            type = "i";
                        else
                            type = "s";


                        Settings setting = new Settings(config, type, value);

                        f1.UpdateElement(setting, settingIndex);
                        
                    }
                    else
                    {
                        string config, value, type;

                        config = txtConfig.Text.Trim();
                        value = txtValue.Text.Trim();

                        if (cmbType.Text == "Integer")
                            type = "i";
                        else
                            type = "s";


                        Settings setting = new Settings(config, type, value);

                        f1.AddElement(setting, settingTag);
                    }
                }
            }

            this.Close();
        }

        private bool Valider_Form()
        {
            bool ok = true;

            if (txtConfig.Text.Trim() == "")
            {
                erp.SetError(txtConfig, "Nom obligatoire");
                ok = false;
            }

            if (cmbType.Text == "Integer" && txtValue.Text.Trim() == "")
            {
                erp.SetError(txtValue, "Valeur du parametre obligatoire");
                ok = false;
            }

            if (cmbType.SelectedIndex == -1)
            {
                erp.SetError(cmbType, "Type de valeur obligatoire");
                ok = false;
            }

            return ok;
        }
    }
}
