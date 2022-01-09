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
using System.Security.Cryptography.X509Certificates;

namespace SayisalLoto4
{
    public partial class frmSonuclariGör : Form
    {
        public frmSonuclariGör()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DILBERASLAN\\SQL2019;Initial Catalog=SayisalLoto4;Integrated Security=True");

        public int GetWeekNumber(DateTime dtPassed)//Bugünün tarihini yılın kaçıncı haftası olduğuna dönüştüren fonksiyon.
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void frmSonuclariGör_Load(object sender, EventArgs e)
        {
            SonuclariGor(); 
        }
        void SonuclariGor()
        {
            int hafta = GetWeekNumber(DateTime.Now);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Sonuc1,Sonuc2,Sonuc3,Sonuc4,Sonuc5,Sonuc6 from Sonuclar where Hafta like '%" + hafta + "%'", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            baglanti.Close();

            List<int> Sonuc = new List<int>();
            foreach (DataRow item in ds2.Tables[0].Rows)//Sonuclar sonuç listesine ekliyor.
            {
                Sonuc.Add(Convert.ToInt32(item["Sonuc1"]));
                Sonuc.Add(Convert.ToInt32(item["Sonuc2"]));
                Sonuc.Add(Convert.ToInt32(item["Sonuc3"]));
                Sonuc.Add(Convert.ToInt32(item["Sonuc4"]));
                Sonuc.Add(Convert.ToInt32(item["Sonuc5"]));
                Sonuc.Add(Convert.ToInt32(item["Sonuc6"]));
            }

            baglanti.Open();
            lblHafta.Text = Convert.ToString(hafta);
            SqlCommand komut = new SqlCommand("select t.KisiID, k.Ad,t.Tahmin1,t.Tahmin2,t.Tahmin3,t.Tahmin4,t.Tahmin5,t.Tahmin6,t.BulunanAdet from KisiTahmin t inner join Kisiler k on t.KisiID=k.KisiID where Hafta like '%" + hafta + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();


            foreach (DataRow item in ds.Tables[0].Rows)
            {
                int bulunan = 0;
                int kisiID = 0;
                List<int> Tahmin = new List<int>();//Tahminler Tahmin listesine ekleniyor
                Tahmin.Add(Convert.ToInt32(item["Tahmin1"]));
                Tahmin.Add(Convert.ToInt32(item["Tahmin2"]));
                Tahmin.Add(Convert.ToInt32(item["Tahmin3"]));
                Tahmin.Add(Convert.ToInt32(item["Tahmin4"]));
                Tahmin.Add(Convert.ToInt32(item["Tahmin5"]));
                Tahmin.Add(Convert.ToInt32(item["Tahmin6"]));

                for (int i = 0; i < Tahmin.Count; i++)
                {
                    if (Sonuc.Contains(Tahmin[i]))
                    {
                        bulunan = bulunan + 1;
                    }
                }
                item["BulunanAdet"] = bulunan;
                kisiID = Convert.ToInt32(item["KisiID"]);
                dataGridView1.DataSource = ds.Tables[0];

                baglanti.Open();
                //SqlCommand komut3 = new SqlCommand("güncelle", baglanti);
                //komut3.CommandType = CommandType.StoredProcedure;
                //komut3.Parameters.AddWithValue("@BulunanAdet", bulunan);
                //komut3.Parameters.AddWithValue("@KisiID", kisiID);
                //komut3.Parameters.AddWithValue("@hafta", hafta);
                SqlCommand komut3 = new SqlCommand("Update KisiTahmin set BulunanAdet = @BulunanAdet where KisiID=" + kisiID + " and Hafta like '%" + hafta + "%'", baglanti);
                komut3.Parameters.AddWithValue("@BulunanAdet", bulunan);
                komut3.Parameters.AddWithValue("@KisiID", kisiID);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        private void btnDigerSonuclar_Click(object sender, EventArgs e)
        {
            frmDigerSonuclar digerSonuclar = new frmDigerSonuclar();
            this.Hide();
            digerSonuclar.ShowDialog();
        }

        private void btnMenuyeDon_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
