
namespace RDP_Generator
{
    partial class frmVerif
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
            this.lblConfigLV = new System.Windows.Forms.Label();
            this.lvConfigs = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_valeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblConfig = new System.Windows.Forms.Label();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblHeader.Size = new System.Drawing.Size(185, 45);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Vérification";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.lblHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Snow;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.lblConfigLV);
            this.pnlMain.Controls.Add(this.lvConfigs);
            this.pnlMain.Controls.Add(this.lblConfig);
            this.pnlMain.Controls.Add(this.cmdAnnuler);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.cmdOk);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(598, 665);
            this.pnlMain.TabIndex = 5;
            // 
            // lblConfigLV
            // 
            this.lblConfigLV.AutoSize = true;
            this.lblConfigLV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblConfigLV.Location = new System.Drawing.Point(35, 155);
            this.lblConfigLV.Name = "lblConfigLV";
            this.lblConfigLV.Size = new System.Drawing.Size(131, 25);
            this.lblConfigLV.TabIndex = 42;
            this.lblConfigLV.Text = "Configuration";
            // 
            // lvConfigs
            // 
            this.lvConfigs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_valeur});
            this.lvConfigs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConfigs.FullRowSelect = true;
            this.lvConfigs.GridLines = true;
            this.lvConfigs.HideSelection = false;
            this.lvConfigs.Location = new System.Drawing.Point(49, 183);
            this.lvConfigs.Name = "lvConfigs";
            this.lvConfigs.Size = new System.Drawing.Size(498, 400);
            this.lvConfigs.TabIndex = 41;
            this.lvConfigs.UseCompatibleStateImageBehavior = false;
            this.lvConfigs.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "Configuration";
            this.col_name.Width = 280;
            // 
            // col_valeur
            // 
            this.col_valeur.Text = "Valeur";
            this.col_valeur.Width = 200;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblConfig.Location = new System.Drawing.Point(19, 56);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(459, 75);
            this.lblConfig.TabIndex = 36;
            this.lblConfig.Text = "Cette configuration est-elle valide?\r\n\r\nCliquez sur \'OK\' pour terminer la générat" +
    "ion de RDP.";
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
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 2);
            this.panel1.TabIndex = 43;
            this.panel1.Tag = "div";
            // 
            // frmVerif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 665);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerif";
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
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblConfigLV;
        private System.Windows.Forms.ListView lvConfigs;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_valeur;
        private System.Windows.Forms.Panel panel1;
    }
}

