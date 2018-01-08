using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }
        public FormPersonel(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        Banka banka;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FormAna f1 = Application.OpenForms["FormAna"] as FormAna;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris f3 = new FormGiris(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormAna f1 = Application.OpenForms["FormAna"] as FormAna;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris f3 = new FormGiris(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FormAna f1 = Application.OpenForms["FormAna"] as FormAna;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris f3 = new FormGiris(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void btnMüsteriKaydet_Click(object sender, EventArgs e)
        {
            if (radioBireysel.Checked==true) { //Bireysel Müşteri ekleniyorsa

                bool musteriTipi = true;
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string kullaniciAdi = txtNo.Text;
                string sifre = txtSifre.Text;
                DateTime tarih = dateTimeMusteri.Value;

                banka.MusteriEkle(musteriTipi, ad, soyad, kullaniciAdi, sifre, tarih);

                string rapor = kullaniciAdi + " kullanıcı adına sahip " + ad + " " + soyad + " kişisi Bireysel Müşteri olarak bankaya eklendi.";
                banka.RaporEkle(rapor, tarih);
            }
            else if (radioTicari.Checked == true) //Ticari Müşteri Ekleniyorsa
            {
                bool musteriTipi = false;
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string kullaniciAdi = txtNo.Text;
                string sifre = txtSifre.Text;
                DateTime tarih = dateTimeMusteri.Value;

                banka.MusteriEkle(musteriTipi, ad, soyad, kullaniciAdi, sifre, tarih);

                string rapor = kullaniciAdi + " kullanıcı adına sahip "+ad + " " + soyad + " kişisi Ticari Müşteri olarak bankaya eklendi.";
                banka.RaporEkle(rapor, tarih);
            }
            else //Müşteri tipi girilmemişse
            {
                MessageBox.Show("Lütfen müşteri tipini seçiniz.");
            }
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            string musteriNo = txtMusteriNo.Text;
            int ekBakiye = Convert.ToInt32(txtEkBakiye.Text);

            foreach (BireyselMusteri m in banka.BireyselMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {
                    m.HesapAc(ekBakiye);

                    string rapor = m.ID+" kullanıcı adına sahip Bireysel Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)//Müşteri ticari müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {
                    m.HesapAc(ekBakiye);

                    string rapor = m.ID + " kullanıcı adına sahip Ticari Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtHesapNo.Text);

            foreach (BireyselMusteri m in banka.BireyselMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                foreach (Hesap h in m.hesaplar.ToList())//Her bir müşterinin hesaplar listesini tarayarak girilen hesap numarasına ait müşteriyi buluyoruz.
                {
                    if (hesapNo == h.No)
                    {
                        m.HesapSil(hesapNo);//Müşterinin HesapSil metodunu çalıştırıyoruz.

                        string rapor = m.ID + " kullanıcı adına sahip Bireysel Müşterinin "+hesapNo+" numaralı hesabı silindi.";
                        DateTime tarih = DateTime.Today;
                        banka.RaporEkle(rapor, tarih);
                    }
                }
                
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                foreach (Hesap h in m.hesaplar.ToList())
                {
                    if (hesapNo == h.No)
                    {
                        m.HesapSil(hesapNo);

                        string rapor = m.ID + " kullanıcı adına sahip Ticari Müşterinin " + hesapNo + " numaralı hesabı silindi.";
                        DateTime tarih = DateTime.Today;
                        banka.RaporEkle(rapor, tarih);
                    }
                }

            }


        }
        //TextBoxlara sadece harf veya rakam girilmesine izin verilmesi
        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEkBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
