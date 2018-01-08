namespace BankaOtomasyonu
{
    partial class FormMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteri));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCekMiktar = new System.Windows.Forms.TextBox();
            this.txtCekHesapNo = new System.Windows.Forms.TextBox();
            this.btnCek = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalanLimit = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYatirMiktar = new System.Windows.Forms.TextBox();
            this.txtYatirHesapNo = new System.Windows.Forms.TextBox();
            this.btnYatir = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHavaleMiktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHavaleYap = new DevExpress.XtraEditors.SimpleButton();
            this.txtHavaleKaynak = new System.Windows.Forms.TextBox();
            this.txtHavaleHedef = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.timePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.timePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.gridHesapOzetiListele = new System.Windows.Forms.DataGridView();
            this.btnHesapOzeti = new DevExpress.XtraEditors.SimpleButton();
            this.txtHesapOzetiNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnHesapListele = new DevExpress.XtraEditors.SimpleButton();
            this.gridHesapListele = new System.Windows.Forms.DataGridView();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapOzetiListele)).BeginInit();
            this.tabNavigationPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapListele)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5});
            this.tabPane1.RegularSize = new System.Drawing.Size(935, 580);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(935, 580);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Para Çekme";
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Controls.Add(this.lblKalanLimit);
            this.tabNavigationPage1.Controls.Add(this.simpleButton3);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.ImageOptions.ImageIndex = 1;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(909, 483);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCekMiktar);
            this.groupBox1.Controls.Add(this.txtCekHesapNo);
            this.groupBox1.Controls.Add(this.btnCek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 210);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // txtCekMiktar
            // 
            this.txtCekMiktar.Location = new System.Drawing.Point(203, 78);
            this.txtCekMiktar.Name = "txtCekMiktar";
            this.txtCekMiktar.Size = new System.Drawing.Size(172, 26);
            this.txtCekMiktar.TabIndex = 28;
            this.txtCekMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCekMiktar_KeyPress);
            // 
            // txtCekHesapNo
            // 
            this.txtCekHesapNo.Location = new System.Drawing.Point(203, 30);
            this.txtCekHesapNo.Name = "txtCekHesapNo";
            this.txtCekHesapNo.Size = new System.Drawing.Size(172, 26);
            this.txtCekHesapNo.TabIndex = 27;
            this.txtCekHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCekHesapNo_KeyPress);
            // 
            // btnCek
            // 
            this.btnCek.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCek.ImageOptions.Image")));
            this.btnCek.Location = new System.Drawing.Point(268, 127);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(107, 56);
            this.btnCek.TabIndex = 26;
            this.btnCek.Text = "Çek";
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Miktar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hesap Numarası:";
            // 
            // lblKalanLimit
            // 
            this.lblKalanLimit.AutoSize = true;
            this.lblKalanLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanLimit.Location = new System.Drawing.Point(260, 123);
            this.lblKalanLimit.Name = "lblKalanLimit";
            this.lblKalanLimit.Size = new System.Drawing.Size(296, 22);
            this.lblKalanLimit.TabIndex = 29;
            this.lblKalanLimit.Text = "Günlük para çekme limiti 750 TL\'dir.";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(3, 4);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(50, 41);
            this.simpleButton3.TabIndex = 23;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Para Yatırma";
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.simpleButton1);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.ImageOptions.ImageIndex = 2;
            this.tabNavigationPage2.ImageOptions.ImageUri.Uri = "AddItem";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(909, 483);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYatirMiktar);
            this.groupBox2.Controls.Add(this.txtYatirHesapNo);
            this.groupBox2.Controls.Add(this.btnYatir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(198, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 210);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgisi";
            // 
            // txtYatirMiktar
            // 
            this.txtYatirMiktar.Location = new System.Drawing.Point(203, 78);
            this.txtYatirMiktar.Name = "txtYatirMiktar";
            this.txtYatirMiktar.Size = new System.Drawing.Size(172, 26);
            this.txtYatirMiktar.TabIndex = 28;
            this.txtYatirMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYatirMiktar_KeyPress);
            // 
            // txtYatirHesapNo
            // 
            this.txtYatirHesapNo.Location = new System.Drawing.Point(203, 30);
            this.txtYatirHesapNo.Name = "txtYatirHesapNo";
            this.txtYatirHesapNo.Size = new System.Drawing.Size(172, 26);
            this.txtYatirHesapNo.TabIndex = 27;
            this.txtYatirHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYatirHesapNo_KeyPress);
            // 
            // btnYatir
            // 
            this.btnYatir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYatir.ImageOptions.Image")));
            this.btnYatir.Location = new System.Drawing.Point(268, 127);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(107, 56);
            this.btnYatir.TabIndex = 26;
            this.btnYatir.Text = "Yatır";
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hesap Numarası:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 4);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(50, 41);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Hesaba Havale";
            this.tabNavigationPage3.Controls.Add(this.groupBox3);
            this.tabNavigationPage3.Controls.Add(this.simpleButton2);
            this.tabNavigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.ImageOptions.Image")));
            this.tabNavigationPage3.ImageOptions.ImageIndex = 2;
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(909, 483);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHavaleMiktar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnHavaleYap);
            this.groupBox3.Controls.Add(this.txtHavaleKaynak);
            this.groupBox3.Controls.Add(this.txtHavaleHedef);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(102, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 231);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesap Bilgisi";
            // 
            // txtHavaleMiktar
            // 
            this.txtHavaleMiktar.Location = new System.Drawing.Point(342, 126);
            this.txtHavaleMiktar.Name = "txtHavaleMiktar";
            this.txtHavaleMiktar.Size = new System.Drawing.Size(183, 26);
            this.txtHavaleMiktar.TabIndex = 29;
            this.txtHavaleMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHavaleMiktar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Miktar:";
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHavaleYap.ImageOptions.Image")));
            this.btnHavaleYap.Location = new System.Drawing.Point(389, 177);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(116, 48);
            this.btnHavaleYap.TabIndex = 27;
            this.btnHavaleYap.Text = "Gönder";
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // txtHavaleKaynak
            // 
            this.txtHavaleKaynak.Location = new System.Drawing.Point(342, 85);
            this.txtHavaleKaynak.Name = "txtHavaleKaynak";
            this.txtHavaleKaynak.Size = new System.Drawing.Size(183, 26);
            this.txtHavaleKaynak.TabIndex = 26;
            // 
            // txtHavaleHedef
            // 
            this.txtHavaleHedef.Location = new System.Drawing.Point(342, 40);
            this.txtHavaleHedef.Name = "txtHavaleHedef";
            this.txtHavaleHedef.Size = new System.Drawing.Size(183, 26);
            this.txtHavaleHedef.TabIndex = 25;
            this.txtHavaleHedef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kaynak Hesap Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Havale Yapılacak Hesap Numarası:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(3, 4);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 41);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Hesap Özeti";
            this.tabNavigationPage4.Controls.Add(this.timePickerBitis);
            this.tabNavigationPage4.Controls.Add(this.timePickerBaslangic);
            this.tabNavigationPage4.Controls.Add(this.gridHesapOzetiListele);
            this.tabNavigationPage4.Controls.Add(this.btnHesapOzeti);
            this.tabNavigationPage4.Controls.Add(this.txtHesapOzetiNo);
            this.tabNavigationPage4.Controls.Add(this.label7);
            this.tabNavigationPage4.Controls.Add(this.simpleButton4);
            this.tabNavigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage4.ImageOptions.Image")));
            this.tabNavigationPage4.ImageOptions.ImageIndex = 4;
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(909, 483);
            // 
            // timePickerBitis
            // 
            this.timePickerBitis.Location = new System.Drawing.Point(514, 48);
            this.timePickerBitis.Name = "timePickerBitis";
            this.timePickerBitis.Size = new System.Drawing.Size(226, 26);
            this.timePickerBitis.TabIndex = 28;
            // 
            // timePickerBaslangic
            // 
            this.timePickerBaslangic.Location = new System.Drawing.Point(514, 10);
            this.timePickerBaslangic.Name = "timePickerBaslangic";
            this.timePickerBaslangic.Size = new System.Drawing.Size(226, 26);
            this.timePickerBaslangic.TabIndex = 27;
            // 
            // gridHesapOzetiListele
            // 
            this.gridHesapOzetiListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHesapOzetiListele.Location = new System.Drawing.Point(3, 80);
            this.gridHesapOzetiListele.Name = "gridHesapOzetiListele";
            this.gridHesapOzetiListele.RowTemplate.Height = 28;
            this.gridHesapOzetiListele.Size = new System.Drawing.Size(903, 416);
            this.gridHesapOzetiListele.TabIndex = 26;
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapOzeti.ImageOptions.Image")));
            this.btnHesapOzeti.Location = new System.Drawing.Point(758, 13);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(129, 45);
            this.btnHesapOzeti.TabIndex = 25;
            this.btnHesapOzeti.Text = "Listele";
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // txtHesapOzetiNo
            // 
            this.txtHesapOzetiNo.Location = new System.Drawing.Point(249, 24);
            this.txtHesapOzetiNo.Name = "txtHesapOzetiNo";
            this.txtHesapOzetiNo.Size = new System.Drawing.Size(197, 26);
            this.txtHesapOzetiNo.TabIndex = 24;
            this.txtHesapOzetiNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapOzetiNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(72, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hesap Numarası:";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(3, 4);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(50, 41);
            this.simpleButton4.TabIndex = 23;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Caption = "Hesaplarım";
            this.tabNavigationPage5.Controls.Add(this.btnHesapListele);
            this.tabNavigationPage5.Controls.Add(this.gridHesapListele);
            this.tabNavigationPage5.Controls.Add(this.simpleButton9);
            this.tabNavigationPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage5.ImageOptions.Image")));
            this.tabNavigationPage5.ImageOptions.ImageIndex = 5;
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Size = new System.Drawing.Size(909, 499);
            // 
            // btnHesapListele
            // 
            this.btnHesapListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapListele.ImageOptions.Image")));
            this.btnHesapListele.Location = new System.Drawing.Point(59, 4);
            this.btnHesapListele.Name = "btnHesapListele";
            this.btnHesapListele.Size = new System.Drawing.Size(168, 36);
            this.btnHesapListele.TabIndex = 26;
            this.btnHesapListele.Text = "Listele";
            this.btnHesapListele.Click += new System.EventHandler(this.btnHesapListele_Click);
            // 
            // gridHesapListele
            // 
            this.gridHesapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHesapListele.Location = new System.Drawing.Point(0, 52);
            this.gridHesapListele.Name = "gridHesapListele";
            this.gridHesapListele.RowTemplate.Height = 28;
            this.gridHesapListele.Size = new System.Drawing.Size(906, 444);
            this.gridHesapListele.TabIndex = 25;
            // 
            // simpleButton9
            // 
            this.simpleButton9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(3, 4);
            this.simpleButton9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(50, 41);
            this.simpleButton9.TabIndex = 24;
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // FormMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 580);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMusteri";
            this.Text = "FormMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapOzetiListele)).EndInit();
            this.tabNavigationPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCekMiktar;
        private System.Windows.Forms.TextBox txtCekHesapNo;
        private DevExpress.XtraEditors.SimpleButton btnCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalanLimit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYatirMiktar;
        private System.Windows.Forms.TextBox txtYatirHesapNo;
        private DevExpress.XtraEditors.SimpleButton btnYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnHavaleYap;
        private System.Windows.Forms.TextBox txtHavaleKaynak;
        private System.Windows.Forms.TextBox txtHavaleHedef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnHesapOzeti;
        private System.Windows.Forms.TextBox txtHesapOzetiNo;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnHesapListele;
        private System.Windows.Forms.DataGridView gridHesapListele;
        private System.Windows.Forms.DataGridView gridHesapOzetiListele;
        private System.Windows.Forms.TextBox txtHavaleMiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker timePickerBitis;
        private System.Windows.Forms.DateTimePicker timePickerBaslangic;
    }
}