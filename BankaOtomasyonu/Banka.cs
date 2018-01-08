using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
     class Banka:IBankaOzellikleri, IRaporOzellikleri
    {
        public List<Personel> personeller = new List<Personel>();
        public List<BireyselMusteri> BireyselMusteriler = new List<BireyselMusteri>();
        public List<TicariMusteri> TicariMusteriler = new List<TicariMusteri>();
        public List<Rapor> BankaRaporListesi = new List<Rapor>();
        public decimal toplamPara { get; set; }

        Personel p;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        Rapor r;

        public void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih)
        {
            if(musteriTipi == true)
            {
                bireyselMusteri = new BireyselMusteri();
               
                this.bireyselMusteri.Ad = ad;
                this.bireyselMusteri.Soyad = soyad;
                this.bireyselMusteri.ID = ID;
                this.bireyselMusteri.Sifre = sifre;
                this.bireyselMusteri.Tarih = tarih;
                this.bireyselMusteri.musteriTipi = "Bireysel";

                BireyselMusteriler.Add(bireyselMusteri);
                MessageBox.Show("Bireysel Müşteri Başarıyla Eklendi.");
            }
            else
            {
                ticariMusteri = new TicariMusteri();

                ticariMusteri.Ad = ad;
                ticariMusteri.Soyad = soyad;
                ticariMusteri.ID = ID;
                ticariMusteri.Sifre = sifre;
                ticariMusteri.Tarih = tarih;
                ticariMusteri.musteriTipi = "Ticari";

                TicariMusteriler.Add(ticariMusteri);
                MessageBox.Show("Ticari Müşteri Başarıyla Eklendi.");
            }
            
            
        }
        public void PersonelEkle(string ad, string soyad, string ID, string sifre)
        {
            p = new Personel();

            this.p.Ad = ad;
            this.p.Soyad = soyad;
            this.p.ID = ID;
            this.p.Sifre = sifre;

            personeller.Add(p);
            MessageBox.Show("Personel Başarıyla Eklendi.");
        }
        public void PersonelSil(string kullaniciAdi)
        {
            foreach (Personel p in personeller.ToList())
            {
                if (kullaniciAdi == p.ID)
                {
                    personeller.Remove(p);
                    MessageBox.Show("Personel Silindi.");
                }
            }
        }

        public void RaporEkle(string rapor, DateTime tarih)
        {
            r = new Rapor();
            r.rapor = rapor;
            r.tarih = tarih;
            BankaRaporListesi.Add(r);
        }
    }
}
