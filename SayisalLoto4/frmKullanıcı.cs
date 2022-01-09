using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto4
{
    public partial class frmKullanıcı : Form
    {
        public frmKullanıcı()
        {
            InitializeComponent();
        }
                
       Kullanıcı_Formu k = new Kullanıcı_Formu();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayıtOl Kayıt_Ol = new frmKayıtOl();
            this.Hide();
            Kayıt_Ol.ShowDialog();
        }
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            k.kullanıcı(txtTC_No,txtSifre);            
        }

        private void txtTC_No_KeyPress(object sender, KeyPressEventArgs e)//klavyeden girilen değerlerin sadece sayı olması koşulu
        {
            if (char.IsDigit(e.KeyChar)==false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }
        }             
        
        private void txtTC_No_TextChanged(object sender, EventArgs e)
        {
            if (txtTC_No.Text.Length < 11 || txtTC_No.Text.Length > 11)
            {
                errorProvider1.SetError(txtTC_No, "TC Kimlik No 11 karakter olmalı.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text.Length < 6)
            {
                errorProvider1.SetError(txtSifre, "Sifreniz en az 6 karakter olmalı.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
