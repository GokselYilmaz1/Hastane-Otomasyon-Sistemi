namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.MaskTC = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.Label();
            this.LnkÜyeOl = new System.Windows.Forms.LinkLabel();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtŞifre = new System.Windows.Forms.TextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaskTC
            // 
            this.MaskTC.AutoSize = true;
            this.MaskTC.BackColor = System.Drawing.Color.Transparent;
            this.MaskTC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskTC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaskTC.Location = new System.Drawing.Point(61, 121);
            this.MaskTC.Name = "MaskTC";
            this.MaskTC.Size = new System.Drawing.Size(128, 24);
            this.MaskTC.TabIndex = 1;
            this.MaskTC.Text = "TC Kimlik No:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.AutoSize = true;
            this.TxtSifre.BackColor = System.Drawing.Color.Transparent;
            this.TxtSifre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSifre.Location = new System.Drawing.Point(132, 173);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(57, 24);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.Text = "Şifre:";
            // 
            // LnkÜyeOl
            // 
            this.LnkÜyeOl.AutoSize = true;
            this.LnkÜyeOl.LinkColor = System.Drawing.Color.Red;
            this.LnkÜyeOl.Location = new System.Drawing.Point(166, 231);
            this.LnkÜyeOl.Name = "LnkÜyeOl";
            this.LnkÜyeOl.Size = new System.Drawing.Size(66, 24);
            this.LnkÜyeOl.TabIndex = 3;
            this.LnkÜyeOl.TabStop = true;
            this.LnkÜyeOl.Text = "Üye Ol";
            this.LnkÜyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkÜyeOl_LinkClicked);
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.MskTC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MskTC.Location = new System.Drawing.Point(195, 121);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(160, 32);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtŞifre
            // 
            this.TxtŞifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.TxtŞifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtŞifre.Location = new System.Drawing.Point(195, 170);
            this.TxtŞifre.Name = "TxtŞifre";
            this.TxtŞifre.Size = new System.Drawing.Size(160, 32);
            this.TxtŞifre.TabIndex = 5;
            this.TxtŞifre.UseSystemPasswordChar = true;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.Location = new System.Drawing.Point(238, 220);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(117, 35);
            this.BtnGirisYap.TabIndex = 6;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta Giriş Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Proje_Hastane.Properties.Resources.back_button_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtŞifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.LnkÜyeOl);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MaskTC);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHastaGiris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MaskTC;
        private System.Windows.Forms.Label TxtSifre;
        private System.Windows.Forms.LinkLabel LnkÜyeOl;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtŞifre;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}