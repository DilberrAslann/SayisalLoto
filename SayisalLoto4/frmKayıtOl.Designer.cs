namespace SayisalLoto4
{
    partial class frmKayıtOl
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
            this.btnGiriseDon = new System.Windows.Forms.Button();
            this.SifreTekrartxt = new System.Windows.Forms.TextBox();
            this.Sifretxt = new System.Windows.Forms.TextBox();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.DogumTarihiddt = new System.Windows.Forms.DateTimePicker();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.Soyadtxt = new System.Windows.Forms.TextBox();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.TC_Notxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cinsiyetlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ilcelbl = new System.Windows.Forms.Label();
            this.DogumTarihilbl = new System.Windows.Forms.Label();
            this.Soyadlbl = new System.Windows.Forms.Label();
            this.Adlbl = new System.Windows.Forms.Label();
            this.TC_Nolbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnGiriseDon);
            this.groupBox1.Controls.Add(this.SifreTekrartxt);
            this.groupBox1.Controls.Add(this.Sifretxt);
            this.groupBox1.Controls.Add(this.ComboBox3);
            this.groupBox1.Controls.Add(this.DogumTarihiddt);
            this.groupBox1.Controls.Add(this.ComboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnKayıtOl);
            this.groupBox1.Controls.Add(this.Soyadtxt);
            this.groupBox1.Controls.Add(this.Adtxt);
            this.groupBox1.Controls.Add(this.TC_Notxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cinsiyetlbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ilcelbl);
            this.groupBox1.Controls.Add(this.DogumTarihilbl);
            this.groupBox1.Controls.Add(this.Soyadlbl);
            this.groupBox1.Controls.Add(this.Adlbl);
            this.groupBox1.Controls.Add(this.TC_Nolbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(274, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kullanıcı";
            // 
            // btnGiriseDon
            // 
            this.btnGiriseDon.BackColor = System.Drawing.Color.Snow;
            this.btnGiriseDon.Location = new System.Drawing.Point(300, 399);
            this.btnGiriseDon.Name = "btnGiriseDon";
            this.btnGiriseDon.Size = new System.Drawing.Size(136, 52);
            this.btnGiriseDon.TabIndex = 10;
            this.btnGiriseDon.Text = "Giriş sayfasına git";
            this.btnGiriseDon.UseVisualStyleBackColor = false;
            this.btnGiriseDon.Click += new System.EventHandler(this.btnGiriseDon_Click);
            // 
            // SifreTekrartxt
            // 
            this.SifreTekrartxt.ForeColor = System.Drawing.Color.Brown;
            this.SifreTekrartxt.Location = new System.Drawing.Point(291, 306);
            this.SifreTekrartxt.Name = "SifreTekrartxt";
            this.SifreTekrartxt.PasswordChar = '*';
            this.SifreTekrartxt.Size = new System.Drawing.Size(173, 26);
            this.SifreTekrartxt.TabIndex = 8;
            this.SifreTekrartxt.TextChanged += new System.EventHandler(this.SifreTekrartxt_TextChanged);
            // 
            // Sifretxt
            // 
            this.Sifretxt.ForeColor = System.Drawing.Color.Brown;
            this.Sifretxt.Location = new System.Drawing.Point(291, 275);
            this.Sifretxt.Name = "Sifretxt";
            this.Sifretxt.PasswordChar = '*';
            this.Sifretxt.Size = new System.Drawing.Size(173, 26);
            this.Sifretxt.TabIndex = 7;
            this.Sifretxt.TextChanged += new System.EventHandler(this.Sifretxt_TextChanged);
            // 
            // ComboBox3
            // 
            this.ComboBox3.BackColor = System.Drawing.Color.Snow;
            this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox3.ForeColor = System.Drawing.Color.Brown;
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(291, 241);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(173, 28);
            this.ComboBox3.TabIndex = 6;
            // 
            // DogumTarihiddt
            // 
            this.DogumTarihiddt.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.DogumTarihiddt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogumTarihiddt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DogumTarihiddt.Location = new System.Drawing.Point(300, 154);
            this.DogumTarihiddt.Name = "DogumTarihiddt";
            this.DogumTarihiddt.Size = new System.Drawing.Size(210, 22);
            this.DogumTarihiddt.TabIndex = 3;
            // 
            // ComboBox2
            // 
            this.ComboBox2.BackColor = System.Drawing.Color.Snow;
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.ForeColor = System.Drawing.Color.Brown;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(389, 184);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 28);
            this.ComboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Snow;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Brown;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.Snow;
            this.btnKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnKayıtOl.Location = new System.Drawing.Point(300, 348);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(136, 45);
            this.btnKayıtOl.TabIndex = 9;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // Soyadtxt
            // 
            this.Soyadtxt.ForeColor = System.Drawing.Color.Brown;
            this.Soyadtxt.Location = new System.Drawing.Point(291, 122);
            this.Soyadtxt.Name = "Soyadtxt";
            this.Soyadtxt.Size = new System.Drawing.Size(173, 26);
            this.Soyadtxt.TabIndex = 2;
            this.Soyadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Soyadtxt_KeyPress);
            // 
            // Adtxt
            // 
            this.Adtxt.ForeColor = System.Drawing.Color.Brown;
            this.Adtxt.Location = new System.Drawing.Point(291, 92);
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(173, 26);
            this.Adtxt.TabIndex = 1;
            this.Adtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Adtxt_KeyPress);
            // 
            // TC_Notxt
            // 
            this.TC_Notxt.ForeColor = System.Drawing.Color.Brown;
            this.TC_Notxt.Location = new System.Drawing.Point(291, 60);
            this.TC_Notxt.MaxLength = 11;
            this.TC_Notxt.Name = "TC_Notxt";
            this.TC_Notxt.Size = new System.Drawing.Size(173, 26);
            this.TC_Notxt.TabIndex = 0;
            this.TC_Notxt.TextChanged += new System.EventHandler(this.TC_Notxt_TextChanged);
            this.TC_Notxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TC_Notxt_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(176, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(232, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // Cinsiyetlbl
            // 
            this.Cinsiyetlbl.AutoSize = true;
            this.Cinsiyetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cinsiyetlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Cinsiyetlbl.Location = new System.Drawing.Point(207, 244);
            this.Cinsiyetlbl.Name = "Cinsiyetlbl";
            this.Cinsiyetlbl.Size = new System.Drawing.Size(77, 20);
            this.Cinsiyetlbl.TabIndex = 0;
            this.Cinsiyetlbl.Text = "Cinsiyet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(183, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl:";
            // 
            // Ilcelbl
            // 
            this.Ilcelbl.AutoSize = true;
            this.Ilcelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ilcelbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Ilcelbl.Location = new System.Drawing.Point(340, 192);
            this.Ilcelbl.Name = "Ilcelbl";
            this.Ilcelbl.Size = new System.Drawing.Size(43, 20);
            this.Ilcelbl.TabIndex = 0;
            this.Ilcelbl.Text = "İlçe:";
            // 
            // DogumTarihilbl
            // 
            this.DogumTarihilbl.AutoSize = true;
            this.DogumTarihilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogumTarihilbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DogumTarihilbl.Location = new System.Drawing.Point(166, 152);
            this.DogumTarihilbl.Name = "DogumTarihilbl";
            this.DogumTarihilbl.Size = new System.Drawing.Size(120, 20);
            this.DogumTarihilbl.TabIndex = 0;
            this.DogumTarihilbl.Text = "Doğum Tarihi:";
            // 
            // Soyadlbl
            // 
            this.Soyadlbl.AutoSize = true;
            this.Soyadlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyadlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Soyadlbl.Location = new System.Drawing.Point(222, 122);
            this.Soyadlbl.Name = "Soyadlbl";
            this.Soyadlbl.Size = new System.Drawing.Size(64, 20);
            this.Soyadlbl.TabIndex = 0;
            this.Soyadlbl.Text = "Soyad:";
            // 
            // Adlbl
            // 
            this.Adlbl.AutoSize = true;
            this.Adlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Adlbl.Location = new System.Drawing.Point(249, 90);
            this.Adlbl.Name = "Adlbl";
            this.Adlbl.Size = new System.Drawing.Size(36, 20);
            this.Adlbl.TabIndex = 0;
            this.Adlbl.Text = "Ad:";
            // 
            // TC_Nolbl
            // 
            this.TC_Nolbl.AutoSize = true;
            this.TC_Nolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TC_Nolbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TC_Nolbl.Location = new System.Drawing.Point(222, 60);
            this.TC_Nolbl.Name = "TC_Nolbl";
            this.TC_Nolbl.Size = new System.Drawing.Size(63, 20);
            this.TC_Nolbl.TabIndex = 0;
            this.TC_Nolbl.Text = "TC No:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1190, 620);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKayıtOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kullanıcı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKayıtOl_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TC_Notxt;
        private System.Windows.Forms.Label TC_Nolbl;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.TextBox Soyadtxt;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.Label Cinsiyetlbl;
        private System.Windows.Forms.Label Ilcelbl;
        private System.Windows.Forms.Label DogumTarihilbl;
        private System.Windows.Forms.Label Soyadlbl;
        private System.Windows.Forms.Label Adlbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DogumTarihiddt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SifreTekrartxt;
        private System.Windows.Forms.TextBox Sifretxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
       // private DataSet1 dataSet11;
        private System.Windows.Forms.Button btnGiriseDon;
        public System.Windows.Forms.ComboBox ComboBox2;
    }
}