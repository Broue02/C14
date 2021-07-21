﻿using System;
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
        ArrayList settings = new ArrayList();
        public frmAjoutModifConfig(string action, string tag)
        {
            InitializeComponent();
            cmdAnnuler.FlatAppearance.BorderSize = 0;

            settingTag = tag;
            actionParam = action;
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


            settings = GetConfig.GetConfigArray();
            Remplir_Formulaire();
        }

        private void Remplir_Formulaire()
        {
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

    }
}