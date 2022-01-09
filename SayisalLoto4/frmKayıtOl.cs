using System;

using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SayisalLoto4
{
    public partial class frmKayıtOl : Form
    {
        public frmKayıtOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DILBERASLAN\\SQL2019;Initial Catalog=SayisalLoto4;Integrated Security=True");


        Kullanıcı_Formu k = new Kullanıcı_Formu();


        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            k.yenikullanıcı(TC_Notxt, Adtxt, Soyadtxt, Sifretxt, SifreTekrartxt, DogumTarihiddt, ComboBox2, ComboBox3);
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            ComboBox2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Ilce,IlceID from Ilceler where IlID=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);//comboboxtan seçilen id nin 1 fazlasına karşılık gelen ilçe değerlerini yazdırsın.
            SqlDataReader dr2 = komut2.ExecuteReader();
            ComboBox2.DisplayMember = "Text";
            ComboBox2.ValueMember = "Value";
            while (dr2.Read())
            {
                ComboBox2.Items.Add(new { Text = dr2[0], Value = Convert.ToInt32(dr2[1]) });
            }
            baglanti.Close();
        }

        private void frmKayıtOl_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Il from Iller", baglanti);//iller tablsoundan il bilgisini çekecek.
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Cinsiyet,CinsiyetID from Cinsiyet", baglanti);//Cinsiyet tablsoundan cinsiyet bilgisini çekecek.
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                ComboBox3.Items.Add(read[0]);
            }
            baglanti.Close();
        }


        private void TC_Notxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }

        }

        private void Adtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve harf değilse 
            {
                e.Handled = true;
            }
        }

        private void Soyadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve harf değilse 
            {
                e.Handled = true;
            }
        }

        private void TC_Notxt_TextChanged(object sender, EventArgs e)
        {
            if (TC_Notxt.Text.Length < 11 || TC_Notxt.Text.Length > 11)
            {
                errorProvider1.SetError(TC_Notxt, "TC Kimlik No 11 karakter olmalı.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void SifreTekrartxt_TextChanged(object sender, EventArgs e)
        {
            if ((Sifretxt.Text == SifreTekrartxt.Text) || (SifreTekrartxt.Text == Sifretxt.Text))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(Sifretxt, "Girilen degerler eşleşmiyor.");
                errorProvider1.SetError(SifreTekrartxt, "Girilen degerler eşleşmiyor.");
            }
        }

        private void Sifretxt_TextChanged(object sender, EventArgs e)
        {
            if (Sifretxt.TextLength < 6)
            {
                errorProvider1.SetError(Sifretxt, "Şifreniz en az 6 haneli olmalıdır.");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void btnGiriseDon_Click(object sender, EventArgs e)
        {
            frmKullanıcı kullanıcı = new frmKullanıcı();
            this.Hide();
            kullanıcı.Show();
        }

       
    }
} 

     
