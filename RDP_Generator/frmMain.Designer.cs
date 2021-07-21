
namespace RDP_Generator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmdMinimiser = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvEtus = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_da = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_courriel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ordinateur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.lblEtus = new System.Windows.Forms.Label();
            this.cmdParcourirDest = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdParcourirInfos = new System.Windows.Forms.Button();
            this.lblInfosEtus = new System.Windows.Forms.Label();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtInfosEtus = new System.Windows.Forms.TextBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdConfig = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.panel16.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.Snow;
            this.lblTitre.Location = new System.Drawing.Point(12, 5);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(101, 45);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Login";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel16.Controls.Add(this.button9);
            this.panel16.Controls.Add(this.lblTitre);
            this.panel16.Location = new System.Drawing.Point(-460, -265);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1720, 55);
            this.panel16.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button9.ForeColor = System.Drawing.Color.Snow;
            this.button9.Location = new System.Drawing.Point(1583, 9);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 36);
            this.button9.TabIndex = 24;
            this.button9.Text = "Retour";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(146)))));
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.cmdMinimiser);
            this.pnlHeader.Controls.Add(this.cmdQuitter);
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(596, 45);
            this.pnlHeader.TabIndex = 4;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 2);
            this.panel2.TabIndex = 41;
            this.panel2.Tag = "div";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::RDP_Generator.Properties.Resources.logo_trans;
            this.picLogo.Location = new System.Drawing.Point(4, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 35;
            this.picLogo.TabStop = false;
            // 
            // cmdMinimiser
            // 
            this.cmdMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.cmdMinimiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimiser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdMinimiser.ForeColor = System.Drawing.Color.Snow;
            this.cmdMinimiser.Location = new System.Drawing.Point(517, 8);
            this.cmdMinimiser.Margin = new System.Windows.Forms.Padding(0);
            this.cmdMinimiser.Name = "cmdMinimiser";
            this.cmdMinimiser.Size = new System.Drawing.Size(30, 30);
            this.cmdMinimiser.TabIndex = 26;
            this.cmdMinimiser.Text = "-";
            this.cmdMinimiser.UseVisualStyleBackColor = false;
            this.cmdMinimiser.Click += new System.EventHandler(this.cmdMinimiser_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdQuitter.BackColor = System.Drawing.Color.Transparent;
            this.cmdQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuitter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdQuitter.ForeColor = System.Drawing.Color.Snow;
            this.cmdQuitter.Location = new System.Drawing.Point(557, 8);
            this.cmdQuitter.Margin = new System.Windows.Forms.Padding(0);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(30, 30);
            this.cmdQuitter.TabIndex = 25;
            this.cmdQuitter.Text = "X";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(1583, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Snow;
            this.lblHeader.Location = new System.Drawing.Point(46, -1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(255, 45);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Générateur RDP";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.lblHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Snow;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.lvEtus);
            this.pnlMain.Controls.Add(this.cmdSupprimer);
            this.pnlMain.Controls.Add(this.lblEtus);
            this.pnlMain.Controls.Add(this.cmdParcourirDest);
            this.pnlMain.Controls.Add(this.lblDestination);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.cmdParcourirInfos);
            this.pnlMain.Controls.Add(this.lblInfosEtus);
            this.pnlMain.Controls.Add(this.cmdAjouter);
            this.pnlMain.Controls.Add(this.txtDestination);
            this.pnlMain.Controls.Add(this.txtInfosEtus);
            this.pnlMain.Controls.Add(this.cmdAnnuler);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.cmdConfig);
            this.pnlMain.Controls.Add(this.cmdOK);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(598, 665);
            this.pnlMain.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(10, 555);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(575, 1);
            this.panel5.TabIndex = 48;
            this.panel5.Tag = "div";
            // 
            // lvEtus
            // 
            this.lvEtus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_da,
            this.col_courriel,
            this.Ordinateur});
            this.lvEtus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEtus.GridLines = true;
            this.lvEtus.HideSelection = false;
            this.lvEtus.Location = new System.Drawing.Point(23, 198);
            this.lvEtus.Name = "lvEtus";
            this.lvEtus.Size = new System.Drawing.Size(551, 315);
            this.lvEtus.TabIndex = 47;
            this.lvEtus.UseCompatibleStateImageBehavior = false;
            this.lvEtus.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "Nom";
            this.col_name.Width = 200;
            // 
            // col_da
            // 
            this.col_da.Text = "DA";
            this.col_da.Width = 100;
            // 
            // col_courriel
            // 
            this.col_courriel.Text = "Courriel";
            this.col_courriel.Width = 170;
            // 
            // Ordinateur
            // 
            this.Ordinateur.Text = "Ordinateur";
            this.Ordinateur.Width = 75;
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.cmdSupprimer.Enabled = false;
            this.cmdSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSupprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupprimer.ForeColor = System.Drawing.Color.Snow;
            this.cmdSupprimer.Location = new System.Drawing.Point(463, 515);
            this.cmdSupprimer.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(111, 36);
            this.cmdSupprimer.TabIndex = 46;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = false;
            // 
            // lblEtus
            // 
            this.lblEtus.AutoSize = true;
            this.lblEtus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblEtus.Location = new System.Drawing.Point(16, 169);
            this.lblEtus.Name = "lblEtus";
            this.lblEtus.Size = new System.Drawing.Size(175, 25);
            this.lblEtus.TabIndex = 42;
            this.lblEtus.Text = "Liste des étudiants:";
            // 
            // cmdParcourirDest
            // 
            this.cmdParcourirDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdParcourirDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdParcourirDest.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdParcourirDest.ForeColor = System.Drawing.Color.Snow;
            this.cmdParcourirDest.Location = new System.Drawing.Point(541, 564);
            this.cmdParcourirDest.Margin = new System.Windows.Forms.Padding(0);
            this.cmdParcourirDest.Name = "cmdParcourirDest";
            this.cmdParcourirDest.Size = new System.Drawing.Size(34, 36);
            this.cmdParcourirDest.TabIndex = 40;
            this.cmdParcourirDest.Text = "..";
            this.cmdParcourirDest.UseVisualStyleBackColor = false;
            this.cmdParcourirDest.Click += new System.EventHandler(this.cmdParcourirDest_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDestination.Location = new System.Drawing.Point(19, 570);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(184, 25);
            this.lblDestination.TabIndex = 39;
            this.lblDestination.Text = "Dossier Destination:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 2);
            this.panel1.TabIndex = 38;
            this.panel1.Tag = "div";
            // 
            // cmdParcourirInfos
            // 
            this.cmdParcourirInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdParcourirInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdParcourirInfos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdParcourirInfos.ForeColor = System.Drawing.Color.Snow;
            this.cmdParcourirInfos.Location = new System.Drawing.Point(540, 71);
            this.cmdParcourirInfos.Margin = new System.Windows.Forms.Padding(0);
            this.cmdParcourirInfos.Name = "cmdParcourirInfos";
            this.cmdParcourirInfos.Size = new System.Drawing.Size(34, 36);
            this.cmdParcourirInfos.TabIndex = 37;
            this.cmdParcourirInfos.Text = "..";
            this.cmdParcourirInfos.UseVisualStyleBackColor = false;
            this.cmdParcourirInfos.Click += new System.EventHandler(this.cmdParcourirInfos_Click);
            // 
            // lblInfosEtus
            // 
            this.lblInfosEtus.AutoSize = true;
            this.lblInfosEtus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblInfosEtus.Location = new System.Drawing.Point(15, 78);
            this.lblInfosEtus.Name = "lblInfosEtus";
            this.lblInfosEtus.Size = new System.Drawing.Size(145, 25);
            this.lblInfosEtus.TabIndex = 36;
            this.lblInfosEtus.Text = "Infos Étudiants:";
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjouter.ForeColor = System.Drawing.Color.Snow;
            this.cmdAjouter.Location = new System.Drawing.Point(505, 71);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(34, 36);
            this.cmdAjouter.TabIndex = 35;
            this.cmdAjouter.Text = "+";
            this.cmdAjouter.UseVisualStyleBackColor = false;
            // 
            // txtDestination
            // 
            this.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtDestination.Location = new System.Drawing.Point(209, 564);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(328, 35);
            this.txtDestination.TabIndex = 33;
            // 
            // txtInfosEtus
            // 
            this.txtInfosEtus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfosEtus.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtInfosEtus.Location = new System.Drawing.Point(166, 72);
            this.txtInfosEtus.Name = "txtInfosEtus";
            this.txtInfosEtus.Size = new System.Drawing.Size(336, 35);
            this.txtInfosEtus.TabIndex = 31;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAnnuler.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Underline);
            this.cmdAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAnnuler.Location = new System.Drawing.Point(362, 617);
            this.cmdAnnuler.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(97, 36);
            this.cmdAnnuler.TabIndex = 30;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = false;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(11, 606);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(575, 2);
            this.panel4.TabIndex = 29;
            this.panel4.Tag = "div";
            // 
            // cmdConfig
            // 
            this.cmdConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfig.ForeColor = System.Drawing.Color.Snow;
            this.cmdConfig.Location = new System.Drawing.Point(414, 118);
            this.cmdConfig.Margin = new System.Windows.Forms.Padding(0);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.Size = new System.Drawing.Size(160, 36);
            this.cmdConfig.TabIndex = 27;
            this.cmdConfig.Text = "Configuration";
            this.cmdConfig.UseVisualStyleBackColor = false;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(100)))));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOK.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.Snow;
            this.cmdOK.Location = new System.Drawing.Point(474, 617);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(101, 36);
            this.cmdOK.TabIndex = 25;
            this.cmdOK.Text = "Vérifier";
            this.cmdOK.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 665);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button cmdMinimiser;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cmdConfig;
        private System.Windows.Forms.TextBox txtInfosEtus;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdParcourirInfos;
        private System.Windows.Forms.Label lblInfosEtus;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button cmdParcourirDest;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEtus;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.ListView lvEtus;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_da;
        private System.Windows.Forms.ColumnHeader col_courriel;
        private System.Windows.Forms.ColumnHeader Ordinateur;
        private System.Windows.Forms.Panel panel5;
    }
}

