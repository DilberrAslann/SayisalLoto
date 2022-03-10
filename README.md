# Sayısal Loto Projesi

## Kullanılan Teknolojiler

Projeyi Visual Studio geliştirme ortamında C# programlama dili ve MsSql veritabanı kullanarak geliştirdim.

## Proje Hakkında;
Uygulama ilk açıldığında üye giriş ve üye kayıt ekranı var. Kullanıcılar üye olup oyuna geçiş yaptıklarında 6 sayı tahmin edilmesi
isteniyor ve bu veriler veritabanında kaydoluyor. Tahmin edilen sayıların 1-50 arası ve birbirinden farklı olması gerekiyor. Her Cumartesi günü rastgele 6 sayı seçiliyor. Bu seçilen 6 sayı ile kullanıcıların tahmin etmiş olduğu 6 sayıdan kaçar tanesinin aynı olduğu bulunuyor ve bu bilgide veritabanına kaydediliyor. Çekiliş sonucu açıklanana kadar, kullanıcılar o hafta içerisinde yapılmış olan tahminleri görebilir. Çekilişler sadece Cumartesi günü olmaktadır ve Cumartesi hariç diğer günlerde tahminde bulunulabiliyor. Veritabanına kayıtlı olan "Admin" kişisi dışında kimsenin çekiliş yapma hakkı yoktur. Cumartesi günleri çekilişi "Admin" kişisi yapabilir. Ve çekiliş yapıldıktan sonra sayı tahmininde bulunan diğer kullanıcıların skorları tabloda gösterilir ve veitabanına kaydolur. Veriler veritanabına kaydolduğu için geçmiş haftaların skorlarını da listeyebiliriz.
### Üye Olma Kısıtları

Üye olma sayfasında
- tc no eğer 11 haneli olmazsa uyarı veriliyor.
- tc no algoritması sayesinde, uydurma tc noları kabul edilmiyor.
- Şifreler uyuşmadığı zaman uyarı veriliyor
- Eğer boş alan bırakılırsa, doldurulması için uyarı veriliyor.

### Admin yetkileri
 
- Cumartesi günü çekilişleri sadece Admin yapabilir.
- Admin her Cumartesi yalnızca bir kez çekiliş yapabilir.


### Projenin Ekran Görüntüleri;

**Kayıt Ol Ekranı**

<img height="400" src="https://r.resimlink.com/slfDLHJb.png" />

-------------------------------------------


**Giriş Ekranı**

<img height="400" src="https://r.resimlink.com/koVB.png" />

-------------------------------------------

**Anasayfa Ekranı**

<img height="400" src="https://r.resimlink.com/IP6BwnmV.png" />


-------------------------------------------


**Tahmin Oluşturma Ekranı**

<img height="400" src="https://r.resimlink.com/8az2nC.png" />

-------------------------------------------

**Çekiliş Oluşturma Ekranı**

<img height="400" src="https://r.resimlink.com/ZxWAp.png" />

-------------------------------------------

**Tahmin ve Sonuçları Gösteren Ekran**

<img height="400" src="https://r.resimlink.com/PS8Fqhu.png" />

-------------------------------------------

**Geçmiş Haftaların Tahmin ve Sonuçları Gösteren Ekran**

<img height="400" src="https://r.resimlink.com/jX9B.png" />

-------------------------------------------



