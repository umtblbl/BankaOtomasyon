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
    partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();       
        }
        public FormGiris(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        Banka banka;
    
        private void simpleButton3_Click(object sender, EventArgs e) //Yönetici girişi tıklanma olayı
        {   
            FormAna f1 = Application.OpenForms["FormAna"] as FormAna;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            FormYonetici formYonetici = new FormYonetici(banka);
            formYonetici.TopLevel = false;
            panel1.Controls.Add(formYonetici);
            formYonetici.Show();
            formYonetici.Dock = DockStyle.Fill;
        }

        private void simpleButton2_Click(object sender, EventArgs e) //Personel Girişi tıklanma olayı
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            foreach (Personel p in banka.personeller)
            {
                if(kullaniciAdi == p.ID && sifre == p.Sifre)
                {
                    FormAna f1 = Application.OpenForms["FormAna"] as FormAna;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();

                    FormPersonel formPersonel = new FormPersonel(banka);
                    formPersonel.TopLevel = false;
                    panel1.Controls.Add(formPersonel);
                    formPersonel.Show();
                    formPersonel.Dock = DockStyle.Fill;
                    MessageBox.Show("Hoşgeldiniz. Sayın "+p.Ad+" "+p.Soyad);
                }
            }
            
        }

        private void btnMusteriGiris_Click(object sender, EventArgs e) //Müşteri Girişi tıklanma olayı
        {
            string musteriNo = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {   
                if(musteriNo == m.ID && sifre == m.Sifre)
                {
                    FormAna f1 = Application.OpenForms["FormAna"] as FormAna;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();
                    FormMusteri formMusteri = new FormMusteri(banka, m);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın "+m.Ad+" "+m.Soyad);
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    FormAna f1 = Application.OpenForms["FormAna"] as FormAna;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();
                    FormMusteri formMusteri = new FormMusteri(banka, m);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın " + m.Ad + " " + m.Soyad);
                }
            }

        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
