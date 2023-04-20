
namespace KresOtomasyon
{
    partial class Frm_YeniOgrTemel
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
            this.OgrAd = new System.Windows.Forms.Label();
            this.OgrSoyad = new System.Windows.Forms.Label();
            this.OgrCinsiyet = new System.Windows.Forms.Label();
            this.OgrKayitTarih = new System.Windows.Forms.Label();
            this.OgrReferans = new System.Windows.Forms.Label();
            this.OgrNo = new System.Windows.Forms.Label();
            this.OgrSinif = new System.Windows.Forms.Label();
            this.OgrOgrenimSekli = new System.Windows.Forms.Label();
            this.OgrDurum = new System.Windows.Forms.Label();
            this.OgrResim = new System.Windows.Forms.Label();
            this.OgrServisGuzergah = new System.Windows.Forms.Label();
            this.txt_OgrAd = new System.Windows.Forms.TextBox();
            this.txt_OgrSoyad = new System.Windows.Forms.TextBox();
            this.comboBoxOgrCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.comboBoxOgrenim = new System.Windows.Forms.ComboBox();
            this.comboBoxOgrDurum = new System.Windows.Forms.ComboBox();
            this.comboBoxGuzergah = new System.Windows.Forms.ComboBox();
            this.txt_OgrNo = new System.Windows.Forms.TextBox();
            this.txt_OgrReferans = new System.Windows.Forms.TextBox();
            this.Baslik = new System.Windows.Forms.Label();
            this.checkBoxServis = new System.Windows.Forms.CheckBox();
            this.checkBoxSut = new System.Windows.Forms.CheckBox();
            this.checkBoxTanidik = new System.Windows.Forms.CheckBox();
            this.pictureBoxOgr = new System.Windows.Forms.PictureBox();
            this.btn_Ileri = new System.Windows.Forms.Button();
            this.OgrTemelNot = new System.Windows.Forms.Label();
            this.richTextBoxOgrTemNot = new System.Windows.Forms.RichTextBox();
            this.OgrIDBorc = new System.Windows.Forms.Label();
            this.MskKayitTarih = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OgrDetayID = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.Label();
            this.txt_Resim = new System.Windows.Forms.TextBox();
            this.btn_Resim = new System.Windows.Forms.Button();
            this.sinifadi = new System.Windows.Forms.Label();
            this.Guzergahad = new System.Windows.Forms.Label();
            this.OgrID = new System.Windows.Forms.Label();
            this.YeniOgrID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgr)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrAd
            // 
            this.OgrAd.AutoSize = true;
            this.OgrAd.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrAd.Location = new System.Drawing.Point(127, 123);
            this.OgrAd.Name = "OgrAd";
            this.OgrAd.Size = new System.Drawing.Size(34, 16);
            this.OgrAd.TabIndex = 0;
            this.OgrAd.Text = "Adı:";
            // 
            // OgrSoyad
            // 
            this.OgrSoyad.AutoSize = true;
            this.OgrSoyad.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSoyad.Location = new System.Drawing.Point(107, 159);
            this.OgrSoyad.Name = "OgrSoyad";
            this.OgrSoyad.Size = new System.Drawing.Size(54, 16);
            this.OgrSoyad.TabIndex = 1;
            this.OgrSoyad.Text = "Soyadı:";
            // 
            // OgrCinsiyet
            // 
            this.OgrCinsiyet.AutoSize = true;
            this.OgrCinsiyet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrCinsiyet.Location = new System.Drawing.Point(99, 199);
            this.OgrCinsiyet.Name = "OgrCinsiyet";
            this.OgrCinsiyet.Size = new System.Drawing.Size(62, 16);
            this.OgrCinsiyet.TabIndex = 5;
            this.OgrCinsiyet.Text = "Cinsiyet:";
            // 
            // OgrKayitTarih
            // 
            this.OgrKayitTarih.AutoSize = true;
            this.OgrKayitTarih.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrKayitTarih.Location = new System.Drawing.Point(76, 235);
            this.OgrKayitTarih.Name = "OgrKayitTarih";
            this.OgrKayitTarih.Size = new System.Drawing.Size(85, 16);
            this.OgrKayitTarih.TabIndex = 7;
            this.OgrKayitTarih.Text = "Kayıt Tarihi:";
            // 
            // OgrReferans
            // 
            this.OgrReferans.AutoSize = true;
            this.OgrReferans.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrReferans.Location = new System.Drawing.Point(91, 269);
            this.OgrReferans.Name = "OgrReferans";
            this.OgrReferans.Size = new System.Drawing.Size(70, 16);
            this.OgrReferans.TabIndex = 8;
            this.OgrReferans.Text = "Referansı:";
            // 
            // OgrNo
            // 
            this.OgrNo.AutoSize = true;
            this.OgrNo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrNo.Location = new System.Drawing.Point(38, 311);
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Size = new System.Drawing.Size(123, 16);
            this.OgrNo.TabIndex = 9;
            this.OgrNo.Text = "Öğrenci Numarası:";
            // 
            // OgrSinif
            // 
            this.OgrSinif.AutoSize = true;
            this.OgrSinif.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSinif.Location = new System.Drawing.Point(118, 352);
            this.OgrSinif.Name = "OgrSinif";
            this.OgrSinif.Size = new System.Drawing.Size(43, 16);
            this.OgrSinif.TabIndex = 10;
            this.OgrSinif.Text = "Sınıfı:";
            // 
            // OgrOgrenimSekli
            // 
            this.OgrOgrenimSekli.AutoSize = true;
            this.OgrOgrenimSekli.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrOgrenimSekli.Location = new System.Drawing.Point(64, 395);
            this.OgrOgrenimSekli.Name = "OgrOgrenimSekli";
            this.OgrOgrenimSekli.Size = new System.Drawing.Size(97, 16);
            this.OgrOgrenimSekli.TabIndex = 11;
            this.OgrOgrenimSekli.Text = "Öğrenim Şekli:";
            // 
            // OgrDurum
            // 
            this.OgrDurum.AutoSize = true;
            this.OgrDurum.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrDurum.Location = new System.Drawing.Point(42, 439);
            this.OgrDurum.Name = "OgrDurum";
            this.OgrDurum.Size = new System.Drawing.Size(119, 16);
            this.OgrDurum.TabIndex = 12;
            this.OgrDurum.Text = "Öğrenim Durumu:";
            // 
            // OgrResim
            // 
            this.OgrResim.AutoSize = true;
            this.OgrResim.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrResim.Location = new System.Drawing.Point(485, 119);
            this.OgrResim.Name = "OgrResim";
            this.OgrResim.Size = new System.Drawing.Size(101, 16);
            this.OgrResim.TabIndex = 13;
            this.OgrResim.Text = "Öğrenci Resmi:";
            // 
            // OgrServisGuzergah
            // 
            this.OgrServisGuzergah.AutoSize = true;
            this.OgrServisGuzergah.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrServisGuzergah.Location = new System.Drawing.Point(46, 487);
            this.OgrServisGuzergah.Name = "OgrServisGuzergah";
            this.OgrServisGuzergah.Size = new System.Drawing.Size(115, 16);
            this.OgrServisGuzergah.TabIndex = 14;
            this.OgrServisGuzergah.Text = "Servis Güzergahı:";
            // 
            // txt_OgrAd
            // 
            this.txt_OgrAd.Location = new System.Drawing.Point(195, 119);
            this.txt_OgrAd.Name = "txt_OgrAd";
            this.txt_OgrAd.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrAd.TabIndex = 15;
            // 
            // txt_OgrSoyad
            // 
            this.txt_OgrSoyad.Location = new System.Drawing.Point(195, 155);
            this.txt_OgrSoyad.Name = "txt_OgrSoyad";
            this.txt_OgrSoyad.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrSoyad.TabIndex = 16;
            // 
            // comboBoxOgrCinsiyet
            // 
            this.comboBoxOgrCinsiyet.FormattingEnabled = true;
            this.comboBoxOgrCinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.comboBoxOgrCinsiyet.Location = new System.Drawing.Point(195, 194);
            this.comboBoxOgrCinsiyet.Name = "comboBoxOgrCinsiyet";
            this.comboBoxOgrCinsiyet.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOgrCinsiyet.TabIndex = 19;
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(195, 347);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSinif.TabIndex = 21;
            // 
            // comboBoxOgrenim
            // 
            this.comboBoxOgrenim.FormattingEnabled = true;
            this.comboBoxOgrenim.Items.AddRange(new object[] {
            "Sabahçı",
            "Öğlenci",
            "Tam Gün"});
            this.comboBoxOgrenim.Location = new System.Drawing.Point(195, 390);
            this.comboBoxOgrenim.Name = "comboBoxOgrenim";
            this.comboBoxOgrenim.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOgrenim.TabIndex = 22;
            // 
            // comboBoxOgrDurum
            // 
            this.comboBoxOgrDurum.FormattingEnabled = true;
            this.comboBoxOgrDurum.Items.AddRange(new object[] {
            "Normal",
            "Raporlu",
            "Ayrıldı"});
            this.comboBoxOgrDurum.Location = new System.Drawing.Point(195, 434);
            this.comboBoxOgrDurum.Name = "comboBoxOgrDurum";
            this.comboBoxOgrDurum.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOgrDurum.TabIndex = 23;
            // 
            // comboBoxGuzergah
            // 
            this.comboBoxGuzergah.FormattingEnabled = true;
            this.comboBoxGuzergah.Location = new System.Drawing.Point(195, 482);
            this.comboBoxGuzergah.Name = "comboBoxGuzergah";
            this.comboBoxGuzergah.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGuzergah.TabIndex = 24;
            // 
            // txt_OgrNo
            // 
            this.txt_OgrNo.Location = new System.Drawing.Point(195, 307);
            this.txt_OgrNo.Name = "txt_OgrNo";
            this.txt_OgrNo.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrNo.TabIndex = 25;
            // 
            // txt_OgrReferans
            // 
            this.txt_OgrReferans.Location = new System.Drawing.Point(195, 269);
            this.txt_OgrReferans.Name = "txt_OgrReferans";
            this.txt_OgrReferans.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrReferans.TabIndex = 26;
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Baslik.Location = new System.Drawing.Point(149, 37);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(452, 34);
            this.Baslik.TabIndex = 27;
            this.Baslik.Text = "KIZILYER GÜNDÜZ BAKIM EVİ";
            // 
            // checkBoxServis
            // 
            this.checkBoxServis.AutoSize = true;
            this.checkBoxServis.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxServis.Location = new System.Drawing.Point(480, 406);
            this.checkBoxServis.Name = "checkBoxServis";
            this.checkBoxServis.Size = new System.Drawing.Size(172, 19);
            this.checkBoxServis.TabIndex = 28;
            this.checkBoxServis.Text = "Servis Hizmeti Alacak";
            this.checkBoxServis.UseVisualStyleBackColor = true;
            // 
            // checkBoxSut
            // 
            this.checkBoxSut.AutoSize = true;
            this.checkBoxSut.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSut.Location = new System.Drawing.Point(480, 452);
            this.checkBoxSut.Name = "checkBoxSut";
            this.checkBoxSut.Size = new System.Drawing.Size(125, 19);
            this.checkBoxSut.TabIndex = 29;
            this.checkBoxSut.Text = "Süt Kullanıyor";
            this.checkBoxSut.UseVisualStyleBackColor = true;
            // 
            // checkBoxTanidik
            // 
            this.checkBoxTanidik.AutoSize = true;
            this.checkBoxTanidik.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxTanidik.Location = new System.Drawing.Point(480, 501);
            this.checkBoxTanidik.Name = "checkBoxTanidik";
            this.checkBoxTanidik.Size = new System.Drawing.Size(106, 19);
            this.checkBoxTanidik.TabIndex = 30;
            this.checkBoxTanidik.Text = "Tanıdık mı?";
            this.checkBoxTanidik.UseVisualStyleBackColor = true;
            // 
            // pictureBoxOgr
            // 
            this.pictureBoxOgr.BackColor = System.Drawing.Color.White;
            this.pictureBoxOgr.Location = new System.Drawing.Point(488, 155);
            this.pictureBoxOgr.Name = "pictureBoxOgr";
            this.pictureBoxOgr.Size = new System.Drawing.Size(168, 176);
            this.pictureBoxOgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOgr.TabIndex = 31;
            this.pictureBoxOgr.TabStop = false;
            // 
            // btn_Ileri
            // 
            this.btn_Ileri.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Ileri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ileri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ileri.Location = new System.Drawing.Point(488, 592);
            this.btn_Ileri.Name = "btn_Ileri";
            this.btn_Ileri.Size = new System.Drawing.Size(75, 22);
            this.btn_Ileri.TabIndex = 34;
            this.btn_Ileri.Text = "İleri";
            this.btn_Ileri.UseVisualStyleBackColor = false;
            this.btn_Ileri.Click += new System.EventHandler(this.btn_Ileri_Click);
            // 
            // OgrTemelNot
            // 
            this.OgrTemelNot.AutoSize = true;
            this.OgrTemelNot.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrTemelNot.Location = new System.Drawing.Point(696, 119);
            this.OgrTemelNot.Name = "OgrTemelNot";
            this.OgrTemelNot.Size = new System.Drawing.Size(48, 16);
            this.OgrTemelNot.TabIndex = 35;
            this.OgrTemelNot.Text = "Notlar";
            // 
            // richTextBoxOgrTemNot
            // 
            this.richTextBoxOgrTemNot.Location = new System.Drawing.Point(745, 155);
            this.richTextBoxOgrTemNot.Name = "richTextBoxOgrTemNot";
            this.richTextBoxOgrTemNot.Size = new System.Drawing.Size(249, 361);
            this.richTextBoxOgrTemNot.TabIndex = 36;
            this.richTextBoxOgrTemNot.Text = "";
            // 
            // OgrIDBorc
            // 
            this.OgrIDBorc.AutoSize = true;
            this.OgrIDBorc.Location = new System.Drawing.Point(94, 553);
            this.OgrIDBorc.Name = "OgrIDBorc";
            this.OgrIDBorc.Size = new System.Drawing.Size(57, 13);
            this.OgrIDBorc.TabIndex = 37;
            this.OgrIDBorc.Text = "OgrIDBorc";
            this.OgrIDBorc.Visible = false;
            // 
            // MskKayitTarih
            // 
            this.MskKayitTarih.Location = new System.Drawing.Point(195, 234);
            this.MskKayitTarih.Mask = "00/00/0000";
            this.MskKayitTarih.Name = "MskKayitTarih";
            this.MskKayitTarih.Size = new System.Drawing.Size(200, 20);
            this.MskKayitTarih.TabIndex = 38;
            this.MskKayitTarih.ValidatingType = typeof(System.DateTime);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OgrDetayID
            // 
            this.OgrDetayID.AutoSize = true;
            this.OgrDetayID.Location = new System.Drawing.Point(220, 537);
            this.OgrDetayID.Name = "OgrDetayID";
            this.OgrDetayID.Size = new System.Drawing.Size(63, 13);
            this.OgrDetayID.TabIndex = 39;
            this.OgrDetayID.Text = "OgrDetayID";
            this.OgrDetayID.Visible = false;
            // 
            // Resim
            // 
            this.Resim.AutoSize = true;
            this.Resim.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Resim.Location = new System.Drawing.Point(436, 361);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(46, 14);
            this.Resim.TabIndex = 40;
            this.Resim.Text = "Resim:";
            // 
            // txt_Resim
            // 
            this.txt_Resim.Location = new System.Drawing.Point(488, 358);
            this.txt_Resim.Name = "txt_Resim";
            this.txt_Resim.Size = new System.Drawing.Size(151, 20);
            this.txt_Resim.TabIndex = 41;
            // 
            // btn_Resim
            // 
            this.btn_Resim.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Resim.Location = new System.Drawing.Point(645, 358);
            this.btn_Resim.Name = "btn_Resim";
            this.btn_Resim.Size = new System.Drawing.Size(29, 21);
            this.btn_Resim.TabIndex = 42;
            this.btn_Resim.Text = "...";
            this.btn_Resim.UseVisualStyleBackColor = true;
            this.btn_Resim.Click += new System.EventHandler(this.btn_Resim_Click);
            // 
            // sinifadi
            // 
            this.sinifadi.AutoSize = true;
            this.sinifadi.Location = new System.Drawing.Point(359, 552);
            this.sinifadi.Name = "sinifadi";
            this.sinifadi.Size = new System.Drawing.Size(40, 13);
            this.sinifadi.TabIndex = 43;
            this.sinifadi.Text = "SinifAd";
            this.sinifadi.Visible = false;
            // 
            // Guzergahad
            // 
            this.Guzergahad.AutoSize = true;
            this.Guzergahad.Location = new System.Drawing.Point(455, 568);
            this.Guzergahad.Name = "Guzergahad";
            this.Guzergahad.Size = new System.Drawing.Size(65, 13);
            this.Guzergahad.TabIndex = 44;
            this.Guzergahad.Text = "Guzergahad";
            this.Guzergahad.Visible = false;
            // 
            // OgrID
            // 
            this.OgrID.AutoSize = true;
            this.OgrID.Location = new System.Drawing.Point(45, 585);
            this.OgrID.Name = "OgrID";
            this.OgrID.Size = new System.Drawing.Size(35, 13);
            this.OgrID.TabIndex = 45;
            this.OgrID.Text = "OgrID";
            this.OgrID.Visible = false;
            // 
            // YeniOgrID
            // 
            this.YeniOgrID.AutoSize = true;
            this.YeniOgrID.Location = new System.Drawing.Point(604, 537);
            this.YeniOgrID.Name = "YeniOgrID";
            this.YeniOgrID.Size = new System.Drawing.Size(56, 13);
            this.YeniOgrID.TabIndex = 46;
            this.YeniOgrID.Text = "YeniOgrID";
            this.YeniOgrID.Visible = false;
            // 
            // Frm_YeniOgrTemel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1068, 626);
            this.Controls.Add(this.YeniOgrID);
            this.Controls.Add(this.OgrID);
            this.Controls.Add(this.Guzergahad);
            this.Controls.Add(this.sinifadi);
            this.Controls.Add(this.btn_Resim);
            this.Controls.Add(this.txt_Resim);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.OgrDetayID);
            this.Controls.Add(this.MskKayitTarih);
            this.Controls.Add(this.OgrIDBorc);
            this.Controls.Add(this.richTextBoxOgrTemNot);
            this.Controls.Add(this.OgrTemelNot);
            this.Controls.Add(this.btn_Ileri);
            this.Controls.Add(this.pictureBoxOgr);
            this.Controls.Add(this.checkBoxTanidik);
            this.Controls.Add(this.checkBoxSut);
            this.Controls.Add(this.checkBoxServis);
            this.Controls.Add(this.Baslik);
            this.Controls.Add(this.txt_OgrReferans);
            this.Controls.Add(this.txt_OgrNo);
            this.Controls.Add(this.comboBoxGuzergah);
            this.Controls.Add(this.comboBoxOgrDurum);
            this.Controls.Add(this.comboBoxOgrenim);
            this.Controls.Add(this.comboBoxSinif);
            this.Controls.Add(this.comboBoxOgrCinsiyet);
            this.Controls.Add(this.txt_OgrSoyad);
            this.Controls.Add(this.txt_OgrAd);
            this.Controls.Add(this.OgrServisGuzergah);
            this.Controls.Add(this.OgrResim);
            this.Controls.Add(this.OgrDurum);
            this.Controls.Add(this.OgrOgrenimSekli);
            this.Controls.Add(this.OgrSinif);
            this.Controls.Add(this.OgrNo);
            this.Controls.Add(this.OgrReferans);
            this.Controls.Add(this.OgrKayitTarih);
            this.Controls.Add(this.OgrCinsiyet);
            this.Controls.Add(this.OgrSoyad);
            this.Controls.Add(this.OgrAd);
            this.Name = "Frm_YeniOgrTemel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Öğrenci Temel Bilgiler";
            this.Load += new System.EventHandler(this.Frm_YeniOgrTemel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OgrAd;
        private System.Windows.Forms.Label OgrSoyad;
        private System.Windows.Forms.Label OgrCinsiyet;
        private System.Windows.Forms.Label OgrKayitTarih;
        private System.Windows.Forms.Label OgrReferans;
        private System.Windows.Forms.Label OgrNo;
        private System.Windows.Forms.Label OgrSinif;
        private System.Windows.Forms.Label OgrOgrenimSekli;
        private System.Windows.Forms.Label OgrDurum;
        private System.Windows.Forms.Label OgrResim;
        private System.Windows.Forms.Label OgrServisGuzergah;
        private System.Windows.Forms.TextBox txt_OgrAd;
        private System.Windows.Forms.TextBox txt_OgrSoyad;
        private System.Windows.Forms.ComboBox comboBoxOgrCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.ComboBox comboBoxOgrenim;
        private System.Windows.Forms.ComboBox comboBoxOgrDurum;
        private System.Windows.Forms.ComboBox comboBoxGuzergah;
        private System.Windows.Forms.TextBox txt_OgrNo;
        private System.Windows.Forms.TextBox txt_OgrReferans;
        private System.Windows.Forms.Label Baslik;
        private System.Windows.Forms.CheckBox checkBoxServis;
        private System.Windows.Forms.CheckBox checkBoxSut;
        private System.Windows.Forms.CheckBox checkBoxTanidik;
        private System.Windows.Forms.PictureBox pictureBoxOgr;
        private System.Windows.Forms.Button btn_Ileri;
        private System.Windows.Forms.Label OgrTemelNot;
        private System.Windows.Forms.RichTextBox richTextBoxOgrTemNot;
        private System.Windows.Forms.Label OgrIDBorc;
        private System.Windows.Forms.MaskedTextBox MskKayitTarih;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label OgrDetayID;
        private System.Windows.Forms.Label Resim;
        private System.Windows.Forms.TextBox txt_Resim;
        private System.Windows.Forms.Button btn_Resim;
        private System.Windows.Forms.Label sinifadi;
        private System.Windows.Forms.Label Guzergahad;
        private System.Windows.Forms.Label OgrID;
        private System.Windows.Forms.Label YeniOgrID;
    }
}