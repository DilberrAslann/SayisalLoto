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

namespace SayisalLoto4
{

    public partial class frmCekilis : Form
    {       
        public frmCekilis()
        {
            InitializeComponent();
        }

        public static Donem donem;
        SqlDataReader read;

        SqlConnection baglanti = new SqlConnection("Data Source=DILBERASLAN\\SQL2019;Initial Catalog=SayisalLoto4;Integrated Security=True");
        public int[] sayilar = new int[6];// sayilar adında 6 değer alabilen bir dizi oluşturduk.
        int tiklanmaSayisi = 0;

        public int GetWeekNumber(DateTime dtPassed)//Bugünün tarihini yılın kaçıncı haftası olduğuna dönüştüren fonksiyon.
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
        private void frmCekilis_Load(object sender, EventArgs e)
        {
            int hafta = GetWeekNumber(DateTime.Now);
            lblHafta.Text = Convert.ToString(hafta);

            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("select top 1 *  from Donem where Hafta=@p3 order by DonemID desc");
            komut.Parameters.AddWithValue("@p3", hafta.ToString());

            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                int DonemID = read.GetInt32(0);
                string Hafta = read.GetString(1);
                string Yil = read.GetString(2);
                donem = new Donem(DonemID,Hafta,Yil);
            }
            baglanti.Close();
        }
        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
                Olustur();
            if (tiklanmaSayisi == 1)
            {
                btnCekilisYap.Enabled = false;
            }
        }
        private void Olustur()
        {
            
                baglanti.Open();
                Random rastgeleSayi = new Random();//Random sayı alma 

                for (int i = 0; i < sayilar.Length; i++)//0dan sayilar dizisinin uzunluğuna gidecek for döngüsü.
                {
                BurayaDön:
                    int tahminEdilen = rastgeleSayi.Next(1, 49);//tahminEdilen sayıyı 1-49 arası rastgele alacak.)

                    if (!sayilar.Contains(tahminEdilen))//tahmin edilen değer dizinin içerisinde bulunmuyorsa
                    {
                        sayilar[i] = tahminEdilen;

                    }
                    else
                    {
                        goto BurayaDön;//BurayaDön e dönecek.
                    }
                }

                Array.Sort(sayilar);//sayilar dizisini küçükten büyüğe sıralıyor.
                                    //dizideki sayıları ilgili indislerle gösterilecek yerlerde göstermesini sağlıyor.
                txtSayi1.Text = sayilar[0].ToString();
                txtSayi2.Text = sayilar[1].ToString();
                txtSayi3.Text = sayilar[2].ToString();
                txtSayi4.Text = sayilar[3].ToString();
                txtSayi5.Text = sayilar[4].ToString();
                txtSayi6.Text = sayilar[5].ToString();


                int hafta = GetWeekNumber(DateTime.Now);

           
            SqlCommand komut = new SqlCommand("insert into Sonuclar(Sonuc1,Sonuc2,Sonuc3,Sonuc4,Sonuc5,Sonuc6,Hafta,DonemID) values (@s1,@s2,@s3,@s4,@s5,@s6,@t,@d)", baglanti);
                komut.Parameters.AddWithValue("@s1", txtSayi1.Text);
                komut.Parameters.AddWithValue("@s2", txtSayi2.Text);
                komut.Parameters.AddWithValue("@s3", txtSayi3.Text);
                komut.Parameters.AddWithValue("@s4", txtSayi4.Text);
                komut.Parameters.AddWithValue("@s5", txtSayi5.Text);
                komut.Parameters.AddWithValue("@s6", txtSayi6.Text);
                komut.Parameters.AddWithValue("@t", hafta.ToString());
                komut.Parameters.AddWithValue("@d", donem.DonemID);      
            
                komut.ExecuteNonQuery();           
                       
                MessageBox.Show("Çekiliş Oluşturuldu.");
            tiklanmaSayisi++;
            baglanti.Close();            
            }

        private void btnMenuyeDon_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();            
            menu.Show();
            this.Hide();
        }
    }
  }
