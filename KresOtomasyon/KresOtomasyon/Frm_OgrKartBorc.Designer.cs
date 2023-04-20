
namespace KresOtomasyon
{
    partial class Frm_OgrKartBorc
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
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.txt_ToplamBorc = new System.Windows.Forms.TextBox();
            this.ToplamBorc = new System.Windows.Forms.Label();
            this.txt_Taksit = new System.Windows.Forms.TextBox();
            this.TaksitSayisi = new System.Windows.Forms.Label();
            this.BorcID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.Location = new System.Drawing.Point(374, 197);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_Duzenle.TabIndex = 11;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(126, 197);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri.TabIndex = 10;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // txt_ToplamBorc
            // 
            this.txt_ToplamBorc.Location = new System.Drawing.Point(234, 112);
            this.txt_ToplamBorc.Name = "txt_ToplamBorc";
            this.txt_ToplamBorc.Size = new System.Drawing.Size(149, 20);
            this.txt_ToplamBorc.TabIndex = 9;
            // 
            // ToplamBorc
            // 
            this.ToplamBorc.AutoSize = true;
            this.ToplamBorc.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamBorc.Location = new System.Drawing.Point(117, 115);
            this.ToplamBorc.Name = "ToplamBorc";
            this.ToplamBorc.Size = new System.Drawing.Size(97, 14);
            this.ToplamBorc.TabIndex = 8;
            this.ToplamBorc.Text = "Toplam Miktar:";
            // 
            // txt_Taksit
            // 
            this.txt_Taksit.Location = new System.Drawing.Point(234, 71);
            this.txt_Taksit.Name = "txt_Taksit";
            this.txt_Taksit.Size = new System.Drawing.Size(149, 20);
            this.txt_Taksit.TabIndex = 7;
            // 
            // TaksitSayisi
            // 
            this.TaksitSayisi.AutoSize = true;
            this.TaksitSayisi.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TaksitSayisi.Location = new System.Drawing.Point(129, 74);
            this.TaksitSayisi.Name = "TaksitSayisi";
            this.TaksitSayisi.Size = new System.Drawing.Size(85, 14);
            this.TaksitSayisi.TabIndex = 6;
            this.TaksitSayisi.Text = "Taksit Sayısı:";
            // 
            // BorcID
            // 
            this.BorcID.AutoSize = true;
            this.BorcID.Location = new System.Drawing.Point(38, 119);
            this.BorcID.Name = "BorcID";
            this.BorcID.Size = new System.Drawing.Size(40, 13);
            this.BorcID.TabIndex = 12;
            this.BorcID.Text = "BorcID";
            this.BorcID.Visible = false;
            // 
            // Frm_OgrKartBorc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(543, 287);
            this.Controls.Add(this.BorcID);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.txt_ToplamBorc);
            this.Controls.Add(this.ToplamBorc);
            this.Controls.Add(this.txt_Taksit);
            this.Controls.Add(this.TaksitSayisi);
            this.Name = "Frm_OgrKartBorc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Borç Kartı";
            this.Load += new System.EventHandler(this.Frm_OgrKartBorc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.TextBox txt_ToplamBorc;
        private System.Windows.Forms.Label ToplamBorc;
        private System.Windows.Forms.TextBox txt_Taksit;
        private System.Windows.Forms.Label TaksitSayisi;
        private System.Windows.Forms.Label BorcID;
    }
}