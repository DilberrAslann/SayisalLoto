using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.InteropServices;

namespace SayisalLoto4
{
    
   
    public partial class frmOyna : Form
    {
   
        public frmOyna()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DILBERASLAN\\SQL2019;Initial Catalog=SayisalLoto4;Integrated Security=True");
        
        
        public static Donem donem;
        SqlDataReader read;
             
        
        public void frmOyna_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            int hafta = GetWeekNumber(DateTime.Now);//Şuanı GetWeekNumber fonksiyonuna göderip haftasını bulduruyoruz.
            SqlCommand komut2 = new SqlCommand("insert into Donem(Hafta,Yil) values(@p1,@p2)", baglanti);
            komut2.Parameters.AddWithValue("@p1",hafta.ToString());//hafta bilgisini alıyoruz.
            komut2.Parameters.AddWithValue("@p2",DateTime.Now.Year.ToString());//Şuanın yıl bilgisini alıyoruz.
            komut2.ExecuteNonQuery();

            label2.Text = Kullanıcı_Formu.user.Ad;           
            baglanti.Close();

            baglanti.Open();
            
            komut2 = new SqlCommand();
            komut2.Connection = baglanti;
            komut2.CommandText=("select top 1 * from Donem  where Hafta=@p3 order by DonemID desc");
            komut2.Parameters.AddWithValue("@p3",hafta.ToString());
            
            read = komut2.ExecuteReader();
            if (read.Read() == true)
            {

                int DonemID = read.GetInt32(0);
                string Hafta = read.GetString(1);
                string Yil = read.GetString(2);
                donem = new Donem(DonemID, Hafta, Yil);
            }

            baglanti.Close();
        }

        public int GetWeekNumber(DateTime dtPassed)//Bugünün tarihini yılın kaçıncı haftası olduğuna dönüştüren fonksiyon.
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
        
        private void VeriEkleme()//veritabanına ekleme yapacağımız kodları yazıyoruz.
        {
            if (txtTahmin1.Text == "" || txtTahmin2.Text == "" || txtTahmin3.Text == "" || txtTahmin4.Text == "" || txtTahmin5.Text == "" || txtTahmin6.Text == "")
            {
                MessageBox.Show("Tahmin ederken boş alan bırakamazsınız.");
            }
            else
            {
                int hafta = GetWeekNumber(DateTime.Now);

                //SayisalLoto isimli veritabanımızın kisitahmin isimli tablosuna textboxlarda yer alan metinleri aktaracağımız komutu tanımladık.
                int t1 = Convert.ToInt32(txtTahmin1.Text);
                int t2 = Convert.ToInt32(txtTahmin2.Text);
                int t3 = Convert.ToInt32(txtTahmin3.Text);
                int t4 = Convert.ToInt32(txtTahmin4.Text);
                int t5 = Convert.ToInt32(txtTahmin5.Text);
                int t6 = Convert.ToInt32(txtTahmin6.Text);
                if (t1 > 0 && t2 > 0 && t3 > 0 && t4 > 0 && t5 > 0 && t6 > 0)
                {
                    if ((t1 <= 49) && (t2 <= 49) && (t3 <= 49) && (t4 <= 49) && (t5 <= 49) && (t6 <= 49))
                    {
                        if ((t1 != t2) && (t1 != t3) && (t1 != t4) && (t1 != t5) && (t1 != t6) && (t2 != t3) && (t2 != t4) && (t2 != t5) && (t2 != t6) && (t3 != t4) && (t3 != t5) && (t3 != t6) && (t4 != t5) && (t4 != t6) && (t5 != t6))
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("Insert into KisiTahmin(KisiID,Tahmin1,Tahmin2,Tahmin3,Tahmin4,Tahmin5,Tahmin6,Hafta,DonemID) VALUES (@kid,@t1,@t2,@t3,@t4,@t5,@t6,@tarih,@d)", baglanti);
                            komut.Parameters.AddWithValue("kid", Kullanıcı_Formu.user.KisiID);
                            komut.Parameters.AddWithValue("@t1", txtTahmin1.Text);
                            komut.Parameters.AddWithValue("@t2", txtTahmin2.Text);
                            komut.Parameters.AddWithValue("@t3", txtTahmin3.Text);
                            komut.Parameters.AddWithValue("@t4", txtTahmin4.Text);
                            komut.Parameters.AddWithValue("@t5", txtTahmin5.Text);
                            komut.Parameters.AddWithValue("@t6", txtTahmin6.Text);
                            komut.Parameters.AddWithValue("@tarih", hafta.ToString());//Şuanın hafta bilgisini ekler.
                            komut.Parameters.AddWithValue("d", donem.DonemID);

                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Tahmininiz kaydedildi.", "Bilgilendirme Penceresi");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen farklı değerler giriniz.","Bilgilendirme Penceresi");
                            baglanti.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen 1-49 arası değerler giriniz.", "Bilgilendirme Penceresi");
                        baglanti.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Değerler 0 olamaz.");
                    baglanti.Close();
                }
                baglanti.Close();
            }
            baglanti.Close();
        }
        private void btnOkey_Click(object sender, EventArgs e)
        {            
            VeriEkleme();
        }
        private void Temizle()
        {
            txtTahmin1.Clear();
            txtTahmin2.Clear();
            txtTahmin3.Clear();
            txtTahmin4.Clear();
            txtTahmin5.Clear();
            txtTahmin6.Clear();
        }
       
        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtTahmin1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }
        }

        private void txtTahmin2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }
        }

        private void txtTahmin3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }
        }

        private void txtTahmin4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }
        }

        private void txtTahmin5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }
        }

        private void txtTahmin6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)//basılan tuş ASCII kodu 8 den(backspace)farklı ise ve sayı değilse 
            {
                e.Handled = true;
            }
        }
    }
}
