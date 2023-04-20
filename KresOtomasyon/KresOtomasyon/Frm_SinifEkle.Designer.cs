
namespace KresOtomasyon
{
    partial class Frm_SinifEkle
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
            this.EkleSinifAd = new System.Windows.Forms.Label();
            this.txt_EkleSinifAd = new System.Windows.Forms.TextBox();
            this.txt_EkleSinifYas = new System.Windows.Forms.TextBox();
            this.EkleSinifYas = new System.Windows.Forms.Label();
            this.txt_EkleSinifKapasite = new System.Windows.Forms.TextBox();
            this.EkleSinifKapasite = new System.Windows.Forms.Label();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EkleSinifAd
            // 
            this.EkleSinifAd.AutoSize = true;
            this.EkleSinifAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleSinifAd.Location = new System.Drawing.Point(113, 98);
            this.EkleSinifAd.Name = "EkleSinifAd";
            this.EkleSinifAd.Size = new System.Drawing.Size(61, 14);
            this.EkleSinifAd.TabIndex = 0;
            this.EkleSinifAd.Text = "Sınıf Adı:";
            // 
            // txt_EkleSinifAd
            // 
            this.txt_EkleSinifAd.Location = new System.Drawing.Point(195, 95);
            this.txt_EkleSinifAd.Name = "txt_EkleSinifAd";
            this.txt_EkleSinifAd.Size = new System.Drawing.Size(154, 20);
            this.txt_EkleSinifAd.TabIndex = 1;
            // 
            // txt_EkleSinifYas
            // 
            this.txt_EkleSinifYas.Location = new System.Drawing.Point(195, 140);
            this.txt_EkleSinifYas.Name = "txt_EkleSinifYas";
            this.txt_EkleSinifYas.Size = new System.Drawing.Size(154, 20);
            this.txt_EkleSinifYas.TabIndex = 3;
            // 
            // EkleSinifYas
            // 
            this.EkleSinifYas.AutoSize = true;
            this.EkleSinifYas.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleSinifYas.Location = new System.Drawing.Point(99, 143);
            this.EkleSinifYas.Name = "EkleSinifYas";
            this.EkleSinifYas.Size = new System.Drawing.Size(75, 14);
            this.EkleSinifYas.TabIndex = 2;
            this.EkleSinifYas.Text = "Yaş Aralığı:";
            // 
            // txt_EkleSinifKapasite
            // 
            this.txt_EkleSinifKapasite.Location = new System.Drawing.Point(195, 185);
            this.txt_EkleSinifKapasite.Name = "txt_EkleSinifKapasite";
            this.txt_EkleSinifKapasite.Size = new System.Drawing.Size(154, 20);
            this.txt_EkleSinifKapasite.TabIndex = 5;
            // 
            // EkleSinifKapasite
            // 
            this.EkleSinifKapasite.AutoSize = true;
            this.EkleSinifKapasite.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleSinifKapasite.Location = new System.Drawing.Point(75, 185);
            this.EkleSinifKapasite.Name = "EkleSinifKapasite";
            this.EkleSinifKapasite.Size = new System.Drawing.Size(99, 14);
            this.EkleSinifKapasite.TabIndex = 4;
            this.EkleSinifKapasite.Text = "Sınıf Kapasitesi:";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cikis.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(71, 296);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(75, 26);
            this.btn_Cikis.TabIndex = 6;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(373, 296);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 26);
            this.btn_Kaydet.TabIndex = 7;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(190, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yeni Sınıf";
            // 
            // Frm_SinifEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(521, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.txt_EkleSinifKapasite);
            this.Controls.Add(this.EkleSinifKapasite);
            this.Controls.Add(this.txt_EkleSinifYas);
            this.Controls.Add(this.EkleSinifYas);
            this.Controls.Add(this.txt_EkleSinifAd);
            this.Controls.Add(this.EkleSinifAd);
            this.Name = "Frm_SinifEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Sınıf Ekle";
            this.Load += new System.EventHandler(this.Frm_SinifEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EkleSinifAd;
        private System.Windows.Forms.TextBox txt_EkleSinifAd;
        private System.Windows.Forms.TextBox txt_EkleSinifYas;
        private System.Windows.Forms.Label EkleSinifYas;
        private System.Windows.Forms.TextBox txt_EkleSinifKapasite;
        private System.Windows.Forms.Label EkleSinifKapasite;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label1;
    }
}