using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace SayisalLoto4
{
    class Kullanıcı_Formu
    {

        public static User user;
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JSQ73E8\\SQLSERVER2017EXP;Initial Catalog=SayisalLoto4;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;

        public SqlDataReader kullanıcı(TextBox TC_No, TextBox Sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select KisiID,TC_No,Ad,Soyad from Kisiler where TC_No=@p1";
            komut.Parameters.AddWithValue("@p1", TC_No.Text);
            read = komut.ExecuteReader();

            string kimlikno = TC_No.Text;
            kimlikno = kimlikno.Trim();
            if (read.Read() == true)
            {
                int KisiID = read.GetInt32(0);
                read.Close();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select KisiID,TC_No,Ad,Soyad from Kisiler where Sifre=@p2 AND KisiID=@p3";
                komut.Parameters.AddWithValue("@p2", Sifre.Text);
                komut.Parameters.AddWithValue("@p3", KisiID);
                read = komut.ExecuteReader();

                if (read.Read() == true)
                {
                    MessageBox.Show("Giriş Başarılı...");
                    user = new User(KisiID, read.GetString(1), read.GetString(2), read.GetString(3));
                    frmMenu menu = new frmMenu();
                    menu.Show();                    
                    read.Close();
                }
                else
                {
                    MessageBox.Show("Şifreniz yanlış");
                    Sifre.Focus();
                    
                }
            }
            else
            {
                MessageBox.Show("tc no yanlış");
                TC_No.Focus();
            }

            baglanti.Close();
            return read;
        }
        public void yenikullanıcı(TextBox TC_No, TextBox Ad, TextBox Soyad, TextBox Sifre, TextBox SifreTekrar, DateTimePicker DogumTarihi, ComboBox İlceID, ComboBox CinsiyetID)
        {
            bool durum;
            void mukerrer()//Geriye değer döndüren bir sınıf
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select KisiID,TC_No,Sifre,Ad from Kisiler where TC_No=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", TC_No.Text);//kisiler tablosundan tcno içindeki değer
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    durum = false;
                }
                else { durum = true; }
                baglanti.Close();
            }
            if (Ad.Text == "" || Soyad.Text == "" || Sifre.Text == "" || SifreTekrar.Text == "" || DogumTarihi == null || İlceID.SelectedItem == null || CinsiyetID.SelectedItem == null)
            {

                MessageBox.Show("Bütün alanları doldurmalısınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (Sifre.Text == SifreTekrar.Text)
                {
                    if (Sifre.TextLength < 6)
                    {
                        MessageBox.Show("Şifreniz en az 6 haneli olmalıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmOyna Oyna = new frmOyna();
                        string kimlikno = TC_No.Text;
                        kimlikno = kimlikno.Trim();
                        if (kimlikno.Length != 11)
                        {
                            baglanti.Open();
                            MessageBox.Show("TC Kimlik numaranız 11 haneli olmalıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            baglanti.Close();
                        }
                        else
                        {
                            int[] sayilar = new int[11];
                            for (int i = 0; i < TC_No.Text.Length; i++)
                            {
                                sayilar[i] = Int32.Parse(kimlikno[i].ToString());//kimlikno yu sayilar adında bir diziye atadık.
                            }

                            int toplam = 0;
                            int tek = 0;
                            int cift = 0;
                            tek = sayilar[0] + sayilar[2] + sayilar[4] + sayilar[6] + sayilar[8];
                            cift = sayilar[1] + sayilar[3] + sayilar[5] + sayilar[7];
                            sayilar[9] = (tek * 7 - cift) % 10;

                            for (int i = 0; i < kimlikno.Length - 1; i++)
                            {
                                toplam += sayilar[i];
                            }
                            if ((toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0))//toplam değişkenini string türünde kabul edip 1. indexini alır ve sayilar dizsinin son kısmına atar.ve sayılar kısmının sonu 2 ye tam bölünüyorsa
                            {
                                if ((sayilar[0]) != 0)
                                {
                                    mukerrer();
                                    if (durum == true)
                                    {
                                        baglanti.Open();
                                        SqlCommand komut = new SqlCommand("insert into Kisiler(TC_No,Ad,Soyad,Sifre,DogumTarihi,IlceID,CinsiyetID) values (@TC,@Adi,@Soyadi,@Sifresi,@DogumTarihi,@Ilcesi,@Cinsiyeti)", baglanti);
                                        komut.Parameters.AddWithValue("@TC", TC_No.Text);
                                        komut.Parameters.AddWithValue("@Adi", Ad.Text);
                                        komut.Parameters.AddWithValue("@Soyadi", Soyad.Text);
                                        komut.Parameters.AddWithValue("@Sifresi", Sifre.Text);
                                        komut.Parameters.AddWithValue("@DogumTarihi", DogumTarihi.Value);
                                        komut.Parameters.AddWithValue("@Ilcesi", (İlceID.SelectedItem as dynamic).Value);
                                        komut.Parameters.AddWithValue("@Cinsiyeti", CinsiyetID.SelectedIndex + 1);
                                        komut.ExecuteNonQuery();


                                        baglanti.Close();
                                        MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bu tc kimlik numaralı kayıt zaten mevcut.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("TC Kimlik numarasının ilk hanesi 0 olamaz.!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Böyle bir TC Kimlik numarası oluşturulamaz.!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor...");
                }
            }
        }
                
    }

}





