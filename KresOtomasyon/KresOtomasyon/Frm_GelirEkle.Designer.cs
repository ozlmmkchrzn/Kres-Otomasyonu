
namespace KresOtomasyon
{
    partial class Frm_GelirEkle
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
            this.GelirAd = new System.Windows.Forms.Label();
            this.txt_GelirAd = new System.Windows.Forms.TextBox();
            this.txt_GelirMiktar = new System.Windows.Forms.TextBox();
            this.GelirMiktar = new System.Windows.Forms.Label();
            this.GelirAciklama = new System.Windows.Forms.Label();
            this.RichGelirAciklama = new System.Windows.Forms.RichTextBox();
            this.GelirTarih = new System.Windows.Forms.Label();
            this.btn_Iptal = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.MskGelirTarih = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // GelirAd
            // 
            this.GelirAd.AutoSize = true;
            this.GelirAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirAd.Location = new System.Drawing.Point(68, 48);
            this.GelirAd.Name = "GelirAd";
            this.GelirAd.Size = new System.Drawing.Size(63, 14);
            this.GelirAd.TabIndex = 0;
            this.GelirAd.Text = "Gelir Adı:";
            // 
            // txt_GelirAd
            // 
            this.txt_GelirAd.Location = new System.Drawing.Point(148, 45);
            this.txt_GelirAd.Name = "txt_GelirAd";
            this.txt_GelirAd.Size = new System.Drawing.Size(200, 20);
            this.txt_GelirAd.TabIndex = 1;
            // 
            // txt_GelirMiktar
            // 
            this.txt_GelirMiktar.Location = new System.Drawing.Point(148, 100);
            this.txt_GelirMiktar.Name = "txt_GelirMiktar";
            this.txt_GelirMiktar.Size = new System.Drawing.Size(200, 20);
            this.txt_GelirMiktar.TabIndex = 3;
            // 
            // GelirMiktar
            // 
            this.GelirMiktar.AutoSize = true;
            this.GelirMiktar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirMiktar.Location = new System.Drawing.Point(45, 103);
            this.GelirMiktar.Name = "GelirMiktar";
            this.GelirMiktar.Size = new System.Drawing.Size(86, 14);
            this.GelirMiktar.TabIndex = 2;
            this.GelirMiktar.Text = "Gelir Miktarı:";
            // 
            // GelirAciklama
            // 
            this.GelirAciklama.AutoSize = true;
            this.GelirAciklama.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirAciklama.Location = new System.Drawing.Point(424, 48);
            this.GelirAciklama.Name = "GelirAciklama";
            this.GelirAciklama.Size = new System.Drawing.Size(108, 14);
            this.GelirAciklama.TabIndex = 4;
            this.GelirAciklama.Text = "Gelir Açıklaması:";
            // 
            // RichGelirAciklama
            // 
            this.RichGelirAciklama.Location = new System.Drawing.Point(557, 45);
            this.RichGelirAciklama.Name = "RichGelirAciklama";
            this.RichGelirAciklama.Size = new System.Drawing.Size(219, 169);
            this.RichGelirAciklama.TabIndex = 5;
            this.RichGelirAciklama.Text = "";
            // 
            // GelirTarih
            // 
            this.GelirTarih.AutoSize = true;
            this.GelirTarih.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirTarih.Location = new System.Drawing.Point(51, 157);
            this.GelirTarih.Name = "GelirTarih";
            this.GelirTarih.Size = new System.Drawing.Size(80, 14);
            this.GelirTarih.TabIndex = 6;
            this.GelirTarih.Text = "Gelir Tarihi:";
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Iptal.Location = new System.Drawing.Point(108, 271);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_Iptal.TabIndex = 8;
            this.btn_Iptal.Text = "İptal";
            this.btn_Iptal.UseVisualStyleBackColor = true;
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(584, 271);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 9;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // MskGelirTarih
            // 
            this.MskGelirTarih.Location = new System.Drawing.Point(148, 154);
            this.MskGelirTarih.Mask = "00/00/0000";
            this.MskGelirTarih.Name = "MskGelirTarih";
            this.MskGelirTarih.Size = new System.Drawing.Size(200, 20);
            this.MskGelirTarih.TabIndex = 62;
            this.MskGelirTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_GelirEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(827, 356);
            this.Controls.Add(this.MskGelirTarih);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.GelirTarih);
            this.Controls.Add(this.RichGelirAciklama);
            this.Controls.Add(this.GelirAciklama);
            this.Controls.Add(this.txt_GelirMiktar);
            this.Controls.Add(this.GelirMiktar);
            this.Controls.Add(this.txt_GelirAd);
            this.Controls.Add(this.GelirAd);
            this.Name = "Frm_GelirEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GelirAd;
        private System.Windows.Forms.TextBox txt_GelirAd;
        private System.Windows.Forms.TextBox txt_GelirMiktar;
        private System.Windows.Forms.Label GelirMiktar;
        private System.Windows.Forms.Label GelirAciklama;
        private System.Windows.Forms.RichTextBox RichGelirAciklama;
        private System.Windows.Forms.Label GelirTarih;
        private System.Windows.Forms.Button btn_Iptal;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.MaskedTextBox MskGelirTarih;
    }
}