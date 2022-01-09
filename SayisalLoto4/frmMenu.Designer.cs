namespace SayisalLoto4
{
    partial class frmMenu
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
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSonuclariGor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.BackColor = System.Drawing.Color.Snow;
            this.btnTahminEt.Location = new System.Drawing.Point(117, 89);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(123, 49);
            this.btnTahminEt.TabIndex = 0;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = false;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.BackColor = System.Drawing.Color.Snow;
            this.btnCekilisYap.Location = new System.Drawing.Point(117, 144);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(123, 53);
            this.btnCekilisYap.TabIndex = 1;
            this.btnCekilisYap.Text = "Çekiliş Yap";
            this.btnCekilisYap.UseVisualStyleBackColor = false;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnSonuclariGor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCekilisYap);
            this.groupBox1.Controls.Add(this.btnTahminEt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(468, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // btnSonuclariGor
            // 
            this.btnSonuclariGor.BackColor = System.Drawing.Color.Snow;
            this.btnSonuclariGor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnSonuclariGor.Location = new System.Drawing.Point(117, 203);
            this.btnSonuclariGor.Name = "btnSonuclariGor";
            this.btnSonuclariGor.Size = new System.Drawing.Size(123, 53);
            this.btnSonuclariGor.TabIndex = 3;
            this.btnSonuclariGor.Text = "Sonuçları Gör";
            this.btnSonuclariGor.UseVisualStyleBackColor = false;
            this.btnSonuclariGor.Click += new System.EventHandler(this.btnSonuclariGor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = ".Hafta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "XX";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1301, 621);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSonuclariGor;
    }
}