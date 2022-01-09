namespace SayisalLoto4
{
    partial class frmKullanıcı
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.linkLabelKayıtOl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtTC_No = new System.Windows.Forms.TextBox();
            this.lblTC_No = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.linkLabelKayıtOl);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnGiriş);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtTC_No);
            this.groupBox1.Controls.Add(this.lblTC_No);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(321, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Snow;
            this.btnCikis.Location = new System.Drawing.Point(593, 412);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(88, 37);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // linkLabelKayıtOl
            // 
            this.linkLabelKayıtOl.AutoSize = true;
            this.linkLabelKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelKayıtOl.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelKayıtOl.Location = new System.Drawing.Point(319, 378);
            this.linkLabelKayıtOl.Name = "linkLabelKayıtOl";
            this.linkLabelKayıtOl.Size = new System.Drawing.Size(70, 20);
            this.linkLabelKayıtOl.TabIndex = 3;
            this.linkLabelKayıtOl.TabStop = true;
            this.linkLabelKayıtOl.Text = "Kayıt Ol";
            this.linkLabelKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::SayisalLoto4.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(157, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackColor = System.Drawing.Color.Snow;
            this.btnGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.Location = new System.Drawing.Point(261, 296);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(177, 61);
            this.btnGiriş.TabIndex = 2;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.UseVisualStyleBackColor = false;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Snow;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Firebrick;
            this.txtSifre.Location = new System.Drawing.Point(240, 221);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(237, 26);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(237, 196);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(52, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Şifre:";
            // 
            // txtTC_No
            // 
            this.txtTC_No.BackColor = System.Drawing.Color.Snow;
            this.txtTC_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC_No.ForeColor = System.Drawing.Color.Brown;
            this.txtTC_No.Location = new System.Drawing.Point(240, 163);
            this.txtTC_No.MaxLength = 11;
            this.txtTC_No.Name = "txtTC_No";
            this.txtTC_No.Size = new System.Drawing.Size(237, 26);
            this.txtTC_No.TabIndex = 0;
            this.txtTC_No.TextChanged += new System.EventHandler(this.txtTC_No_TextChanged);
            this.txtTC_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_No_KeyPress);
            // 
            // lblTC_No
            // 
            this.lblTC_No.AutoSize = true;
            this.lblTC_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC_No.Location = new System.Drawing.Point(237, 132);
            this.lblTC_No.Name = "lblTC_No";
            this.lblTC_No.Size = new System.Drawing.Size(63, 20);
            this.lblTC_No.TabIndex = 0;
            this.lblTC_No.Text = "TC No:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1300, 620);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKullanıcı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtTC_No;
        private System.Windows.Forms.Label lblTC_No;
        private System.Windows.Forms.LinkLabel linkLabelKayıtOl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCikis;
    }
}

