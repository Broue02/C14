
namespace RDP_Generator
{
    partial class frmConfig
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
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdDefaut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDomaine = new System.Windows.Forms.TextBox();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdEnregistrer = new System.Windows.Forms.Button();
            this.lblConfigLV = new System.Windows.Forms.Label();
            this.lvConfigs = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_valeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdParcourir = new System.Windows.Forms.Button();
            this.lblConfig = new System.Windows.Forms.Label();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
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
            this.lblHeader.Size = new System.Drawing.Size(236, 45);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Configurations";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.lblHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Snow;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.cmdModifier);
            this.pnlMain.Controls.Add(this.cmdDefaut);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtDomaine);
            this.pnlMain.Controls.Add(this.lblDomaine);
            this.pnlMain.Controls.Add(this.cmdSupprimer);
            this.pnlMain.Controls.Add(this.cmdEnregistrer);
            this.pnlMain.Controls.Add(this.lblConfigLV);
            this.pnlMain.Controls.Add(this.lvConfigs);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.cmdParcourir);
            this.pnlMain.Controls.Add(this.lblConfig);
            this.pnlMain.Controls.Add(this.txtConfig);
            this.pnlMain.Controls.Add(this.cmdAnnuler);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.cmdAjouter);
            this.pnlMain.Controls.Add(this.cmdOk);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(598, 665);
            this.pnlMain.TabIndex = 5;
            // 
            // cmdModifier
            // 
            this.cmdModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModifier.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModifier.ForeColor = System.Drawing.Color.Snow;
            this.cmdModifier.Location = new System.Drawing.Point(373, 180);
            this.cmdModifier.Margin = new System.Windows.Forms.Padding(0);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(101, 36);
            this.cmdModifier.TabIndex = 55;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = false;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdDefaut
            // 
            this.cmdDefaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdDefaut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDefaut.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDefaut.ForeColor = System.Drawing.Color.Snow;
            this.cmdDefaut.Location = new System.Drawing.Point(272, 180);
            this.cmdDefaut.Margin = new System.Windows.Forms.Padding(0);
            this.cmdDefaut.Name = "cmdDefaut";
            this.cmdDefaut.Size = new System.Drawing.Size(101, 36);
            this.cmdDefaut.TabIndex = 54;
            this.cmdDefaut.Text = "Défauts";
            this.cmdDefaut.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "(Optionnel)";
            // 
            // txtDomaine
            // 
            this.txtDomaine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomaine.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtDomaine.Location = new System.Drawing.Point(189, 116);
            this.txtDomaine.Name = "txtDomaine";
            this.txtDomaine.Size = new System.Drawing.Size(348, 35);
            this.txtDomaine.TabIndex = 52;
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDomaine.Location = new System.Drawing.Point(19, 122);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(169, 25);
            this.lblDomaine.TabIndex = 50;
            this.lblDomaine.Text = "Nom de Domaine:";
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.cmdSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSupprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupprimer.ForeColor = System.Drawing.Color.Snow;
            this.cmdSupprimer.Location = new System.Drawing.Point(464, 547);
            this.cmdSupprimer.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(111, 36);
            this.cmdSupprimer.TabIndex = 45;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = false;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEnregistrer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnregistrer.ForeColor = System.Drawing.Color.Snow;
            this.cmdEnregistrer.Location = new System.Drawing.Point(24, 617);
            this.cmdEnregistrer.Margin = new System.Windows.Forms.Padding(0);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.Size = new System.Drawing.Size(133, 36);
            this.cmdEnregistrer.TabIndex = 43;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = false;
            this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
            // 
            // lblConfigLV
            // 
            this.lblConfigLV.AutoSize = true;
            this.lblConfigLV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblConfigLV.Location = new System.Drawing.Point(11, 191);
            this.lblConfigLV.Name = "lblConfigLV";
            this.lblConfigLV.Size = new System.Drawing.Size(139, 25);
            this.lblConfigLV.TabIndex = 42;
            this.lblConfigLV.Text = "Configurations";
            // 
            // lvConfigs
            // 
            this.lvConfigs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_type,
            this.col_valeur});
            this.lvConfigs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConfigs.FullRowSelect = true;
            this.lvConfigs.GridLines = true;
            this.lvConfigs.HideSelection = false;
            this.lvConfigs.Location = new System.Drawing.Point(24, 219);
            this.lvConfigs.Name = "lvConfigs";
            this.lvConfigs.Size = new System.Drawing.Size(551, 325);
            this.lvConfigs.TabIndex = 41;
            this.lvConfigs.UseCompatibleStateImageBehavior = false;
            this.lvConfigs.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "Configuration";
            this.col_name.Width = 280;
            // 
            // col_type
            // 
            this.col_type.Text = "Type";
            // 
            // col_valeur
            // 
            this.col_valeur.Text = "Valeur";
            this.col_valeur.Width = 200;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 2);
            this.panel1.TabIndex = 38;
            this.panel1.Tag = "div";
            // 
            // cmdParcourir
            // 
            this.cmdParcourir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdParcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdParcourir.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdParcourir.ForeColor = System.Drawing.Color.Snow;
            this.cmdParcourir.Location = new System.Drawing.Point(541, 71);
            this.cmdParcourir.Margin = new System.Windows.Forms.Padding(0);
            this.cmdParcourir.Name = "cmdParcourir";
            this.cmdParcourir.Size = new System.Drawing.Size(34, 36);
            this.cmdParcourir.TabIndex = 37;
            this.cmdParcourir.Text = "..";
            this.cmdParcourir.UseVisualStyleBackColor = false;
            this.cmdParcourir.Click += new System.EventHandler(this.cmdParcourir_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblConfig.Location = new System.Drawing.Point(28, 78);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(136, 25);
            this.lblConfig.TabIndex = 36;
            this.lblConfig.Text = "Configuration:";
            // 
            // txtConfig
            // 
            this.txtConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfig.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtConfig.Location = new System.Drawing.Point(189, 72);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(348, 35);
            this.txtConfig.TabIndex = 31;
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
            // cmdAjouter
            // 
            this.cmdAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(197)))));
            this.cmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjouter.ForeColor = System.Drawing.Color.Snow;
            this.cmdAjouter.Location = new System.Drawing.Point(474, 180);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(101, 36);
            this.cmdAjouter.TabIndex = 27;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = false;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(100)))));
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOk.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.ForeColor = System.Drawing.Color.Snow;
            this.cmdOk.Location = new System.Drawing.Point(474, 617);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(101, 36);
            this.cmdOk.TabIndex = 25;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = false;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 665);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfig";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmConfig_Load);
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
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdParcourir;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblConfigLV;
        private System.Windows.Forms.ListView lvConfigs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDomaine;
        private System.Windows.Forms.Label lblDomaine;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdEnregistrer;
        private System.Windows.Forms.Button cmdDefaut;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_type;
        private System.Windows.Forms.ColumnHeader col_valeur;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdAjouter;
    }
}

