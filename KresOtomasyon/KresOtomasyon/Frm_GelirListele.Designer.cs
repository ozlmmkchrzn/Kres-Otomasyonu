
namespace KresOtomasyon
{
    partial class Frm_GelirListele
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
            this.components = new System.ComponentModel.Container();
            this.GelirTarih = new System.Windows.Forms.Label();
            this.RichGelirAciklama = new System.Windows.Forms.RichTextBox();
            this.GelirAciklama = new System.Windows.Forms.Label();
            this.txt_GelirMiktar = new System.Windows.Forms.TextBox();
            this.GelirMiktar = new System.Windows.Forms.Label();
            this.txt_GelirAd = new System.Windows.Forms.TextBox();
            this.GelirAd = new System.Windows.Forms.Label();
            this.txt_GelirID = new System.Windows.Forms.TextBox();
            this.GelirID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gelirIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGelirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet4 = new KresOtomasyon.KresOtomasyonDataSet4();
            this.tbl_GelirlerTableAdapter = new KresOtomasyon.KresOtomasyonDataSet4TableAdapters.Tbl_GelirlerTableAdapter();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.MskGiderTarih = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGelirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // GelirTarih
            // 
            this.GelirTarih.AutoSize = true;
            this.GelirTarih.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirTarih.Location = new System.Drawing.Point(67, 206);
            this.GelirTarih.Name = "GelirTarih";
            this.GelirTarih.Size = new System.Drawing.Size(80, 14);
            this.GelirTarih.TabIndex = 14;
            this.GelirTarih.Text = "Gelir Tarihi:";
            // 
            // RichGelirAciklama
            // 
            this.RichGelirAciklama.Location = new System.Drawing.Point(164, 259);
            this.RichGelirAciklama.Name = "RichGelirAciklama";
            this.RichGelirAciklama.Size = new System.Drawing.Size(219, 169);
            this.RichGelirAciklama.TabIndex = 13;
            this.RichGelirAciklama.Text = "";
            // 
            // GelirAciklama
            // 
            this.GelirAciklama.AutoSize = true;
            this.GelirAciklama.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirAciklama.Location = new System.Drawing.Point(39, 262);
            this.GelirAciklama.Name = "GelirAciklama";
            this.GelirAciklama.Size = new System.Drawing.Size(108, 14);
            this.GelirAciklama.TabIndex = 12;
            this.GelirAciklama.Text = "Gelir Açıklaması:";
            // 
            // txt_GelirMiktar
            // 
            this.txt_GelirMiktar.Location = new System.Drawing.Point(164, 149);
            this.txt_GelirMiktar.Name = "txt_GelirMiktar";
            this.txt_GelirMiktar.Size = new System.Drawing.Size(200, 20);
            this.txt_GelirMiktar.TabIndex = 11;
            // 
            // GelirMiktar
            // 
            this.GelirMiktar.AutoSize = true;
            this.GelirMiktar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirMiktar.Location = new System.Drawing.Point(61, 152);
            this.GelirMiktar.Name = "GelirMiktar";
            this.GelirMiktar.Size = new System.Drawing.Size(86, 14);
            this.GelirMiktar.TabIndex = 10;
            this.GelirMiktar.Text = "Gelir Miktarı:";
            // 
            // txt_GelirAd
            // 
            this.txt_GelirAd.Location = new System.Drawing.Point(164, 94);
            this.txt_GelirAd.Name = "txt_GelirAd";
            this.txt_GelirAd.Size = new System.Drawing.Size(200, 20);
            this.txt_GelirAd.TabIndex = 9;
            // 
            // GelirAd
            // 
            this.GelirAd.AutoSize = true;
            this.GelirAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirAd.Location = new System.Drawing.Point(84, 97);
            this.GelirAd.Name = "GelirAd";
            this.GelirAd.Size = new System.Drawing.Size(63, 14);
            this.GelirAd.TabIndex = 8;
            this.GelirAd.Text = "Gelir Adı:";
            // 
            // txt_GelirID
            // 
            this.txt_GelirID.Enabled = false;
            this.txt_GelirID.Location = new System.Drawing.Point(164, 44);
            this.txt_GelirID.Name = "txt_GelirID";
            this.txt_GelirID.Size = new System.Drawing.Size(200, 20);
            this.txt_GelirID.TabIndex = 17;
            // 
            // GelirID
            // 
            this.GelirID.AutoSize = true;
            this.GelirID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirID.Location = new System.Drawing.Point(92, 47);
            this.GelirID.Name = "GelirID";
            this.GelirID.Size = new System.Drawing.Size(55, 14);
            this.GelirID.TabIndex = 16;
            this.GelirID.Text = "Gelir ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gelirIDDataGridViewTextBoxColumn,
            this.gelirAdDataGridViewTextBoxColumn,
            this.gelirAciklamaDataGridViewTextBoxColumn,
            this.gelirMiktarDataGridViewTextBoxColumn,
            this.gelirTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGelirlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(443, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 384);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gelirIDDataGridViewTextBoxColumn
            // 
            this.gelirIDDataGridViewTextBoxColumn.DataPropertyName = "GelirID";
            this.gelirIDDataGridViewTextBoxColumn.HeaderText = "GelirID";
            this.gelirIDDataGridViewTextBoxColumn.Name = "gelirIDDataGridViewTextBoxColumn";
            this.gelirIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gelirAdDataGridViewTextBoxColumn
            // 
            this.gelirAdDataGridViewTextBoxColumn.DataPropertyName = "GelirAd";
            this.gelirAdDataGridViewTextBoxColumn.HeaderText = "GelirAd";
            this.gelirAdDataGridViewTextBoxColumn.Name = "gelirAdDataGridViewTextBoxColumn";
            // 
            // gelirAciklamaDataGridViewTextBoxColumn
            // 
            this.gelirAciklamaDataGridViewTextBoxColumn.DataPropertyName = "GelirAciklama";
            this.gelirAciklamaDataGridViewTextBoxColumn.HeaderText = "GelirAciklama";
            this.gelirAciklamaDataGridViewTextBoxColumn.Name = "gelirAciklamaDataGridViewTextBoxColumn";
            // 
            // gelirMiktarDataGridViewTextBoxColumn
            // 
            this.gelirMiktarDataGridViewTextBoxColumn.DataPropertyName = "GelirMiktar";
            this.gelirMiktarDataGridViewTextBoxColumn.HeaderText = "GelirMiktar";
            this.gelirMiktarDataGridViewTextBoxColumn.Name = "gelirMiktarDataGridViewTextBoxColumn";
            // 
            // gelirTarihDataGridViewTextBoxColumn
            // 
            this.gelirTarihDataGridViewTextBoxColumn.DataPropertyName = "GelirTarih";
            this.gelirTarihDataGridViewTextBoxColumn.HeaderText = "GelirTarih";
            this.gelirTarihDataGridViewTextBoxColumn.Name = "gelirTarihDataGridViewTextBoxColumn";
            // 
            // tblGelirlerBindingSource
            // 
            this.tblGelirlerBindingSource.DataMember = "Tbl_Gelirler";
            this.tblGelirlerBindingSource.DataSource = this.kresOtomasyonDataSet4;
            // 
            // kresOtomasyonDataSet4
            // 
            this.kresOtomasyonDataSet4.DataSetName = "KresOtomasyonDataSet4";
            this.kresOtomasyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_GelirlerTableAdapter
            // 
            this.tbl_GelirlerTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(332, 457);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 20;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.Location = new System.Drawing.Point(78, 457);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_Duzenle.TabIndex = 19;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // MskGiderTarih
            // 
            this.MskGiderTarih.Location = new System.Drawing.Point(164, 203);
            this.MskGiderTarih.Mask = "00/00/0000";
            this.MskGiderTarih.Name = "MskGiderTarih";
            this.MskGiderTarih.Size = new System.Drawing.Size(200, 20);
            this.MskGiderTarih.TabIndex = 62;
            this.MskGiderTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_GelirListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1010, 506);
            this.Controls.Add(this.MskGiderTarih);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_GelirID);
            this.Controls.Add(this.GelirID);
            this.Controls.Add(this.GelirTarih);
            this.Controls.Add(this.RichGelirAciklama);
            this.Controls.Add(this.GelirAciklama);
            this.Controls.Add(this.txt_GelirMiktar);
            this.Controls.Add(this.GelirMiktar);
            this.Controls.Add(this.txt_GelirAd);
            this.Controls.Add(this.GelirAd);
            this.Name = "Frm_GelirListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Listesi";
            this.Load += new System.EventHandler(this.Frm_GelirListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGelirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GelirTarih;
        private System.Windows.Forms.RichTextBox RichGelirAciklama;
        private System.Windows.Forms.Label GelirAciklama;
        private System.Windows.Forms.TextBox txt_GelirMiktar;
        private System.Windows.Forms.Label GelirMiktar;
        private System.Windows.Forms.TextBox txt_GelirAd;
        private System.Windows.Forms.Label GelirAd;
        private System.Windows.Forms.TextBox txt_GelirID;
        private System.Windows.Forms.Label GelirID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KresOtomasyonDataSet4 kresOtomasyonDataSet4;
        private System.Windows.Forms.BindingSource tblGelirlerBindingSource;
        private KresOtomasyonDataSet4TableAdapters.Tbl_GelirlerTableAdapter tbl_GelirlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.MaskedTextBox MskGiderTarih;
    }
}