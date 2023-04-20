
namespace KresOtomasyon
{
    partial class Frm_OgrKartDetay
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
            this.MskOgrSonTarih = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrDogTar = new System.Windows.Forms.MaskedTextBox();
            this.RichOgrCocukIletisim = new System.Windows.Forms.RichTextBox();
            this.OgrCocukIletisim = new System.Windows.Forms.Label();
            this.RichOgrSevdigiSeyler = new System.Windows.Forms.RichTextBox();
            this.OgrSevdigiSeyler = new System.Windows.Forms.Label();
            this.RichFobi = new System.Windows.Forms.RichTextBox();
            this.OgrFobi = new System.Windows.Forms.Label();
            this.RichOgrSevmedigiYemek = new System.Windows.Forms.RichTextBox();
            this.OgrSevmedigiYemek = new System.Windows.Forms.Label();
            this.RichOgrSevdigiYemek = new System.Windows.Forms.RichTextBox();
            this.OgrSevdigiYemek = new System.Windows.Forms.Label();
            this.RichAdres = new System.Windows.Forms.RichTextBox();
            this.OgrAdres = new System.Windows.Forms.Label();
            this.checkBoxOgrYemek = new System.Windows.Forms.CheckBox();
            this.checkBoxOgrOda = new System.Windows.Forms.CheckBox();
            this.checkBoxOgrKira = new System.Windows.Forms.CheckBox();
            this.OgrSonTarih = new System.Windows.Forms.Label();
            this.txt_OgrUyruk = new System.Windows.Forms.TextBox();
            this.txt_OgrSeriNo = new System.Windows.Forms.TextBox();
            this.OgrSeriNo = new System.Windows.Forms.Label();
            this.OgrDogTarih = new System.Windows.Forms.Label();
            this.txt_OgrTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Ileri = new System.Windows.Forms.Button();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.OgrUyruk = new System.Windows.Forms.Label();
            this.OgrDetayID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MskOgrSonTarih
            // 
            this.MskOgrSonTarih.Location = new System.Drawing.Point(235, 254);
            this.MskOgrSonTarih.Mask = "00/00/0000";
            this.MskOgrSonTarih.Name = "MskOgrSonTarih";
            this.MskOgrSonTarih.Size = new System.Drawing.Size(221, 20);
            this.MskOgrSonTarih.TabIndex = 55;
            this.MskOgrSonTarih.ValidatingType = typeof(System.DateTime);
            // 
            // MskOgrDogTar
            // 
            this.MskOgrDogTar.Location = new System.Drawing.Point(235, 135);
            this.MskOgrDogTar.Mask = "00/00/0000";
            this.MskOgrDogTar.Name = "MskOgrDogTar";
            this.MskOgrDogTar.Size = new System.Drawing.Size(221, 20);
            this.MskOgrDogTar.TabIndex = 54;
            this.MskOgrDogTar.ValidatingType = typeof(System.DateTime);
            // 
            // RichOgrCocukIletisim
            // 
            this.RichOgrCocukIletisim.Location = new System.Drawing.Point(620, 485);
            this.RichOgrCocukIletisim.Name = "RichOgrCocukIletisim";
            this.RichOgrCocukIletisim.Size = new System.Drawing.Size(327, 76);
            this.RichOgrCocukIletisim.TabIndex = 53;
            this.RichOgrCocukIletisim.Text = "";
            // 
            // OgrCocukIletisim
            // 
            this.OgrCocukIletisim.AutoSize = true;
            this.OgrCocukIletisim.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrCocukIletisim.Location = new System.Drawing.Point(617, 466);
            this.OgrCocukIletisim.Name = "OgrCocukIletisim";
            this.OgrCocukIletisim.Size = new System.Drawing.Size(169, 16);
            this.OgrCocukIletisim.TabIndex = 52;
            this.OgrCocukIletisim.Text = "Diğer Çocuklarla İletişimi:";
            // 
            // RichOgrSevdigiSeyler
            // 
            this.RichOgrSevdigiSeyler.Location = new System.Drawing.Point(620, 378);
            this.RichOgrSevdigiSeyler.Name = "RichOgrSevdigiSeyler";
            this.RichOgrSevdigiSeyler.Size = new System.Drawing.Size(327, 75);
            this.RichOgrSevdigiSeyler.TabIndex = 51;
            this.RichOgrSevdigiSeyler.Text = "";
            // 
            // OgrSevdigiSeyler
            // 
            this.OgrSevdigiSeyler.AutoSize = true;
            this.OgrSevdigiSeyler.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSevdigiSeyler.Location = new System.Drawing.Point(617, 358);
            this.OgrSevdigiSeyler.Name = "OgrSevdigiSeyler";
            this.OgrSevdigiSeyler.Size = new System.Drawing.Size(99, 16);
            this.OgrSevdigiSeyler.TabIndex = 50;
            this.OgrSevdigiSeyler.Text = "Sevdiği Şeyler:";
            // 
            // RichFobi
            // 
            this.RichFobi.Location = new System.Drawing.Point(620, 274);
            this.RichFobi.Name = "RichFobi";
            this.RichFobi.Size = new System.Drawing.Size(327, 70);
            this.RichFobi.TabIndex = 49;
            this.RichFobi.Text = "";
            // 
            // OgrFobi
            // 
            this.OgrFobi.AutoSize = true;
            this.OgrFobi.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrFobi.Location = new System.Drawing.Point(617, 255);
            this.OgrFobi.Name = "OgrFobi";
            this.OgrFobi.Size = new System.Drawing.Size(61, 16);
            this.OgrFobi.TabIndex = 48;
            this.OgrFobi.Text = "Fobileri:";
            // 
            // RichOgrSevmedigiYemek
            // 
            this.RichOgrSevmedigiYemek.Location = new System.Drawing.Point(620, 170);
            this.RichOgrSevmedigiYemek.Name = "RichOgrSevmedigiYemek";
            this.RichOgrSevmedigiYemek.Size = new System.Drawing.Size(327, 70);
            this.RichOgrSevmedigiYemek.TabIndex = 47;
            this.RichOgrSevmedigiYemek.Text = "";
            // 
            // OgrSevmedigiYemek
            // 
            this.OgrSevmedigiYemek.AutoSize = true;
            this.OgrSevmedigiYemek.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSevmedigiYemek.Location = new System.Drawing.Point(617, 151);
            this.OgrSevmedigiYemek.Name = "OgrSevmedigiYemek";
            this.OgrSevmedigiYemek.Size = new System.Drawing.Size(137, 16);
            this.OgrSevmedigiYemek.TabIndex = 46;
            this.OgrSevmedigiYemek.Text = "Sevmediği yemekler:";
            // 
            // RichOgrSevdigiYemek
            // 
            this.RichOgrSevdigiYemek.Location = new System.Drawing.Point(620, 69);
            this.RichOgrSevdigiYemek.Name = "RichOgrSevdigiYemek";
            this.RichOgrSevdigiYemek.Size = new System.Drawing.Size(327, 68);
            this.RichOgrSevdigiYemek.TabIndex = 45;
            this.RichOgrSevdigiYemek.Text = "";
            // 
            // OgrSevdigiYemek
            // 
            this.OgrSevdigiYemek.AutoSize = true;
            this.OgrSevdigiYemek.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSevdigiYemek.Location = new System.Drawing.Point(617, 50);
            this.OgrSevdigiYemek.Name = "OgrSevdigiYemek";
            this.OgrSevdigiYemek.Size = new System.Drawing.Size(120, 16);
            this.OgrSevdigiYemek.TabIndex = 44;
            this.OgrSevdigiYemek.Text = "Sevdiği Yemekler:";
            // 
            // RichAdres
            // 
            this.RichAdres.Location = new System.Drawing.Point(235, 294);
            this.RichAdres.Name = "RichAdres";
            this.RichAdres.Size = new System.Drawing.Size(221, 203);
            this.RichAdres.TabIndex = 43;
            this.RichAdres.Text = "";
            // 
            // OgrAdres
            // 
            this.OgrAdres.AutoSize = true;
            this.OgrAdres.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrAdres.Location = new System.Drawing.Point(150, 294);
            this.OgrAdres.Name = "OgrAdres";
            this.OgrAdres.Size = new System.Drawing.Size(53, 16);
            this.OgrAdres.TabIndex = 42;
            this.OgrAdres.Text = "Adresi:";
            // 
            // checkBoxOgrYemek
            // 
            this.checkBoxOgrYemek.AutoSize = true;
            this.checkBoxOgrYemek.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrYemek.Location = new System.Drawing.Point(632, 584);
            this.checkBoxOgrYemek.Name = "checkBoxOgrYemek";
            this.checkBoxOgrYemek.Size = new System.Drawing.Size(251, 20);
            this.checkBoxOgrYemek.TabIndex = 41;
            this.checkBoxOgrYemek.Text = "Kendi başına yemek yiyebiliyor mu?";
            this.checkBoxOgrYemek.UseVisualStyleBackColor = true;
            // 
            // checkBoxOgrOda
            // 
            this.checkBoxOgrOda.AutoSize = true;
            this.checkBoxOgrOda.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrOda.Location = new System.Drawing.Point(426, 584);
            this.checkBoxOgrOda.Name = "checkBoxOgrOda";
            this.checkBoxOgrOda.Size = new System.Drawing.Size(148, 20);
            this.checkBoxOgrOda.TabIndex = 40;
            this.checkBoxOgrOda.Text = "Kendi odası var mı?";
            this.checkBoxOgrOda.UseVisualStyleBackColor = true;
            // 
            // checkBoxOgrKira
            // 
            this.checkBoxOgrKira.AutoSize = true;
            this.checkBoxOgrKira.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrKira.Location = new System.Drawing.Point(185, 584);
            this.checkBoxOgrKira.Name = "checkBoxOgrKira";
            this.checkBoxOgrKira.Size = new System.Drawing.Size(153, 20);
            this.checkBoxOgrKira.TabIndex = 39;
            this.checkBoxOgrKira.Text = "Kirada mı oturuyor?";
            this.checkBoxOgrKira.UseVisualStyleBackColor = true;
            // 
            // OgrSonTarih
            // 
            this.OgrSonTarih.AutoSize = true;
            this.OgrSonTarih.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSonTarih.Location = new System.Drawing.Point(70, 256);
            this.OgrSonTarih.Name = "OgrSonTarih";
            this.OgrSonTarih.Size = new System.Drawing.Size(137, 16);
            this.OgrSonTarih.TabIndex = 38;
            this.OgrSonTarih.Text = "Son Kullanma Tarihi:";
            // 
            // txt_OgrUyruk
            // 
            this.txt_OgrUyruk.Location = new System.Drawing.Point(235, 217);
            this.txt_OgrUyruk.Name = "txt_OgrUyruk";
            this.txt_OgrUyruk.Size = new System.Drawing.Size(221, 20);
            this.txt_OgrUyruk.TabIndex = 37;
            // 
            // txt_OgrSeriNo
            // 
            this.txt_OgrSeriNo.Location = new System.Drawing.Point(235, 180);
            this.txt_OgrSeriNo.Name = "txt_OgrSeriNo";
            this.txt_OgrSeriNo.Size = new System.Drawing.Size(221, 20);
            this.txt_OgrSeriNo.TabIndex = 36;
            // 
            // OgrSeriNo
            // 
            this.OgrSeriNo.AutoSize = true;
            this.OgrSeriNo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSeriNo.Location = new System.Drawing.Point(108, 180);
            this.OgrSeriNo.Name = "OgrSeriNo";
            this.OgrSeriNo.Size = new System.Drawing.Size(99, 16);
            this.OgrSeriNo.TabIndex = 35;
            this.OgrSeriNo.Text = "Seri Numarası:";
            // 
            // OgrDogTarih
            // 
            this.OgrDogTarih.AutoSize = true;
            this.OgrDogTarih.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrDogTarih.Location = new System.Drawing.Point(107, 136);
            this.OgrDogTarih.Name = "OgrDogTarih";
            this.OgrDogTarih.Size = new System.Drawing.Size(96, 16);
            this.OgrDogTarih.TabIndex = 34;
            this.OgrDogTarih.Text = "Doğum Tarihi:";
            // 
            // txt_OgrTC
            // 
            this.txt_OgrTC.Location = new System.Drawing.Point(235, 91);
            this.txt_OgrTC.Name = "txt_OgrTC";
            this.txt_OgrTC.Size = new System.Drawing.Size(221, 20);
            this.txt_OgrTC.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "T.C. Kimlik Numarası:";
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(62, 671);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri.TabIndex = 72;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Ileri
            // 
            this.btn_Ileri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ileri.Location = new System.Drawing.Point(833, 671);
            this.btn_Ileri.Name = "btn_Ileri";
            this.btn_Ileri.Size = new System.Drawing.Size(75, 23);
            this.btn_Ileri.TabIndex = 71;
            this.btn_Ileri.Text = "İleri";
            this.btn_Ileri.UseVisualStyleBackColor = true;
            this.btn_Ileri.Click += new System.EventHandler(this.btn_Ileri_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.Location = new System.Drawing.Point(445, 671);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_Duzenle.TabIndex = 70;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // OgrUyruk
            // 
            this.OgrUyruk.AutoSize = true;
            this.OgrUyruk.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrUyruk.Location = new System.Drawing.Point(152, 218);
            this.OgrUyruk.Name = "OgrUyruk";
            this.OgrUyruk.Size = new System.Drawing.Size(51, 16);
            this.OgrUyruk.TabIndex = 73;
            this.OgrUyruk.Text = "Uyruk:";
            // 
            // OgrDetayID
            // 
            this.OgrDetayID.AutoSize = true;
            this.OgrDetayID.Location = new System.Drawing.Point(82, 444);
            this.OgrDetayID.Name = "OgrDetayID";
            this.OgrDetayID.Size = new System.Drawing.Size(63, 13);
            this.OgrDetayID.TabIndex = 74;
            this.OgrDetayID.Text = "OgrDetayID";
            this.OgrDetayID.Visible = false;
            // 
            // Frm_OgrKartDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(990, 744);
            this.Controls.Add(this.OgrDetayID);
            this.Controls.Add(this.OgrUyruk);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Ileri);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.MskOgrSonTarih);
            this.Controls.Add(this.MskOgrDogTar);
            this.Controls.Add(this.RichOgrCocukIletisim);
            this.Controls.Add(this.OgrCocukIletisim);
            this.Controls.Add(this.RichOgrSevdigiSeyler);
            this.Controls.Add(this.OgrSevdigiSeyler);
            this.Controls.Add(this.RichFobi);
            this.Controls.Add(this.OgrFobi);
            this.Controls.Add(this.RichOgrSevmedigiYemek);
            this.Controls.Add(this.OgrSevmedigiYemek);
            this.Controls.Add(this.RichOgrSevdigiYemek);
            this.Controls.Add(this.OgrSevdigiYemek);
            this.Controls.Add(this.RichAdres);
            this.Controls.Add(this.OgrAdres);
            this.Controls.Add(this.checkBoxOgrYemek);
            this.Controls.Add(this.checkBoxOgrOda);
            this.Controls.Add(this.checkBoxOgrKira);
            this.Controls.Add(this.OgrSonTarih);
            this.Controls.Add(this.txt_OgrUyruk);
            this.Controls.Add(this.txt_OgrSeriNo);
            this.Controls.Add(this.OgrSeriNo);
            this.Controls.Add(this.OgrDogTarih);
            this.Controls.Add(this.txt_OgrTC);
            this.Controls.Add(this.label1);
            this.Name = "Frm_OgrKartDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kartı Detay Bilgiler";
            this.Load += new System.EventHandler(this.Frm_OgrKartDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskOgrSonTarih;
        private System.Windows.Forms.MaskedTextBox MskOgrDogTar;
        private System.Windows.Forms.RichTextBox RichOgrCocukIletisim;
        private System.Windows.Forms.Label OgrCocukIletisim;
        private System.Windows.Forms.RichTextBox RichOgrSevdigiSeyler;
        private System.Windows.Forms.Label OgrSevdigiSeyler;
        private System.Windows.Forms.RichTextBox RichFobi;
        private System.Windows.Forms.Label OgrFobi;
        private System.Windows.Forms.RichTextBox RichOgrSevmedigiYemek;
        private System.Windows.Forms.Label OgrSevmedigiYemek;
        private System.Windows.Forms.RichTextBox RichOgrSevdigiYemek;
        private System.Windows.Forms.Label OgrSevdigiYemek;
        private System.Windows.Forms.RichTextBox RichAdres;
        private System.Windows.Forms.Label OgrAdres;
        private System.Windows.Forms.CheckBox checkBoxOgrYemek;
        private System.Windows.Forms.CheckBox checkBoxOgrOda;
        private System.Windows.Forms.CheckBox checkBoxOgrKira;
        private System.Windows.Forms.Label OgrSonTarih;
        private System.Windows.Forms.TextBox txt_OgrUyruk;
        private System.Windows.Forms.TextBox txt_OgrSeriNo;
        private System.Windows.Forms.Label OgrSeriNo;
        private System.Windows.Forms.Label OgrDogTarih;
        private System.Windows.Forms.TextBox txt_OgrTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_Ileri;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Label OgrUyruk;
        private System.Windows.Forms.Label OgrDetayID;
    }
}