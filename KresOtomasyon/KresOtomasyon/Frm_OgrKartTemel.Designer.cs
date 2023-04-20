
namespace KresOtomasyon
{
    partial class Frm_OgrKartTemel
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
            this.richTextBoxOgrTemNot = new System.Windows.Forms.RichTextBox();
            this.OgrTemelNot = new System.Windows.Forms.Label();
            this.pictureBoxOgr = new System.Windows.Forms.PictureBox();
            this.checkBoxTanidik = new System.Windows.Forms.CheckBox();
            this.checkBoxSut = new System.Windows.Forms.CheckBox();
            this.checkBoxServis = new System.Windows.Forms.CheckBox();
            this.txt_OgrReferans = new System.Windows.Forms.TextBox();
            this.txt_OgrNo = new System.Windows.Forms.TextBox();
            this.comboBoxGuzergah = new System.Windows.Forms.ComboBox();
            this.comboBoxOgrDurum = new System.Windows.Forms.ComboBox();
            this.comboBoxOgrenim = new System.Windows.Forms.ComboBox();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.comboBoxOgrCinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_OgrSoyad = new System.Windows.Forms.TextBox();
            this.txt_OgrAd = new System.Windows.Forms.TextBox();
            this.OgrServisGuzergah = new System.Windows.Forms.Label();
            this.OgrResimPic = new System.Windows.Forms.Label();
            this.OgrDurum = new System.Windows.Forms.Label();
            this.OgrOgrenimSekli = new System.Windows.Forms.Label();
            this.OgrSinif = new System.Windows.Forms.Label();
            this.OgrNo = new System.Windows.Forms.Label();
            this.OgrReferans = new System.Windows.Forms.Label();
            this.OgrKayitTarih = new System.Windows.Forms.Label();
            this.OgrCinsiyet = new System.Windows.Forms.Label();
            this.OgrSoyad = new System.Windows.Forms.Label();
            this.OgrAd = new System.Windows.Forms.Label();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.btn_Iptal = new System.Windows.Forms.Button();
            this.btn_Ileri = new System.Windows.Forms.Button();
            this.txt_OgrID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskKayitTarih = new System.Windows.Forms.MaskedTextBox();
            this.btn_Resim = new System.Windows.Forms.Button();
            this.txt_Resim = new System.Windows.Forms.TextBox();
            this.OgrResim = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgr)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxOgrTemNot
            // 
            this.richTextBoxOgrTemNot.Location = new System.Drawing.Point(756, 92);
            this.richTextBoxOgrTemNot.Name = "richTextBoxOgrTemNot";
            this.richTextBoxOgrTemNot.Size = new System.Drawing.Size(249, 361);
            this.richTextBoxOgrTemNot.TabIndex = 63;
            this.richTextBoxOgrTemNot.Text = "";
            // 
            // OgrTemelNot
            // 
            this.OgrTemelNot.AutoSize = true;
            this.OgrTemelNot.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrTemelNot.Location = new System.Drawing.Point(753, 52);
            this.OgrTemelNot.Name = "OgrTemelNot";
            this.OgrTemelNot.Size = new System.Drawing.Size(48, 16);
            this.OgrTemelNot.TabIndex = 62;
            this.OgrTemelNot.Text = "Notlar";
            // 
            // pictureBoxOgr
            // 
            this.pictureBoxOgr.BackColor = System.Drawing.Color.White;
            this.pictureBoxOgr.Location = new System.Drawing.Point(545, 88);
            this.pictureBoxOgr.Name = "pictureBoxOgr";
            this.pictureBoxOgr.Size = new System.Drawing.Size(168, 176);
            this.pictureBoxOgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOgr.TabIndex = 60;
            this.pictureBoxOgr.TabStop = false;
            // 
            // checkBoxTanidik
            // 
            this.checkBoxTanidik.AutoSize = true;
            this.checkBoxTanidik.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxTanidik.Location = new System.Drawing.Point(541, 434);
            this.checkBoxTanidik.Name = "checkBoxTanidik";
            this.checkBoxTanidik.Size = new System.Drawing.Size(106, 19);
            this.checkBoxTanidik.TabIndex = 59;
            this.checkBoxTanidik.Text = "Tanıdık mı?";
            this.checkBoxTanidik.UseVisualStyleBackColor = true;
            // 
            // checkBoxSut
            // 
            this.checkBoxSut.AutoSize = true;
            this.checkBoxSut.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSut.Location = new System.Drawing.Point(541, 385);
            this.checkBoxSut.Name = "checkBoxSut";
            this.checkBoxSut.Size = new System.Drawing.Size(125, 19);
            this.checkBoxSut.TabIndex = 58;
            this.checkBoxSut.Text = "Süt Kullanıyor";
            this.checkBoxSut.UseVisualStyleBackColor = true;
            // 
            // checkBoxServis
            // 
            this.checkBoxServis.AutoSize = true;
            this.checkBoxServis.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxServis.Location = new System.Drawing.Point(541, 339);
            this.checkBoxServis.Name = "checkBoxServis";
            this.checkBoxServis.Size = new System.Drawing.Size(172, 19);
            this.checkBoxServis.TabIndex = 57;
            this.checkBoxServis.Text = "Servis Hizmeti Alacak";
            this.checkBoxServis.UseVisualStyleBackColor = true;
            // 
            // txt_OgrReferans
            // 
            this.txt_OgrReferans.Location = new System.Drawing.Point(243, 233);
            this.txt_OgrReferans.Name = "txt_OgrReferans";
            this.txt_OgrReferans.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrReferans.TabIndex = 56;
            // 
            // txt_OgrNo
            // 
            this.txt_OgrNo.Location = new System.Drawing.Point(243, 271);
            this.txt_OgrNo.Name = "txt_OgrNo";
            this.txt_OgrNo.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrNo.TabIndex = 55;
            // 
            // comboBoxGuzergah
            // 
            this.comboBoxGuzergah.FormattingEnabled = true;
            this.comboBoxGuzergah.Location = new System.Drawing.Point(243, 446);
            this.comboBoxGuzergah.Name = "comboBoxGuzergah";
            this.comboBoxGuzergah.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGuzergah.TabIndex = 54;
            // 
            // comboBoxOgrDurum
            // 
            this.comboBoxOgrDurum.FormattingEnabled = true;
            this.comboBoxOgrDurum.Items.AddRange(new object[] {
            "Normal",
            "Raporlu",
            "Ayrıldı"});
            this.comboBoxOgrDurum.Location = new System.Drawing.Point(243, 398);
            this.comboBoxOgrDurum.Name = "comboBoxOgrDurum";
            this.comboBoxOgrDurum.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOgrDurum.TabIndex = 53;
            // 
            // comboBoxOgrenim
            // 
            this.comboBoxOgrenim.FormattingEnabled = true;
            this.comboBoxOgrenim.Items.AddRange(new object[] {
            "Sabahçı",
            "Öğlenci",
            "Tam Gün"});
            this.comboBoxOgrenim.Location = new System.Drawing.Point(243, 354);
            this.comboBoxOgrenim.Name = "comboBoxOgrenim";
            this.comboBoxOgrenim.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOgrenim.TabIndex = 52;
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(243, 311);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSinif.TabIndex = 51;
            // 
            // comboBoxOgrCinsiyet
            // 
            this.comboBoxOgrCinsiyet.FormattingEnabled = true;
            this.comboBoxOgrCinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.comboBoxOgrCinsiyet.Location = new System.Drawing.Point(243, 158);
            this.comboBoxOgrCinsiyet.Name = "comboBoxOgrCinsiyet";
            this.comboBoxOgrCinsiyet.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOgrCinsiyet.TabIndex = 50;
            // 
            // txt_OgrSoyad
            // 
            this.txt_OgrSoyad.Location = new System.Drawing.Point(243, 119);
            this.txt_OgrSoyad.Name = "txt_OgrSoyad";
            this.txt_OgrSoyad.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrSoyad.TabIndex = 49;
            // 
            // txt_OgrAd
            // 
            this.txt_OgrAd.Location = new System.Drawing.Point(243, 83);
            this.txt_OgrAd.Name = "txt_OgrAd";
            this.txt_OgrAd.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrAd.TabIndex = 48;
            // 
            // OgrServisGuzergah
            // 
            this.OgrServisGuzergah.AutoSize = true;
            this.OgrServisGuzergah.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrServisGuzergah.Location = new System.Drawing.Point(94, 451);
            this.OgrServisGuzergah.Name = "OgrServisGuzergah";
            this.OgrServisGuzergah.Size = new System.Drawing.Size(115, 16);
            this.OgrServisGuzergah.TabIndex = 47;
            this.OgrServisGuzergah.Text = "Servis Güzergahı:";
            // 
            // OgrResimPic
            // 
            this.OgrResimPic.AutoSize = true;
            this.OgrResimPic.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrResimPic.Location = new System.Drawing.Point(542, 52);
            this.OgrResimPic.Name = "OgrResimPic";
            this.OgrResimPic.Size = new System.Drawing.Size(101, 16);
            this.OgrResimPic.TabIndex = 46;
            this.OgrResimPic.Text = "Öğrenci Resmi:";
            // 
            // OgrDurum
            // 
            this.OgrDurum.AutoSize = true;
            this.OgrDurum.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrDurum.Location = new System.Drawing.Point(90, 403);
            this.OgrDurum.Name = "OgrDurum";
            this.OgrDurum.Size = new System.Drawing.Size(119, 16);
            this.OgrDurum.TabIndex = 45;
            this.OgrDurum.Text = "Öğrenim Durumu:";
            // 
            // OgrOgrenimSekli
            // 
            this.OgrOgrenimSekli.AutoSize = true;
            this.OgrOgrenimSekli.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrOgrenimSekli.Location = new System.Drawing.Point(112, 359);
            this.OgrOgrenimSekli.Name = "OgrOgrenimSekli";
            this.OgrOgrenimSekli.Size = new System.Drawing.Size(97, 16);
            this.OgrOgrenimSekli.TabIndex = 44;
            this.OgrOgrenimSekli.Text = "Öğrenim Şekli:";
            // 
            // OgrSinif
            // 
            this.OgrSinif.AutoSize = true;
            this.OgrSinif.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSinif.Location = new System.Drawing.Point(166, 316);
            this.OgrSinif.Name = "OgrSinif";
            this.OgrSinif.Size = new System.Drawing.Size(43, 16);
            this.OgrSinif.TabIndex = 43;
            this.OgrSinif.Text = "Sınıfı:";
            // 
            // OgrNo
            // 
            this.OgrNo.AutoSize = true;
            this.OgrNo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrNo.Location = new System.Drawing.Point(86, 275);
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Size = new System.Drawing.Size(123, 16);
            this.OgrNo.TabIndex = 42;
            this.OgrNo.Text = "Öğrenci Numarası:";
            // 
            // OgrReferans
            // 
            this.OgrReferans.AutoSize = true;
            this.OgrReferans.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrReferans.Location = new System.Drawing.Point(139, 233);
            this.OgrReferans.Name = "OgrReferans";
            this.OgrReferans.Size = new System.Drawing.Size(70, 16);
            this.OgrReferans.TabIndex = 41;
            this.OgrReferans.Text = "Referansı:";
            // 
            // OgrKayitTarih
            // 
            this.OgrKayitTarih.AutoSize = true;
            this.OgrKayitTarih.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrKayitTarih.Location = new System.Drawing.Point(124, 199);
            this.OgrKayitTarih.Name = "OgrKayitTarih";
            this.OgrKayitTarih.Size = new System.Drawing.Size(85, 16);
            this.OgrKayitTarih.TabIndex = 40;
            this.OgrKayitTarih.Text = "Kayıt Tarihi:";
            // 
            // OgrCinsiyet
            // 
            this.OgrCinsiyet.AutoSize = true;
            this.OgrCinsiyet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrCinsiyet.Location = new System.Drawing.Point(147, 163);
            this.OgrCinsiyet.Name = "OgrCinsiyet";
            this.OgrCinsiyet.Size = new System.Drawing.Size(62, 16);
            this.OgrCinsiyet.TabIndex = 39;
            this.OgrCinsiyet.Text = "Cinsiyet:";
            // 
            // OgrSoyad
            // 
            this.OgrSoyad.AutoSize = true;
            this.OgrSoyad.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSoyad.Location = new System.Drawing.Point(155, 123);
            this.OgrSoyad.Name = "OgrSoyad";
            this.OgrSoyad.Size = new System.Drawing.Size(54, 16);
            this.OgrSoyad.TabIndex = 38;
            this.OgrSoyad.Text = "Soyadı:";
            // 
            // OgrAd
            // 
            this.OgrAd.AutoSize = true;
            this.OgrAd.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrAd.Location = new System.Drawing.Point(175, 87);
            this.OgrAd.Name = "OgrAd";
            this.OgrAd.Size = new System.Drawing.Size(34, 16);
            this.OgrAd.TabIndex = 37;
            this.OgrAd.Text = "Adı:";
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.Location = new System.Drawing.Point(477, 506);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_Duzenle.TabIndex = 67;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Iptal.Location = new System.Drawing.Point(94, 506);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_Iptal.TabIndex = 69;
            this.btn_Iptal.Text = "İptal";
            this.btn_Iptal.UseVisualStyleBackColor = true;
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // btn_Ileri
            // 
            this.btn_Ileri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ileri.Location = new System.Drawing.Point(865, 506);
            this.btn_Ileri.Name = "btn_Ileri";
            this.btn_Ileri.Size = new System.Drawing.Size(75, 23);
            this.btn_Ileri.TabIndex = 68;
            this.btn_Ileri.Text = "İleri";
            this.btn_Ileri.UseVisualStyleBackColor = true;
            this.btn_Ileri.Click += new System.EventHandler(this.btn_Ileri_Click);
            // 
            // txt_OgrID
            // 
            this.txt_OgrID.Enabled = false;
            this.txt_OgrID.Location = new System.Drawing.Point(243, 48);
            this.txt_OgrID.Name = "txt_OgrID";
            this.txt_OgrID.Size = new System.Drawing.Size(200, 20);
            this.txt_OgrID.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Öğrenci ID:";
            // 
            // MskKayitTarih
            // 
            this.MskKayitTarih.Location = new System.Drawing.Point(243, 199);
            this.MskKayitTarih.Mask = "00/00/0000";
            this.MskKayitTarih.Name = "MskKayitTarih";
            this.MskKayitTarih.Size = new System.Drawing.Size(200, 20);
            this.MskKayitTarih.TabIndex = 72;
            this.MskKayitTarih.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Resim
            // 
            this.btn_Resim.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Resim.Location = new System.Drawing.Point(702, 290);
            this.btn_Resim.Name = "btn_Resim";
            this.btn_Resim.Size = new System.Drawing.Size(29, 21);
            this.btn_Resim.TabIndex = 74;
            this.btn_Resim.Text = "...";
            this.btn_Resim.UseVisualStyleBackColor = true;
            this.btn_Resim.Click += new System.EventHandler(this.btn_Resim_Click);
            // 
            // txt_Resim
            // 
            this.txt_Resim.Location = new System.Drawing.Point(545, 290);
            this.txt_Resim.Name = "txt_Resim";
            this.txt_Resim.Size = new System.Drawing.Size(151, 20);
            this.txt_Resim.TabIndex = 73;
            // 
            // OgrResim
            // 
            this.OgrResim.AutoSize = true;
            this.OgrResim.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrResim.Location = new System.Drawing.Point(493, 293);
            this.OgrResim.Name = "OgrResim";
            this.OgrResim.Size = new System.Drawing.Size(46, 14);
            this.OgrResim.TabIndex = 75;
            this.OgrResim.Text = "Resim:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_OgrKartTemel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1069, 585);
            this.Controls.Add(this.OgrResim);
            this.Controls.Add(this.btn_Resim);
            this.Controls.Add(this.txt_Resim);
            this.Controls.Add(this.MskKayitTarih);
            this.Controls.Add(this.txt_OgrID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_Ileri);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.richTextBoxOgrTemNot);
            this.Controls.Add(this.OgrTemelNot);
            this.Controls.Add(this.pictureBoxOgr);
            this.Controls.Add(this.checkBoxTanidik);
            this.Controls.Add(this.checkBoxSut);
            this.Controls.Add(this.checkBoxServis);
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
            this.Controls.Add(this.OgrResimPic);
            this.Controls.Add(this.OgrDurum);
            this.Controls.Add(this.OgrOgrenimSekli);
            this.Controls.Add(this.OgrSinif);
            this.Controls.Add(this.OgrNo);
            this.Controls.Add(this.OgrReferans);
            this.Controls.Add(this.OgrKayitTarih);
            this.Controls.Add(this.OgrCinsiyet);
            this.Controls.Add(this.OgrSoyad);
            this.Controls.Add(this.OgrAd);
            this.Name = "Frm_OgrKartTemel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kartı Temel Bilgiler";
            this.Load += new System.EventHandler(this.Frm_OgrKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOgrTemNot;
        private System.Windows.Forms.Label OgrTemelNot;
        private System.Windows.Forms.PictureBox pictureBoxOgr;
        private System.Windows.Forms.CheckBox checkBoxTanidik;
        private System.Windows.Forms.CheckBox checkBoxSut;
        private System.Windows.Forms.CheckBox checkBoxServis;
        private System.Windows.Forms.TextBox txt_OgrReferans;
        private System.Windows.Forms.TextBox txt_OgrNo;
        private System.Windows.Forms.ComboBox comboBoxGuzergah;
        private System.Windows.Forms.ComboBox comboBoxOgrDurum;
        private System.Windows.Forms.ComboBox comboBoxOgrenim;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.ComboBox comboBoxOgrCinsiyet;
        private System.Windows.Forms.TextBox txt_OgrSoyad;
        private System.Windows.Forms.TextBox txt_OgrAd;
        private System.Windows.Forms.Label OgrServisGuzergah;
        private System.Windows.Forms.Label OgrResimPic;
        private System.Windows.Forms.Label OgrDurum;
        private System.Windows.Forms.Label OgrOgrenimSekli;
        private System.Windows.Forms.Label OgrSinif;
        private System.Windows.Forms.Label OgrNo;
        private System.Windows.Forms.Label OgrReferans;
        private System.Windows.Forms.Label OgrKayitTarih;
        private System.Windows.Forms.Label OgrCinsiyet;
        private System.Windows.Forms.Label OgrSoyad;
        private System.Windows.Forms.Label OgrAd;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Button btn_Iptal;
        private System.Windows.Forms.Button btn_Ileri;
        private System.Windows.Forms.TextBox txt_OgrID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskKayitTarih;
        private System.Windows.Forms.Button btn_Resim;
        private System.Windows.Forms.TextBox txt_Resim;
        private System.Windows.Forms.Label OgrResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}