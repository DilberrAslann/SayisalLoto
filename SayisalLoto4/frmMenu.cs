using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto4
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DILBERASLAN\\SQL2019;Initial Catalog=SayisalLoto4;Integrated Security=True");
        SqlDataReader read;
        SqlCommand komut;
        
        public int GetWeekNumber(DateTime dtPassed)//Bugünün tarihini yılın kaçıncı haftası olduğuna dönüştüren fonksiyon.
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int hafta = GetWeekNumber(DateTime.Now);

            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select Hafta from Sonuclar where Hafta=@p1";//Bu haftaya ait loto sonucu çekilenleri seç
            komut.Parameters.AddWithValue("@p1", hafta.ToString());
            read = komut.ExecuteReader();

            if (read.Read() == true)
            {
                MessageBox.Show("Bu döneme ait çekiliş oluşturulduğu için tahminde bulunamazsınız..");
                baglanti.Close();
            }
            else
            {
                frmOyna oyna = new frmOyna();
                this.Hide();
                oyna.Show();
            }
        }

        public void frmMenu_Load(object sender, EventArgs e)
        {
            int hafta = GetWeekNumber(DateTime.Now);
            label2.Text = Convert.ToString(hafta);
        }

        public void btnCekilisYap_Click(object sender, EventArgs e)
        {
            //string gun = DateTime.Now.DayOfWeek.ToString();          
            
                if (Kullanıcı_Formu.user.KisiID == 1)//KisiID si 1 olan kullanıcı ise
                {
                //if (gun == "Saturday")
                //{
                    int hafta = GetWeekNumber(DateTime.Now);
                    baglanti.Open();
                    komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "select Hafta from Sonuclar where Hafta=@p1";
                    komut.Parameters.AddWithValue("@p1", hafta.ToString());
                    read = komut.ExecuteReader();

                    if (read.Read() == true)
                    {
                        MessageBox.Show("Bu döneme ait çekiliş zaten var.");
                        baglanti.Close();
                    }
                    else
                    {
                        baglanti.Close();
                        frmCekilis cekilis = new frmCekilis();
                        this.Hide();
                        cekilis.Show();
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Çekiliş yalnızca Cumartesi günleri çekilir.");
                //}
                }
                else
                {
                MessageBox.Show("Çekiliş yapma yetkiniz yok.");
                }
        }
            private void btnSonuclariGor_Click(object sender, EventArgs e)
            {
                frmSonuclariGör sonuclariGör = new frmSonuclariGör();
                this.Hide();
                sonuclariGör.Show();
            }        
    }
}
