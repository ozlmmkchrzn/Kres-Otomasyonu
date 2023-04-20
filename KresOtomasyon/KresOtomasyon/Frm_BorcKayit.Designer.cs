
namespace KresOtomasyon
{
    partial class Frm_BorcKayit
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
            this.TaksitSayisi = new System.Windows.Forms.Label();
            this.txt_Taksit = new System.Windows.Forms.TextBox();
            this.txt_ToplamBorc = new System.Windows.Forms.TextBox();
            this.ToplamBorc = new System.Windows.Forms.Label();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.BorcID = new System.Windows.Forms.Label();
            this.BorcOgrID = new System.Windows.Forms.Label();
            this.ogrsoyad = new System.Windows.Forms.Label();
            this.ograd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaksitSayisi
            // 
            this.TaksitSayisi.AutoSize = true;
            this.TaksitSayisi.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TaksitSayisi.Location = new System.Drawing.Point(139, 58);
            this.TaksitSayisi.Name = "TaksitSayisi";
            this.TaksitSayisi.Size = new System.Drawing.Size(85, 14);
            this.TaksitSayisi.TabIndex = 0;
            this.TaksitSayisi.Text = "Taksit Sayısı:";
            // 
            // txt_Taksit
            // 
            this.txt_Taksit.Location = new System.Drawing.Point(244, 55);
            this.txt_Taksit.Name = "txt_Taksit";
            this.txt_Taksit.Size = new System.Drawing.Size(149, 20);
            this.txt_Taksit.TabIndex = 1;
            // 
            // txt_ToplamBorc
            // 
            this.txt_ToplamBorc.Location = new System.Drawing.Point(244, 96);
            this.txt_ToplamBorc.Name = "txt_ToplamBorc";
            this.txt_ToplamBorc.Size = new System.Drawing.Size(149, 20);
            this.txt_ToplamBorc.TabIndex = 3;
            // 
            // ToplamBorc
            // 
            this.ToplamBorc.AutoSize = true;
            this.ToplamBorc.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamBorc.Location = new System.Drawing.Point(127, 99);
            this.ToplamBorc.Name = "ToplamBorc";
            this.ToplamBorc.Size = new System.Drawing.Size(97, 14);
            this.ToplamBorc.TabIndex = 2;
            this.ToplamBorc.Text = "Toplam Miktar:";
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(105, 178);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri.TabIndex = 4;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(353, 178);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 5;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // BorcID
            // 
            this.BorcID.AutoSize = true;
            this.BorcID.Location = new System.Drawing.Point(28, 33);
            this.BorcID.Name = "BorcID";
            this.BorcID.Size = new System.Drawing.Size(40, 13);
            this.BorcID.TabIndex = 6;
            this.BorcID.Text = "BorcID";
            this.BorcID.Visible = false;
            // 
            // BorcOgrID
            // 
            this.BorcOgrID.AutoSize = true;
            this.BorcOgrID.Location = new System.Drawing.Point(31, 72);
            this.BorcOgrID.Name = "BorcOgrID";
            this.BorcOgrID.Size = new System.Drawing.Size(57, 13);
            this.BorcOgrID.TabIndex = 7;
            this.BorcOgrID.Text = "BorcOgrID";
            this.BorcOgrID.Visible = false;
            // 
            // ogrsoyad
            // 
            this.ogrsoyad.AutoSize = true;
            this.ogrsoyad.Location = new System.Drawing.Point(454, 100);
            this.ogrsoyad.Name = "ogrsoyad";
            this.ogrsoyad.Size = new System.Drawing.Size(50, 13);
            this.ogrsoyad.TabIndex = 9;
            this.ogrsoyad.Text = "ogrsoyad";
            this.ogrsoyad.Visible = false;
            // 
            // ograd
            // 
            this.ograd.AutoSize = true;
            this.ograd.Location = new System.Drawing.Point(451, 61);
            this.ograd.Name = "ograd";
            this.ograd.Size = new System.Drawing.Size(34, 13);
            this.ograd.TabIndex = 8;
            this.ograd.Text = "ograd";
            this.ograd.Visible = false;
            // 
            // Frm_BorcKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 255);
            this.Controls.Add(this.ogrsoyad);
            this.Controls.Add(this.ograd);
            this.Controls.Add(this.BorcOgrID);
            this.Controls.Add(this.BorcID);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.txt_ToplamBorc);
            this.Controls.Add(this.ToplamBorc);
            this.Controls.Add(this.txt_Taksit);
            this.Controls.Add(this.TaksitSayisi);
            this.Name = "Frm_BorcKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borç Kayıt";
            this.Load += new System.EventHandler(this.Frm_BorcKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaksitSayisi;
        private System.Windows.Forms.TextBox txt_Taksit;
        private System.Windows.Forms.TextBox txt_ToplamBorc;
        private System.Windows.Forms.Label ToplamBorc;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label BorcID;
        private System.Windows.Forms.Label BorcOgrID;
        private System.Windows.Forms.Label ogrsoyad;
        private System.Windows.Forms.Label ograd;
    }
}