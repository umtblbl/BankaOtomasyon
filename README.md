# BankaOtomasyon
Nesneye Yönelik Programlama - Dönem Projesi (2017-2018)
---

### Bu proje için hazırladığım video eğitim serisine şu linkten ulaşabilirsiniz;

https://www.youtube.com/playlist?list=PLD5mxe_TPJBGP9c100rM0DNY6KtKkWgbp



                                - Kullanılan Araçlar ve Teknolojiler -

Microsoft Visual Studio: Yazılım geliştirme aracı (IDE) olarak Microsoft Visual Studio kullanılmıştır.

C# (.Net Framework): Yazılım geliştirme dili olarak C# kullanılmıştır.

DevExpress Components: Uygulama geliştirilirken görsellik ve işlevsellik sağlamak amacıyla DevExpress kütüphanesi araçlarından yararlanılmıştır.


                          - Kullanılan Sınıfların ve Arayüzlerin Açıklamaları -

Banka: İçerisinde personel, bireysel ve ticari müşteri listeleri bulunduran programda birçok sınıf için üst sınıf olan sınıftır.

Kisi: Programda müşteriler ve personeller için üst sınıf olan ve bu sınıfların ortak noktalarını belirleyen abstract bir sınıftır.

Personel: Programda banka personelini temsil eden sınıftır. Bankaya Personel eklemek için kullanılır. Kisi sınıfından türetilmiştir.

Musteri: Programda müşteriyi temsil eden sınıftır. Müşteri ve hesapları ile ilgili bütün bilgiler bu sınıf içerisinde bulunmaktadır. Kisi sınıfından türetilmiştir.

Rapor: Banka ve Hesaplar için hesap, işlem ve rapor özetlerinin listesi oluşturmak için kullandığımız sınıftır.

Hesap: Müşteri için yeni hesap oluşturmada kullanılan ve müşterinin hesaplarıyla ilgili bütün bilgileri barındıran sınıftır.

IBankaOzellikleri: Banka sınıfının yapacağı işlemleri, kullanacağı metodları barındıran ara yüz (interface) dir.

IMusteriOzellikleri: Musteri sınıfının yapacağı işlemleri, kullanacağı metodları barındıran ara yüz (interface) dir.

IRaporOzellikleri: Rapor sınıfını kullanan sınıfların rapor listeleri oluşturmak için kullanacağı metodları barındıran ara yüz (interface) dir.

BireyselMusteri: Programda Bireysel Müşterileri temsil eden sınıftır. Musteri sınıfından türetilmiştir.

TicariMusteri: Programda Ticari Müşterileri temsil eden sınıftır. Musteri sınıfından türetilmiştir.

## UML Diyagramı


![](https://i.hizliresim.com/Vgf4ig.png)
