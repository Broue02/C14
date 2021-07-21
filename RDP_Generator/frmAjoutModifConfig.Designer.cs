
namespace RDP_Generator
{
    partial class frmAjoutModifConfig
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdAnnuler = new System.Windows.Forms.Button();
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
            this.lblHeader.Size = new System.Drawing.Size(87, 45);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Titre";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.lblHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Snow;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtValue);
            this.pnlMain.Controls.Add(this.cmbType);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtConfig);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.cmdAnnuler);
            this.pnlMain.Controls.Add(this.cmdOk);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(598, 273);
            this.pnlMain.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(71, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Valeur:";
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtValue.Location = new System.Drawing.Point(201, 157);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(348, 35);
            this.txtValue.TabIndex = 50;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Integer",
            "String"});
            this.cmbType.Location = new System.Drawing.Point(201, 111);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 38);
            this.cmbType.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Configuration:";
            // 
            // txtConfig
            // 
            this.txtConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfig.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtConfig.Location = new System.Drawing.Point(201, 66);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(348, 35);
            this.txtConfig.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(575, 2);
            this.panel4.TabIndex = 44;
            this.panel4.Tag = "div";
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAnnuler.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Underline);
            this.cmdAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAnnuler.Location = new System.Drawing.Point(361, 227);
            this.cmdAnnuler.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(97, 36);
            this.cmdAnnuler.TabIndex = 30;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = false;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(100)))));
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOk.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.ForeColor = System.Drawing.Color.Snow;
            this.cmdOk.Location = new System.Drawing.Point(473, 227);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(101, 36);
            this.cmdOk.TabIndex = 25;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = false;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // frmAjoutModifConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 273);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjoutModifConfig";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAjoutModifConfig_Load);
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
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
    }
}

