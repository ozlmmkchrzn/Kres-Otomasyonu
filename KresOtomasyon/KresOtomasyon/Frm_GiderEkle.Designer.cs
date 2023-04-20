
namespace KresOtomasyon
{
    partial class Frm_GiderEkle
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
            this.GiderAd = new System.Windows.Forms.Label();
            this.txt_GiderAd = new System.Windows.Forms.TextBox();
            this.txt_GiderMiktar = new System.Windows.Forms.TextBox();
            this.GiderMiktar = new System.Windows.Forms.Label();
            this.GiderAciklama = new System.Windows.Forms.Label();
            this.RichGiderAciklama = new System.Windows.Forms.RichTextBox();
            this.btn_İptal = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.GiderTarih = new System.Windows.Forms.Label();
            this.MskGiderTarih = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // GiderAd
            // 
            this.GiderAd.AutoSize = true;
            this.GiderAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderAd.Location = new System.Drawing.Point(79, 67);
            this.GiderAd.Name = "GiderAd";
            this.GiderAd.Size = new System.Drawing.Size(66, 14);
            this.GiderAd.TabIndex = 0;
            this.GiderAd.Text = "Gider Adı:";
            // 
            // txt_GiderAd
            // 
            this.txt_GiderAd.Location = new System.Drawing.Point(161, 64);
            this.txt_GiderAd.Name = "txt_GiderAd";
            this.txt_GiderAd.Size = new System.Drawing.Size(200, 20);
            this.txt_GiderAd.TabIndex = 1;
            // 
            // txt_GiderMiktar
            // 
            this.txt_GiderMiktar.Location = new System.Drawing.Point(161, 121);
            this.txt_GiderMiktar.Name = "txt_GiderMiktar";
            this.txt_GiderMiktar.Size = new System.Drawing.Size(200, 20);
            this.txt_GiderMiktar.TabIndex = 3;
            // 
            // GiderMiktar
            // 
            this.GiderMiktar.AutoSize = true;
            this.GiderMiktar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderMiktar.Location = new System.Drawing.Point(56, 124);
            this.GiderMiktar.Name = "GiderMiktar";
            this.GiderMiktar.Size = new System.Drawing.Size(89, 14);
            this.GiderMiktar.TabIndex = 2;
            this.GiderMiktar.Text = "Gider Miktarı:";
            // 
            // GiderAciklama
            // 
            this.GiderAciklama.AutoSize = true;
            this.GiderAciklama.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderAciklama.Location = new System.Drawing.Point(452, 67);
            this.GiderAciklama.Name = "GiderAciklama";
            this.GiderAciklama.Size = new System.Drawing.Size(111, 14);
            this.GiderAciklama.TabIndex = 4;
            this.GiderAciklama.Text = "Gider Açıklaması:";
            // 
            // RichGiderAciklama
            // 
            this.RichGiderAciklama.Location = new System.Drawing.Point(582, 64);
            this.RichGiderAciklama.Name = "RichGiderAciklama";
            this.RichGiderAciklama.Size = new System.Drawing.Size(285, 146);
            this.RichGiderAciklama.TabIndex = 5;
            this.RichGiderAciklama.Text = "";
            // 
            // btn_İptal
            // 
            this.btn_İptal.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_İptal.Location = new System.Drawing.Point(141, 300);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.Size = new System.Drawing.Size(75, 23);
            this.btn_İptal.TabIndex = 6;
            this.btn_İptal.Text = "İptal";
            this.btn_İptal.UseVisualStyleBackColor = true;
            this.btn_İptal.Click += new System.EventHandler(this.btn_İptal_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(711, 300);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 7;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // GiderTarih
            // 
            this.GiderTarih.AutoSize = true;
            this.GiderTarih.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderTarih.Location = new System.Drawing.Point(62, 177);
            this.GiderTarih.Name = "GiderTarih";
            this.GiderTarih.Size = new System.Drawing.Size(83, 14);
            this.GiderTarih.TabIndex = 8;
            this.GiderTarih.Text = "Gider Tarihi:";
            // 
            // MskGiderTarih
            // 
            this.MskGiderTarih.Location = new System.Drawing.Point(161, 174);
            this.MskGiderTarih.Mask = "00/00/0000";
            this.MskGiderTarih.Name = "MskGiderTarih";
            this.MskGiderTarih.Size = new System.Drawing.Size(200, 20);
            this.MskGiderTarih.TabIndex = 9;
            this.MskGiderTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_GiderEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(913, 395);
            this.Controls.Add(this.MskGiderTarih);
            this.Controls.Add(this.GiderTarih);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_İptal);
            this.Controls.Add(this.RichGiderAciklama);
            this.Controls.Add(this.GiderAciklama);
            this.Controls.Add(this.txt_GiderMiktar);
            this.Controls.Add(this.GiderMiktar);
            this.Controls.Add(this.txt_GiderAd);
            this.Controls.Add(this.GiderAd);
            this.Name = "Frm_GiderEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Ekle";
            this.Load += new System.EventHandler(this.Frm_GiderEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GiderAd;
        private System.Windows.Forms.TextBox txt_GiderAd;
        private System.Windows.Forms.TextBox txt_GiderMiktar;
        private System.Windows.Forms.Label GiderMiktar;
        private System.Windows.Forms.Label GiderAciklama;
        private System.Windows.Forms.RichTextBox RichGiderAciklama;
        private System.Windows.Forms.Button btn_İptal;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label GiderTarih;
        private System.Windows.Forms.MaskedTextBox MskGiderTarih;
    }
}