namespace BankaOtomasyonu
{
    partial class FormPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMüsteriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.radioBireysel = new System.Windows.Forms.RadioButton();
            this.radioTicari = new System.Windows.Forms.RadioButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeMusteri = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEkBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapAc = new DevExpress.XtraEditors.SimpleButton();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHesapSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticariMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariMusteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(958, 595);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(958, 595);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Müşteri Ekle";
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Controls.Add(this.simpleButton1);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.ImageOptions.ImageIndex = 1;
            this.tabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Size = new System.Drawing.Size(932, 514);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnMüsteriKaydet);
            this.groupBox1.Controls.Add(this.radioBireysel);
            this.groupBox1.Controls.Add(this.radioTicari);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimeMusteri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(170, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(573, 422);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(46, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Müşteri Tipi:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(201, 195);
            this.txtNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(224, 26);
            this.txtNo.TabIndex = 36;
            this.txtNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Müşteri Numarası:";
            // 
            // btnMüsteriKaydet
            // 
            this.btnMüsteriKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMüsteriKaydet.ImageOptions.Image")));
            this.btnMüsteriKaydet.Location = new System.Drawing.Point(302, 356);
            this.btnMüsteriKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMüsteriKaydet.Name = "btnMüsteriKaydet";
            this.btnMüsteriKaydet.Size = new System.Drawing.Size(125, 59);
            this.btnMüsteriKaydet.TabIndex = 34;
            this.btnMüsteriKaydet.Text = "Kaydet";
            this.btnMüsteriKaydet.Click += new System.EventHandler(this.btnMüsteriKaydet_Click);
            // 
            // radioBireysel
            // 
            this.radioBireysel.AutoSize = true;
            this.radioBireysel.Location = new System.Drawing.Point(201, 299);
            this.radioBireysel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBireysel.Name = "radioBireysel";
            this.radioBireysel.Size = new System.Drawing.Size(89, 24);
            this.radioBireysel.TabIndex = 33;
            this.radioBireysel.TabStop = true;
            this.radioBireysel.Text = "Bireysel";
            this.radioBireysel.UseVisualStyleBackColor = true;
            // 
            // radioTicari
            // 
            this.radioTicari.AutoSize = true;
            this.radioTicari.Location = new System.Drawing.Point(355, 299);
            this.radioTicari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioTicari.Name = "radioTicari";
            this.radioTicari.Size = new System.Drawing.Size(71, 24);
            this.radioTicari.TabIndex = 32;
            this.radioTicari.TabStop = true;
            this.radioTicari.Text = "Ticari";
            this.radioTicari.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(201, 236);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(224, 26);
            this.txtSifre.TabIndex = 30;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(201, 95);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(224, 26);
            this.txtSoyad.TabIndex = 28;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(201, 42);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(224, 26);
            this.txtAd.TabIndex = 27;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tarih:";
            // 
            // dateTimeMusteri
            // 
            this.dateTimeMusteri.Location = new System.Drawing.Point(201, 147);
            this.dateTimeMusteri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeMusteri.Name = "dateTimeMusteri";
            this.dateTimeMusteri.Size = new System.Drawing.Size(224, 26);
            this.dateTimeMusteri.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Şifre:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1, 0);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(50, 41);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Hesap Aç";
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.simpleButton2);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.ImageOptions.ImageIndex = 3;
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Size = new System.Drawing.Size(932, 514);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEkBakiye);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnHesapAc);
            this.groupBox2.Controls.Add(this.txtMusteriNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(215, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(456, 231);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgisi";
            // 
            // txtEkBakiye
            // 
            this.txtEkBakiye.Location = new System.Drawing.Point(223, 98);
            this.txtEkBakiye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEkBakiye.Name = "txtEkBakiye";
            this.txtEkBakiye.Size = new System.Drawing.Size(155, 26);
            this.txtEkBakiye.TabIndex = 27;
            this.txtEkBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEkBakiye_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ek Bakiye Miktarı:";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapAc.ImageOptions.Image")));
            this.btnHesapAc.Location = new System.Drawing.Point(243, 147);
            this.btnHesapAc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(135, 58);
            this.btnHesapAc.TabIndex = 25;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(223, 45);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(155, 26);
            this.txtMusteriNo.TabIndex = 24;
            this.txtMusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Müşteri Numarası:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(3, 0);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 41);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Hesap Sil";
            this.tabNavigationPage3.Controls.Add(this.label9);
            this.tabNavigationPage3.Controls.Add(this.groupBox3);
            this.tabNavigationPage3.Controls.Add(this.simpleButton3);
            this.tabNavigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.ImageOptions.Image")));
            this.tabNavigationPage3.ImageOptions.ImageIndex = 3;
            this.tabNavigationPage3.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Size = new System.Drawing.Size(932, 514);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(407, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Herhangi bir hesabın silinebilmesi için bakiyesi 0 olmalıdır.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHesapSil);
            this.groupBox3.Controls.Add(this.txtHesapNo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(238, 142);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(456, 231);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Bilgisi";
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapSil.ImageOptions.Image")));
            this.btnHesapSil.Location = new System.Drawing.Point(243, 147);
            this.btnHesapSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(135, 58);
            this.btnHesapSil.TabIndex = 25;
            this.btnHesapSil.Text = "Sil";
            this.btnHesapSil.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(223, 75);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(155, 26);
            this.txtHesapNo.TabIndex = 24;
            this.txtHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapNo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(44, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hesap Numarası:";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(3, 4);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(50, 41);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // raporBindingSource
            // 
            this.raporBindingSource.DataSource = typeof(BankaOtomasyonu.Rapor);
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataSource = typeof(BankaOtomasyonu.Musteri);
            // 
            // ticariMusteriBindingSource
            // 
            this.ticariMusteriBindingSource.DataSource = typeof(BankaOtomasyonu.TicariMusteri);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 595);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariMusteriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnMüsteriKaydet;
        private System.Windows.Forms.RadioButton radioBireysel;
        private System.Windows.Forms.RadioButton radioTicari;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnHesapAc;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource ticariMusteriBindingSource;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private System.Windows.Forms.TextBox txtEkBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnHesapSil;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource raporBindingSource;
    }
}