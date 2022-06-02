# HastaneSistemi
Hastane Bilgi Sistemi
Hastane Bilgi Sistemi

Basit bir ara yüze sahip Hastane bilgi sistemi uygulaması. SQL verit abani bağlantısı kullanılarak veriler hbs_db adli veri tabanında tutulmaktadır. Uygulama SQL ortamında kayıt listeleme, kayıt ekleme, kayıt silme ve kayıt güncelleme işlemi yapabilmektedir. İlk giriş ekranında Hasta, Kayıt kabul ve doktor girişleri bulunuyor. Hasta, kayıt kabul ve doktor için yeni hesap oluşturma ekranları bulunuyor. 
Hasta Ekranı: Hasta TC no ve şifresi ile giriş yapıp ilgili bölüm ve doktordan tarih ve saat seçerek randevu alabiliyor.
Hasta Kayıt Kabul ekranı: ilgili operatör TC ve şifresi ile giriş yapıp hasta TC no hasta kaydındı görüntüleyebilir, güncelleme yapabilir ve randevuları görüntüleyebilir.
Doktor ekranı: Doktor TC no ve şifresi ile giriş yaptıktan sonra hasta TC no ile hasta bilgilerini görüntüleyebilir ve notlar bölümüne gerekli teşhisi yazıp kaydedebilir.
 
  <b>VERİTABANI DİAGRAM </b>
 ![image](https://user-images.githubusercontent.com/41690116/171703113-ec3f8a88-6e0c-49fa-99cf-946d7cab7425.png)


ConnectionString : SqlLayer.cs  connectionString değeri değiştirilerek bağlantı sağlanabilir.
 
![image](https://user-images.githubusercontent.com/41690116/171703150-f9a80de3-2d97-4618-8191-86d7b315542e.png)







SENARYO
HASTA GİRİŞİ VE RANDEVU:
 ![image](https://user-images.githubusercontent.com/41690116/171703179-0b5f62dc-e99e-469d-801a-0990f41c25ea.png)

Hasta TC No: 12345678909 Şifre: 1234
Tarih seçimi: 23 Mayıs 2022
Saat seçimi: 9:30
Bölüm: Aile Hekimi
Doktor : Ali Sarı
Randevu Ekle
 ![image](https://user-images.githubusercontent.com/41690116/171703224-c149cf37-2970-4a9d-9705-c6a954e040df.png)


KAYIT KABUL EKRANI:
Kayıt kabul TC No: 11111111111 Şifre : 1111
 ![image](https://user-images.githubusercontent.com/41690116/171703262-4700ce7b-6801-430b-b10b-1b837f21ddd3.png)

Hasta TC no sorgula : 12345678909
 
![image](https://user-images.githubusercontent.com/41690116/171703290-184baa30-1560-4fde-9a77-36eedf8c3d58.png)









DOKTOR EKRANI:
Doktor TC no: 33333333333 Şifre: 3333 
![image](https://user-images.githubusercontent.com/41690116/171703324-309f9bdf-9acd-43e2-a4a1-8fa0b22f3b22.png)

Hasta TC No Sorgula : 12345678909
 ![image](https://user-images.githubusercontent.com/41690116/171703347-a18c65dc-e84c-4b7e-85c5-e3fd1b6af328.png)

Dr. Notlar giriş yapıldı ve kayıt güncellendi.
