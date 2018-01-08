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
    partial class FormYonetici : Form
    {
        public FormYonetici(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
            this.gridPersonelListele.DataSource = banka.personeller;

        }

        Banka banka;
                       
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

            string Ad = txtPersonelAd.Text; //Personel Bilgilerini textBox'dan okuyup yeni nesneye ekliyoruz.
            string Soyad = txtPersonelSoyad.Text;
            string ID = txtPersonelID.Text;
            string Sifre = txtPersonelSifre.Text;

            txtPersonelAd.Clear(); //Personel eklendikten sonra textBoxları temizliyoruz.
            txtPersonelSoyad.Clear();
            txtPersonelID.Clear();
            txtPersonelSifre.Clear();

            banka.PersonelEkle(Ad,Soyad,ID,Sifre); //Personel bilgilerini Banka sınıfındaki PersonelEkle metoduna gönderiyoruz.        

            string rapor = ID+" kullanıcı adına sahip kişi bankaya personel olarak eklendi.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);

            this.gridPersonelListele.DataSource = banka.personeller; //gridView öğesine personeller listesini yazdırıyoruz.

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.gridPersonelListele.DataSource = banka.personeller;
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
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

        private void simpleButton4_Click(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e) //Personel Sil Butonu
        {
            string kullaniciAdi = txtIDSil.Text;
            txtIDSil.Clear();

            banka.PersonelSil(kullaniciAdi);

            this.gridPersonelListele.DataSource = null;
            this.gridPersonelListele.Rows.Clear();
            this.gridPersonelListele.DataSource = banka.personeller;

            string rapor = kullaniciAdi+" kullanici adına sahip banka personeli silindi.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);


        }

        private void txtPersonelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void btnBankaIslemListele_Click(object sender, EventArgs e)
        {
            gridBankaIslemListele.DataSource = banka.BankaRaporListesi;
            lblBankaToplamPara.Text = "Banka toplam para:" + banka.toplamPara +" TL";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
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
    }
}

