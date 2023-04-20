
namespace KresOtomasyon
{
    partial class Frm_GiderListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.giderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGiderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet3 = new KresOtomasyon.KresOtomasyonDataSet3();
            this.tbl_GiderlerTableAdapter = new KresOtomasyon.KresOtomasyonDataSet3TableAdapters.Tbl_GiderlerTableAdapter();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.GiderTarih = new System.Windows.Forms.Label();
            this.RichGiderAciklama = new System.Windows.Forms.RichTextBox();
            this.GiderAciklama = new System.Windows.Forms.Label();
            this.txt_GiderMiktar = new System.Windows.Forms.TextBox();
            this.GiderMiktar = new System.Windows.Forms.Label();
            this.txt_GiderAd = new System.Windows.Forms.TextBox();
            this.GiderAd = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_GiderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskGiderTarih = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGiderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giderIDDataGridViewTextBoxColumn,
            this.giderAdDataGridViewTextBoxColumn,
            this.giderAciklamaDataGridViewTextBoxColumn,
            this.giderMiktarDataGridViewTextBoxColumn,
            this.giderTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGiderlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(488, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // giderIDDataGridViewTextBoxColumn
            // 
            this.giderIDDataGridViewTextBoxColumn.DataPropertyName = "GiderID";
            this.giderIDDataGridViewTextBoxColumn.HeaderText = "GiderID";
            this.giderIDDataGridViewTextBoxColumn.Name = "giderIDDataGridViewTextBoxColumn";
            this.giderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giderAdDataGridViewTextBoxColumn
            // 
            this.giderAdDataGridViewTextBoxColumn.DataPropertyName = "GiderAd";
            this.giderAdDataGridViewTextBoxColumn.HeaderText = "GiderAd";
            this.giderAdDataGridViewTextBoxColumn.Name = "giderAdDataGridViewTextBoxColumn";
            // 
            // giderAciklamaDataGridViewTextBoxColumn
            // 
            this.giderAciklamaDataGridViewTextBoxColumn.DataPropertyName = "GiderAciklama";
            this.giderAciklamaDataGridViewTextBoxColumn.HeaderText = "GiderAciklama";
            this.giderAciklamaDataGridViewTextBoxColumn.Name = "giderAciklamaDataGridViewTextBoxColumn";
            // 
            // giderMiktarDataGridViewTextBoxColumn
            // 
            this.giderMiktarDataGridViewTextBoxColumn.DataPropertyName = "GiderMiktar";
            this.giderMiktarDataGridViewTextBoxColumn.HeaderText = "GiderMiktar";
            this.giderMiktarDataGridViewTextBoxColumn.Name = "giderMiktarDataGridViewTextBoxColumn";
            // 
            // giderTarihDataGridViewTextBoxColumn
            // 
            this.giderTarihDataGridViewTextBoxColumn.DataPropertyName = "GiderTarih";
            this.giderTarihDataGridViewTextBoxColumn.HeaderText = "GiderTarih";
            this.giderTarihDataGridViewTextBoxColumn.Name = "giderTarihDataGridViewTextBoxColumn";
            // 
            // tblGiderlerBindingSource
            // 
            this.tblGiderlerBindingSource.DataMember = "Tbl_Giderler";
            this.tblGiderlerBindingSource.DataSource = this.kresOtomasyonDataSet3;
            // 
            // kresOtomasyonDataSet3
            // 
            this.kresOtomasyonDataSet3.DataSetName = "KresOtomasyonDataSet3";
            this.kresOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_GiderlerTableAdapter
            // 
            this.tbl_GiderlerTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.Location = new System.Drawing.Point(84, 410);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_Duzenle.TabIndex = 1;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // GiderTarih
            // 
            this.GiderTarih.AutoSize = true;
            this.GiderTarih.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderTarih.Location = new System.Drawing.Point(41, 192);
            this.GiderTarih.Name = "GiderTarih";
            this.GiderTarih.Size = new System.Drawing.Size(83, 14);
            this.GiderTarih.TabIndex = 16;
            this.GiderTarih.Text = "Gider Tarihi:";
            // 
            // RichGiderAciklama
            // 
            this.RichGiderAciklama.Location = new System.Drawing.Point(140, 245);
            this.RichGiderAciklama.Name = "RichGiderAciklama";
            this.RichGiderAciklama.Size = new System.Drawing.Size(285, 146);
            this.RichGiderAciklama.TabIndex = 15;
            this.RichGiderAciklama.Text = "";
            // 
            // GiderAciklama
            // 
            this.GiderAciklama.AutoSize = true;
            this.GiderAciklama.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderAciklama.Location = new System.Drawing.Point(10, 248);
            this.GiderAciklama.Name = "GiderAciklama";
            this.GiderAciklama.Size = new System.Drawing.Size(111, 14);
            this.GiderAciklama.TabIndex = 14;
            this.GiderAciklama.Text = "Gider Açıklaması:";
            // 
            // txt_GiderMiktar
            // 
            this.txt_GiderMiktar.Location = new System.Drawing.Point(140, 140);
            this.txt_GiderMiktar.Name = "txt_GiderMiktar";
            this.txt_GiderMiktar.Size = new System.Drawing.Size(200, 20);
            this.txt_GiderMiktar.TabIndex = 13;
            // 
            // GiderMiktar
            // 
            this.GiderMiktar.AutoSize = true;
            this.GiderMiktar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderMiktar.Location = new System.Drawing.Point(35, 143);
            this.GiderMiktar.Name = "GiderMiktar";
            this.GiderMiktar.Size = new System.Drawing.Size(89, 14);
            this.GiderMiktar.TabIndex = 12;
            this.GiderMiktar.Text = "Gider Miktarı:";
            // 
            // txt_GiderAd
            // 
            this.txt_GiderAd.Location = new System.Drawing.Point(140, 92);
            this.txt_GiderAd.Name = "txt_GiderAd";
            this.txt_GiderAd.Size = new System.Drawing.Size(200, 20);
            this.txt_GiderAd.TabIndex = 11;
            // 
            // GiderAd
            // 
            this.GiderAd.AutoSize = true;
            this.GiderAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderAd.Location = new System.Drawing.Point(58, 95);
            this.GiderAd.Name = "GiderAd";
            this.GiderAd.Size = new System.Drawing.Size(66, 14);
            this.GiderAd.TabIndex = 10;
            this.GiderAd.Text = "Gider Adı:";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(338, 410);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txt_GiderID
            // 
            this.txt_GiderID.Enabled = false;
            this.txt_GiderID.Location = new System.Drawing.Point(140, 46);
            this.txt_GiderID.Name = "txt_GiderID";
            this.txt_GiderID.Size = new System.Drawing.Size(200, 20);
            this.txt_GiderID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gider Adı:";
            // 
            // MskGiderTarih
            // 
            this.MskGiderTarih.Location = new System.Drawing.Point(140, 189);
            this.MskGiderTarih.Mask = "00/00/0000";
            this.MskGiderTarih.Name = "MskGiderTarih";
            this.MskGiderTarih.Size = new System.Drawing.Size(200, 20);
            this.MskGiderTarih.TabIndex = 21;
            this.MskGiderTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_GiderListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1070, 474);
            this.Controls.Add(this.MskGiderTarih);
            this.Controls.Add(this.txt_GiderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.GiderTarih);
            this.Controls.Add(this.RichGiderAciklama);
            this.Controls.Add(this.GiderAciklama);
            this.Controls.Add(this.txt_GiderMiktar);
            this.Controls.Add(this.GiderMiktar);
            this.Controls.Add(this.txt_GiderAd);
            this.Controls.Add(this.GiderAd);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_GiderListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler Listesi";
            this.Load += new System.EventHandler(this.Frm_GiderListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGiderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KresOtomasyonDataSet3 kresOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource tblGiderlerBindingSource;
        private KresOtomasyonDataSet3TableAdapters.Tbl_GiderlerTableAdapter tbl_GiderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Label GiderTarih;
        private System.Windows.Forms.RichTextBox RichGiderAciklama;
        private System.Windows.Forms.Label GiderAciklama;
        private System.Windows.Forms.TextBox txt_GiderMiktar;
        private System.Windows.Forms.Label GiderMiktar;
        private System.Windows.Forms.TextBox txt_GiderAd;
        private System.Windows.Forms.Label GiderAd;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_GiderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskGiderTarih;
    }
}