
namespace KresOtomasyon
{
    partial class Frm_Giris
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
            this.KullaniciAdi = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.txt_KullaniciAd = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.Baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.AutoSize = true;
            this.KullaniciAdi.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdi.Location = new System.Drawing.Point(208, 176);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(132, 24);
            this.KullaniciAdi.TabIndex = 0;
            this.KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre.Location = new System.Drawing.Point(282, 220);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(58, 24);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Şifre:";
            // 
            // txt_KullaniciAd
            // 
            this.txt_KullaniciAd.Location = new System.Drawing.Point(379, 176);
            this.txt_KullaniciAd.Name = "txt_KullaniciAd";
            this.txt_KullaniciAd.Size = new System.Drawing.Size(153, 20);
            this.txt_KullaniciAd.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(379, 220);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(153, 20);
            this.txt_Sifre.TabIndex = 3;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(351, 323);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(75, 34);
            this.btn_Giris.TabIndex = 4;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Baslik.Location = new System.Drawing.Point(152, 69);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(452, 34);
            this.Baslik.TabIndex = 6;
            this.Baslik.Text = "KIZILYER GÜNDÜZ BAKIM EVİ";
            // 
            // Frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(766, 426);
            this.Controls.Add(this.Baslik);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAd);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullaniciAdi);
            this.Name = "Frm_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreş Takip Programı";
            this.Load += new System.EventHandler(this.Frm_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciAdi;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAd;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label Baslik;
    }
}