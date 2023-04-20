
namespace KresOtomasyon
{
    partial class Frm_KullaniciEkle
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
            this.KullaniciAd = new System.Windows.Forms.Label();
            this.txt_KullaniciAd = new System.Windows.Forms.TextBox();
            this.txt_KullaniciSifre = new System.Windows.Forms.TextBox();
            this.KullaniciSifre = new System.Windows.Forms.Label();
            this.txt_SifreTekrar = new System.Windows.Forms.TextBox();
            this.SifreTekrar = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciAd
            // 
            this.KullaniciAd.AutoSize = true;
            this.KullaniciAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAd.Location = new System.Drawing.Point(123, 58);
            this.KullaniciAd.Name = "KullaniciAd";
            this.KullaniciAd.Size = new System.Drawing.Size(87, 14);
            this.KullaniciAd.TabIndex = 0;
            this.KullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // txt_KullaniciAd
            // 
            this.txt_KullaniciAd.Location = new System.Drawing.Point(236, 55);
            this.txt_KullaniciAd.Name = "txt_KullaniciAd";
            this.txt_KullaniciAd.Size = new System.Drawing.Size(138, 20);
            this.txt_KullaniciAd.TabIndex = 1;
            // 
            // txt_KullaniciSifre
            // 
            this.txt_KullaniciSifre.Location = new System.Drawing.Point(236, 95);
            this.txt_KullaniciSifre.Name = "txt_KullaniciSifre";
            this.txt_KullaniciSifre.Size = new System.Drawing.Size(138, 20);
            this.txt_KullaniciSifre.TabIndex = 3;
            this.txt_KullaniciSifre.TextChanged += new System.EventHandler(this.txt_KullaniciSifre_TextChanged);
            // 
            // KullaniciSifre
            // 
            this.KullaniciSifre.AutoSize = true;
            this.KullaniciSifre.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciSifre.Location = new System.Drawing.Point(172, 101);
            this.KullaniciSifre.Name = "KullaniciSifre";
            this.KullaniciSifre.Size = new System.Drawing.Size(38, 14);
            this.KullaniciSifre.TabIndex = 2;
            this.KullaniciSifre.Text = "Şifre:";
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Location = new System.Drawing.Point(236, 145);
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.Size = new System.Drawing.Size(138, 20);
            this.txt_SifreTekrar.TabIndex = 5;
            // 
            // SifreTekrar
            // 
            this.SifreTekrar.AutoSize = true;
            this.SifreTekrar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTekrar.Location = new System.Drawing.Point(129, 148);
            this.SifreTekrar.Name = "SifreTekrar";
            this.SifreTekrar.Size = new System.Drawing.Size(81, 14);
            this.SifreTekrar.TabIndex = 4;
            this.SifreTekrar.Text = "Şifre Tekrar:";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(224, 210);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 6;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // Frm_KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(521, 295);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_SifreTekrar);
            this.Controls.Add(this.SifreTekrar);
            this.Controls.Add(this.txt_KullaniciSifre);
            this.Controls.Add(this.KullaniciSifre);
            this.Controls.Add(this.txt_KullaniciAd);
            this.Controls.Add(this.KullaniciAd);
            this.Name = "Frm_KullaniciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.Frm_KullaniciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciAd;
        private System.Windows.Forms.TextBox txt_KullaniciAd;
        private System.Windows.Forms.TextBox txt_KullaniciSifre;
        private System.Windows.Forms.Label KullaniciSifre;
        private System.Windows.Forms.TextBox txt_SifreTekrar;
        private System.Windows.Forms.Label SifreTekrar;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}