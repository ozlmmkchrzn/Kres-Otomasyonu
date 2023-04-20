
namespace KresOtomasyon
{
    partial class Frm_EtkinlikListele
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
            this.RichKatilimci = new System.Windows.Forms.RichTextBox();
            this.Katilimci = new System.Windows.Forms.Label();
            this.EtkinlikTarih = new System.Windows.Forms.Label();
            this.RichEtkinlikAciklama = new System.Windows.Forms.RichTextBox();
            this.EtkinlikAciklama = new System.Windows.Forms.Label();
            this.txt_EtkinlikAd = new System.Windows.Forms.TextBox();
            this.EtkinlikAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etkinlikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikKatilimciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEtkinlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet2 = new KresOtomasyon.KresOtomasyonDataSet2();
            this.tbl_EtkinlikTableAdapter = new KresOtomasyon.KresOtomasyonDataSet2TableAdapters.Tbl_EtkinlikTableAdapter();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.txt_EtkinlikID = new System.Windows.Forms.TextBox();
            this.EtkinlikID = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.MskEtkinlikTarih = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEtkinlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // RichKatilimci
            // 
            this.RichKatilimci.Location = new System.Drawing.Point(187, 189);
            this.RichKatilimci.Name = "RichKatilimci";
            this.RichKatilimci.Size = new System.Drawing.Size(234, 185);
            this.RichKatilimci.TabIndex = 19;
            this.RichKatilimci.Text = "";
            // 
            // Katilimci
            // 
            this.Katilimci.AutoSize = true;
            this.Katilimci.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Katilimci.Location = new System.Drawing.Point(76, 192);
            this.Katilimci.Name = "Katilimci";
            this.Katilimci.Size = new System.Drawing.Size(82, 14);
            this.Katilimci.TabIndex = 18;
            this.Katilimci.Text = "Katılımcılar:";
            // 
            // EtkinlikTarih
            // 
            this.EtkinlikTarih.AutoSize = true;
            this.EtkinlikTarih.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikTarih.Location = new System.Drawing.Point(68, 149);
            this.EtkinlikTarih.Name = "EtkinlikTarih";
            this.EtkinlikTarih.Size = new System.Drawing.Size(97, 14);
            this.EtkinlikTarih.TabIndex = 17;
            this.EtkinlikTarih.Text = "Etkinlik Tarihi:";
            // 
            // RichEtkinlikAciklama
            // 
            this.RichEtkinlikAciklama.Location = new System.Drawing.Point(187, 398);
            this.RichEtkinlikAciklama.Name = "RichEtkinlikAciklama";
            this.RichEtkinlikAciklama.Size = new System.Drawing.Size(234, 228);
            this.RichEtkinlikAciklama.TabIndex = 16;
            this.RichEtkinlikAciklama.Text = "";
            // 
            // EtkinlikAciklama
            // 
            this.EtkinlikAciklama.AutoSize = true;
            this.EtkinlikAciklama.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikAciklama.Location = new System.Drawing.Point(33, 401);
            this.EtkinlikAciklama.Name = "EtkinlikAciklama";
            this.EtkinlikAciklama.Size = new System.Drawing.Size(125, 14);
            this.EtkinlikAciklama.TabIndex = 15;
            this.EtkinlikAciklama.Text = "Etkinlik Açıklaması:";
            // 
            // txt_EtkinlikAd
            // 
            this.txt_EtkinlikAd.Location = new System.Drawing.Point(187, 97);
            this.txt_EtkinlikAd.Name = "txt_EtkinlikAd";
            this.txt_EtkinlikAd.Size = new System.Drawing.Size(234, 20);
            this.txt_EtkinlikAd.TabIndex = 14;
            // 
            // EtkinlikAd
            // 
            this.EtkinlikAd.AutoSize = true;
            this.EtkinlikAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikAd.Location = new System.Drawing.Point(85, 100);
            this.EtkinlikAd.Name = "EtkinlikAd";
            this.EtkinlikAd.Size = new System.Drawing.Size(80, 14);
            this.EtkinlikAd.TabIndex = 13;
            this.EtkinlikAd.Text = "Etkinlik Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etkinlikIDDataGridViewTextBoxColumn,
            this.etkinlikAdDataGridViewTextBoxColumn,
            this.etkinlikAciklamaDataGridViewTextBoxColumn,
            this.etkinlikTarihDataGridViewTextBoxColumn,
            this.etkinlikKatilimciDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEtkinlikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(511, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 571);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // etkinlikIDDataGridViewTextBoxColumn
            // 
            this.etkinlikIDDataGridViewTextBoxColumn.DataPropertyName = "EtkinlikID";
            this.etkinlikIDDataGridViewTextBoxColumn.HeaderText = "EtkinlikID";
            this.etkinlikIDDataGridViewTextBoxColumn.Name = "etkinlikIDDataGridViewTextBoxColumn";
            this.etkinlikIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etkinlikAdDataGridViewTextBoxColumn
            // 
            this.etkinlikAdDataGridViewTextBoxColumn.DataPropertyName = "EtkinlikAd";
            this.etkinlikAdDataGridViewTextBoxColumn.HeaderText = "EtkinlikAd";
            this.etkinlikAdDataGridViewTextBoxColumn.Name = "etkinlikAdDataGridViewTextBoxColumn";
            // 
            // etkinlikAciklamaDataGridViewTextBoxColumn
            // 
            this.etkinlikAciklamaDataGridViewTextBoxColumn.DataPropertyName = "EtkinlikAciklama";
            this.etkinlikAciklamaDataGridViewTextBoxColumn.HeaderText = "EtkinlikAciklama";
            this.etkinlikAciklamaDataGridViewTextBoxColumn.Name = "etkinlikAciklamaDataGridViewTextBoxColumn";
            // 
            // etkinlikTarihDataGridViewTextBoxColumn
            // 
            this.etkinlikTarihDataGridViewTextBoxColumn.DataPropertyName = "EtkinlikTarih";
            this.etkinlikTarihDataGridViewTextBoxColumn.HeaderText = "EtkinlikTarih";
            this.etkinlikTarihDataGridViewTextBoxColumn.Name = "etkinlikTarihDataGridViewTextBoxColumn";
            // 
            // etkinlikKatilimciDataGridViewTextBoxColumn
            // 
            this.etkinlikKatilimciDataGridViewTextBoxColumn.DataPropertyName = "EtkinlikKatilimci";
            this.etkinlikKatilimciDataGridViewTextBoxColumn.HeaderText = "EtkinlikKatilimci";
            this.etkinlikKatilimciDataGridViewTextBoxColumn.Name = "etkinlikKatilimciDataGridViewTextBoxColumn";
            // 
            // tblEtkinlikBindingSource
            // 
            this.tblEtkinlikBindingSource.DataMember = "Tbl_Etkinlik";
            this.tblEtkinlikBindingSource.DataSource = this.kresOtomasyonDataSet2;
            // 
            // kresOtomasyonDataSet2
            // 
            this.kresOtomasyonDataSet2.DataSetName = "KresOtomasyonDataSet2";
            this.kresOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_EtkinlikTableAdapter
            // 
            this.tbl_EtkinlikTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.Location = new System.Drawing.Point(88, 654);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(109, 23);
            this.btn_Duzenle.TabIndex = 22;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // txt_EtkinlikID
            // 
            this.txt_EtkinlikID.Enabled = false;
            this.txt_EtkinlikID.Location = new System.Drawing.Point(187, 55);
            this.txt_EtkinlikID.Name = "txt_EtkinlikID";
            this.txt_EtkinlikID.Size = new System.Drawing.Size(234, 20);
            this.txt_EtkinlikID.TabIndex = 25;
            // 
            // EtkinlikID
            // 
            this.EtkinlikID.AutoSize = true;
            this.EtkinlikID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikID.Location = new System.Drawing.Point(93, 58);
            this.EtkinlikID.Name = "EtkinlikID";
            this.EtkinlikID.Size = new System.Drawing.Size(72, 14);
            this.EtkinlikID.TabIndex = 24;
            this.EtkinlikID.Text = "Etkinlik ID:";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(294, 654);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(109, 23);
            this.btn_Sil.TabIndex = 26;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // MskEtkinlikTarih
            // 
            this.MskEtkinlikTarih.Location = new System.Drawing.Point(187, 143);
            this.MskEtkinlikTarih.Mask = "00/00/0000";
            this.MskEtkinlikTarih.Name = "MskEtkinlikTarih";
            this.MskEtkinlikTarih.Size = new System.Drawing.Size(234, 20);
            this.MskEtkinlikTarih.TabIndex = 62;
            this.MskEtkinlikTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_EtkinlikListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1107, 701);
            this.Controls.Add(this.MskEtkinlikTarih);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.txt_EtkinlikID);
            this.Controls.Add(this.EtkinlikID);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RichKatilimci);
            this.Controls.Add(this.Katilimci);
            this.Controls.Add(this.EtkinlikTarih);
            this.Controls.Add(this.RichEtkinlikAciklama);
            this.Controls.Add(this.EtkinlikAciklama);
            this.Controls.Add(this.txt_EtkinlikAd);
            this.Controls.Add(this.EtkinlikAd);
            this.Name = "Frm_EtkinlikListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etkinlik Listesi";
            this.Load += new System.EventHandler(this.Frm_EtkinlikListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEtkinlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichKatilimci;
        private System.Windows.Forms.Label Katilimci;
        private System.Windows.Forms.Label EtkinlikTarih;
        private System.Windows.Forms.RichTextBox RichEtkinlikAciklama;
        private System.Windows.Forms.Label EtkinlikAciklama;
        private System.Windows.Forms.TextBox txt_EtkinlikAd;
        private System.Windows.Forms.Label EtkinlikAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KresOtomasyonDataSet2 kresOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource tblEtkinlikBindingSource;
        private KresOtomasyonDataSet2TableAdapters.Tbl_EtkinlikTableAdapter tbl_EtkinlikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikKatilimciDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.TextBox txt_EtkinlikID;
        private System.Windows.Forms.Label EtkinlikID;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.MaskedTextBox MskEtkinlikTarih;
    }
}