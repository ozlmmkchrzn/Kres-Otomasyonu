
namespace KresOtomasyon
{
    partial class Frm_YeniEtkinlik
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
            this.EtkinlikAd = new System.Windows.Forms.Label();
            this.txt_EtkinlikAd = new System.Windows.Forms.TextBox();
            this.EtkinlikAciklama = new System.Windows.Forms.Label();
            this.RichEtkinlikAciklama = new System.Windows.Forms.RichTextBox();
            this.Katilimci = new System.Windows.Forms.Label();
            this.RichKatilimci = new System.Windows.Forms.RichTextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_İptal = new System.Windows.Forms.Button();
            this.EtkinlikTarih = new System.Windows.Forms.Label();
            this.MskEtkinlikTarih = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // EtkinlikAd
            // 
            this.EtkinlikAd.AutoSize = true;
            this.EtkinlikAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikAd.Location = new System.Drawing.Point(62, 111);
            this.EtkinlikAd.Name = "EtkinlikAd";
            this.EtkinlikAd.Size = new System.Drawing.Size(80, 14);
            this.EtkinlikAd.TabIndex = 0;
            this.EtkinlikAd.Text = "Etkinlik Adı:";
            // 
            // txt_EtkinlikAd
            // 
            this.txt_EtkinlikAd.Location = new System.Drawing.Point(164, 108);
            this.txt_EtkinlikAd.Name = "txt_EtkinlikAd";
            this.txt_EtkinlikAd.Size = new System.Drawing.Size(234, 20);
            this.txt_EtkinlikAd.TabIndex = 1;
            // 
            // EtkinlikAciklama
            // 
            this.EtkinlikAciklama.AutoSize = true;
            this.EtkinlikAciklama.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikAciklama.Location = new System.Drawing.Point(852, 39);
            this.EtkinlikAciklama.Name = "EtkinlikAciklama";
            this.EtkinlikAciklama.Size = new System.Drawing.Size(125, 14);
            this.EtkinlikAciklama.TabIndex = 2;
            this.EtkinlikAciklama.Text = "Etkinlik Açıklaması:";
            // 
            // RichEtkinlikAciklama
            // 
            this.RichEtkinlikAciklama.Location = new System.Drawing.Point(855, 72);
            this.RichEtkinlikAciklama.Name = "RichEtkinlikAciklama";
            this.RichEtkinlikAciklama.Size = new System.Drawing.Size(265, 185);
            this.RichEtkinlikAciklama.TabIndex = 3;
            this.RichEtkinlikAciklama.Text = "";
            // 
            // Katilimci
            // 
            this.Katilimci.AutoSize = true;
            this.Katilimci.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Katilimci.Location = new System.Drawing.Point(504, 39);
            this.Katilimci.Name = "Katilimci";
            this.Katilimci.Size = new System.Drawing.Size(82, 14);
            this.Katilimci.TabIndex = 8;
            this.Katilimci.Text = "Katılımcılar:";
            // 
            // RichKatilimci
            // 
            this.RichKatilimci.Location = new System.Drawing.Point(507, 72);
            this.RichKatilimci.Name = "RichKatilimci";
            this.RichKatilimci.Size = new System.Drawing.Size(200, 185);
            this.RichKatilimci.TabIndex = 9;
            this.RichKatilimci.Text = "";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(865, 372);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 10;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_İptal
            // 
            this.btn_İptal.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_İptal.Location = new System.Drawing.Point(190, 372);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.Size = new System.Drawing.Size(75, 23);
            this.btn_İptal.TabIndex = 11;
            this.btn_İptal.Text = "İptal";
            this.btn_İptal.UseVisualStyleBackColor = true;
            this.btn_İptal.Click += new System.EventHandler(this.btn_İptal_Click);
            // 
            // EtkinlikTarih
            // 
            this.EtkinlikTarih.AutoSize = true;
            this.EtkinlikTarih.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikTarih.Location = new System.Drawing.Point(45, 212);
            this.EtkinlikTarih.Name = "EtkinlikTarih";
            this.EtkinlikTarih.Size = new System.Drawing.Size(97, 14);
            this.EtkinlikTarih.TabIndex = 4;
            this.EtkinlikTarih.Text = "Etkinlik Tarihi:";
            // 
            // MskEtkinlikTarih
            // 
            this.MskEtkinlikTarih.Location = new System.Drawing.Point(164, 209);
            this.MskEtkinlikTarih.Mask = "00/00/0000";
            this.MskEtkinlikTarih.Name = "MskEtkinlikTarih";
            this.MskEtkinlikTarih.Size = new System.Drawing.Size(234, 20);
            this.MskEtkinlikTarih.TabIndex = 12;
            this.MskEtkinlikTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_YeniEtkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1152, 455);
            this.Controls.Add(this.MskEtkinlikTarih);
            this.Controls.Add(this.btn_İptal);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.RichKatilimci);
            this.Controls.Add(this.Katilimci);
            this.Controls.Add(this.EtkinlikTarih);
            this.Controls.Add(this.RichEtkinlikAciklama);
            this.Controls.Add(this.EtkinlikAciklama);
            this.Controls.Add(this.txt_EtkinlikAd);
            this.Controls.Add(this.EtkinlikAd);
            this.Name = "Frm_YeniEtkinlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Etkinlik";
            this.Load += new System.EventHandler(this.Frm_YeniEtkinlik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtkinlikAd;
        private System.Windows.Forms.TextBox txt_EtkinlikAd;
        private System.Windows.Forms.Label EtkinlikAciklama;
        private System.Windows.Forms.RichTextBox RichEtkinlikAciklama;
        private System.Windows.Forms.Label Katilimci;
        private System.Windows.Forms.RichTextBox RichKatilimci;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_İptal;
        private System.Windows.Forms.Label EtkinlikTarih;
        private System.Windows.Forms.MaskedTextBox MskEtkinlikTarih;
    }
}