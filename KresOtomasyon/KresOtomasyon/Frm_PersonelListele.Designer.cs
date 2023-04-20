
namespace KresOtomasyon
{
    partial class Frm_PersonelListele
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
            this.txt_ListelePersonelAd = new System.Windows.Forms.TextBox();
            this.ListelePersonelAd = new System.Windows.Forms.Label();
            this.LisPersonelUnvan = new System.Windows.Forms.Label();
            this.txt_LisPersonelUnvan = new System.Windows.Forms.TextBox();
            this.CheckOgretmen = new System.Windows.Forms.CheckBox();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPersonelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet10 = new KresOtomasyon.KresOtomasyonDataSet10();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet1 = new KresOtomasyon.KresOtomasyonDataSet1();
            this.tbl_PersonelTableAdapter = new KresOtomasyon.KresOtomasyonDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            this.PersonelID = new System.Windows.Forms.Label();
            this.txt_PersonelID = new System.Windows.Forms.TextBox();
            this.kresOtomasyonDataSet9 = new KresOtomasyon.KresOtomasyonDataSet9();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter1 = new KresOtomasyon.KresOtomasyonDataSet9TableAdapters.Tbl_PersonelTableAdapter();
            this.tbl_PersonelTableAdapter2 = new KresOtomasyon.KresOtomasyonDataSet10TableAdapters.Tbl_PersonelTableAdapter();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.kresOtomasyonDataSet13 = new KresOtomasyon.KresOtomasyonDataSet13();
            this.tblPersonelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter3 = new KresOtomasyon.KresOtomasyonDataSet13TableAdapters.Tbl_PersonelTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelUnvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelOgretmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBaslamaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAyrilmaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTahsilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelCalisSekliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelMukaveleBasTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelMukaveleBitisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelMesaiSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelEvTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelCepTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelDogTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelUyruk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSonKullanTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelResim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ListelePersonelAd
            // 
            this.txt_ListelePersonelAd.Location = new System.Drawing.Point(216, 61);
            this.txt_ListelePersonelAd.Name = "txt_ListelePersonelAd";
            this.txt_ListelePersonelAd.Size = new System.Drawing.Size(147, 20);
            this.txt_ListelePersonelAd.TabIndex = 0;
            this.txt_ListelePersonelAd.TextChanged += new System.EventHandler(this.txt_ListelePersonelAd_TextChanged);
            // 
            // ListelePersonelAd
            // 
            this.ListelePersonelAd.AutoSize = true;
            this.ListelePersonelAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListelePersonelAd.Location = new System.Drawing.Point(71, 64);
            this.ListelePersonelAd.Name = "ListelePersonelAd";
            this.ListelePersonelAd.Size = new System.Drawing.Size(124, 14);
            this.ListelePersonelAd.TabIndex = 1;
            this.ListelePersonelAd.Text = "Personel Adı Soyadı:";
            // 
            // LisPersonelUnvan
            // 
            this.LisPersonelUnvan.AutoSize = true;
            this.LisPersonelUnvan.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisPersonelUnvan.Location = new System.Drawing.Point(89, 103);
            this.LisPersonelUnvan.Name = "LisPersonelUnvan";
            this.LisPersonelUnvan.Size = new System.Drawing.Size(106, 14);
            this.LisPersonelUnvan.TabIndex = 3;
            this.LisPersonelUnvan.Text = "Personel Ünvanı:";
            // 
            // txt_LisPersonelUnvan
            // 
            this.txt_LisPersonelUnvan.Location = new System.Drawing.Point(216, 100);
            this.txt_LisPersonelUnvan.Name = "txt_LisPersonelUnvan";
            this.txt_LisPersonelUnvan.Size = new System.Drawing.Size(147, 20);
            this.txt_LisPersonelUnvan.TabIndex = 2;
            this.txt_LisPersonelUnvan.TextChanged += new System.EventHandler(this.txt_LisPersonelUnvan_TextChanged);
            // 
            // CheckOgretmen
            // 
            this.CheckOgretmen.AutoSize = true;
            this.CheckOgretmen.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckOgretmen.Location = new System.Drawing.Point(427, 27);
            this.CheckOgretmen.Name = "CheckOgretmen";
            this.CheckOgretmen.Size = new System.Drawing.Size(85, 18);
            this.CheckOgretmen.TabIndex = 4;
            this.CheckOgretmen.Text = "Öğretmen";
            this.CheckOgretmen.UseVisualStyleBackColor = true;
            this.CheckOgretmen.CheckedChanged += new System.EventHandler(this.CheckOgretmen_CheckedChanged);
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yenile.Location = new System.Drawing.Point(616, 21);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_Yenile.TabIndex = 5;
            this.btn_Yenile.Text = "Yenile";
            this.btn_Yenile.UseVisualStyleBackColor = true;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(768, 21);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 6;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelUnvanDataGridViewTextBoxColumn,
            this.PersonelOgretmen,
            this.personelBaslamaTarihDataGridViewTextBoxColumn,
            this.personelAyrilmaTarihDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn,
            this.personelDurumDataGridViewTextBoxColumn,
            this.personelTahsilDataGridViewTextBoxColumn,
            this.personelCalisSekliDataGridViewTextBoxColumn,
            this.PersonelMukaveleBasTarih,
            this.PersonelMukaveleBitisTarih,
            this.PersonelMesaiSaat,
            this.PersonelEvTel,
            this.PersonelCepTel,
            this.PersonelMail,
            this.PersonelAdres,
            this.PersonelTC,
            this.PersonelDogTarih,
            this.PersonelSeriNo,
            this.PersonelUyruk,
            this.PersonelSonKullanTarih,
            this.PersonelResim});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 328);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tblPersonelBindingSource2
            // 
            this.tblPersonelBindingSource2.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource2.DataSource = this.kresOtomasyonDataSet10;
            // 
            // kresOtomasyonDataSet10
            // 
            this.kresOtomasyonDataSet10.DataSetName = "KresOtomasyonDataSet10";
            this.kresOtomasyonDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.kresOtomasyonDataSet1;
            // 
            // kresOtomasyonDataSet1
            // 
            this.kresOtomasyonDataSet1.DataSetName = "KresOtomasyonDataSet1";
            this.kresOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelID
            // 
            this.PersonelID.AutoSize = true;
            this.PersonelID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelID.Location = new System.Drawing.Point(119, 27);
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.Size = new System.Drawing.Size(74, 14);
            this.PersonelID.TabIndex = 9;
            this.PersonelID.Text = "Personel ID:";
            // 
            // txt_PersonelID
            // 
            this.txt_PersonelID.Enabled = false;
            this.txt_PersonelID.Location = new System.Drawing.Point(216, 24);
            this.txt_PersonelID.Name = "txt_PersonelID";
            this.txt_PersonelID.Size = new System.Drawing.Size(147, 20);
            this.txt_PersonelID.TabIndex = 8;
            // 
            // kresOtomasyonDataSet9
            // 
            this.kresOtomasyonDataSet9.DataSetName = "KresOtomasyonDataSet9";
            this.kresOtomasyonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource1.DataSource = this.kresOtomasyonDataSet9;
            // 
            // tbl_PersonelTableAdapter1
            // 
            this.tbl_PersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_PersonelTableAdapter2
            // 
            this.tbl_PersonelTableAdapter2.ClearBeforeFill = true;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Excel.Location = new System.Drawing.Point(692, 64);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(75, 23);
            this.btn_Excel.TabIndex = 96;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // kresOtomasyonDataSet13
            // 
            this.kresOtomasyonDataSet13.DataSetName = "KresOtomasyonDataSet13";
            this.kresOtomasyonDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource3
            // 
            this.tblPersonelBindingSource3.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource3.DataSource = this.kresOtomasyonDataSet13;
            // 
            // tbl_PersonelTableAdapter3
            // 
            this.tbl_PersonelTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonelID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PersonelID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            // 
            // personelUnvanDataGridViewTextBoxColumn
            // 
            this.personelUnvanDataGridViewTextBoxColumn.DataPropertyName = "PersonelUnvan";
            this.personelUnvanDataGridViewTextBoxColumn.HeaderText = "PersonelUnvan";
            this.personelUnvanDataGridViewTextBoxColumn.Name = "personelUnvanDataGridViewTextBoxColumn";
            // 
            // PersonelOgretmen
            // 
            this.PersonelOgretmen.DataPropertyName = "PersonelOgretmen";
            this.PersonelOgretmen.HeaderText = "PersonelOgretmen";
            this.PersonelOgretmen.Name = "PersonelOgretmen";
            // 
            // personelBaslamaTarihDataGridViewTextBoxColumn
            // 
            this.personelBaslamaTarihDataGridViewTextBoxColumn.DataPropertyName = "PersonelBaslamaTarih";
            this.personelBaslamaTarihDataGridViewTextBoxColumn.HeaderText = "PersonelBaslamaTarih";
            this.personelBaslamaTarihDataGridViewTextBoxColumn.Name = "personelBaslamaTarihDataGridViewTextBoxColumn";
            // 
            // personelAyrilmaTarihDataGridViewTextBoxColumn
            // 
            this.personelAyrilmaTarihDataGridViewTextBoxColumn.DataPropertyName = "PersonelAyrilmaTarih";
            this.personelAyrilmaTarihDataGridViewTextBoxColumn.HeaderText = "PersonelAyrilmaTarih";
            this.personelAyrilmaTarihDataGridViewTextBoxColumn.Name = "personelAyrilmaTarihDataGridViewTextBoxColumn";
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            // 
            // personelDurumDataGridViewTextBoxColumn
            // 
            this.personelDurumDataGridViewTextBoxColumn.DataPropertyName = "PersonelDurum";
            this.personelDurumDataGridViewTextBoxColumn.HeaderText = "PersonelDurum";
            this.personelDurumDataGridViewTextBoxColumn.Name = "personelDurumDataGridViewTextBoxColumn";
            // 
            // personelTahsilDataGridViewTextBoxColumn
            // 
            this.personelTahsilDataGridViewTextBoxColumn.DataPropertyName = "PersonelTahsil";
            this.personelTahsilDataGridViewTextBoxColumn.HeaderText = "PersonelTahsil";
            this.personelTahsilDataGridViewTextBoxColumn.Name = "personelTahsilDataGridViewTextBoxColumn";
            // 
            // personelCalisSekliDataGridViewTextBoxColumn
            // 
            this.personelCalisSekliDataGridViewTextBoxColumn.DataPropertyName = "PersonelCalisSekli";
            this.personelCalisSekliDataGridViewTextBoxColumn.HeaderText = "PersonelCalisSekli";
            this.personelCalisSekliDataGridViewTextBoxColumn.Name = "personelCalisSekliDataGridViewTextBoxColumn";
            // 
            // PersonelMukaveleBasTarih
            // 
            this.PersonelMukaveleBasTarih.DataPropertyName = "PersonelMukaveleBasTarih";
            this.PersonelMukaveleBasTarih.HeaderText = "PersonelMukaveleBasTarih";
            this.PersonelMukaveleBasTarih.Name = "PersonelMukaveleBasTarih";
            // 
            // PersonelMukaveleBitisTarih
            // 
            this.PersonelMukaveleBitisTarih.DataPropertyName = "PersonelMukaveleBitisTarih";
            this.PersonelMukaveleBitisTarih.HeaderText = "PersonelMukaveleBitisTarih";
            this.PersonelMukaveleBitisTarih.Name = "PersonelMukaveleBitisTarih";
            // 
            // PersonelMesaiSaat
            // 
            this.PersonelMesaiSaat.DataPropertyName = "PersonelMesaiSaat";
            this.PersonelMesaiSaat.HeaderText = "PersonelMesaiSaat";
            this.PersonelMesaiSaat.Name = "PersonelMesaiSaat";
            // 
            // PersonelEvTel
            // 
            this.PersonelEvTel.DataPropertyName = "PersonelEvTel";
            this.PersonelEvTel.HeaderText = "PersonelEvTel";
            this.PersonelEvTel.Name = "PersonelEvTel";
            // 
            // PersonelCepTel
            // 
            this.PersonelCepTel.DataPropertyName = "PersonelCepTel";
            this.PersonelCepTel.HeaderText = "PersonelCepTel";
            this.PersonelCepTel.Name = "PersonelCepTel";
            // 
            // PersonelMail
            // 
            this.PersonelMail.DataPropertyName = "PersonelMail";
            this.PersonelMail.HeaderText = "PersonelMail";
            this.PersonelMail.Name = "PersonelMail";
            // 
            // PersonelAdres
            // 
            this.PersonelAdres.DataPropertyName = "PersonelAdres";
            this.PersonelAdres.HeaderText = "PersonelAdres";
            this.PersonelAdres.Name = "PersonelAdres";
            // 
            // PersonelTC
            // 
            this.PersonelTC.DataPropertyName = "PersonelTC";
            this.PersonelTC.HeaderText = "PersonelTC";
            this.PersonelTC.Name = "PersonelTC";
            // 
            // PersonelDogTarih
            // 
            this.PersonelDogTarih.DataPropertyName = "PersonelDogTarih";
            this.PersonelDogTarih.HeaderText = "PersonelDogTarih";
            this.PersonelDogTarih.Name = "PersonelDogTarih";
            // 
            // PersonelSeriNo
            // 
            this.PersonelSeriNo.DataPropertyName = "PersonelSeriNo";
            this.PersonelSeriNo.HeaderText = "PersonelSeriNo";
            this.PersonelSeriNo.Name = "PersonelSeriNo";
            // 
            // PersonelUyruk
            // 
            this.PersonelUyruk.DataPropertyName = "PersonelUyruk";
            this.PersonelUyruk.HeaderText = "PersonelUyruk";
            this.PersonelUyruk.Name = "PersonelUyruk";
            // 
            // PersonelSonKullanTarih
            // 
            this.PersonelSonKullanTarih.DataPropertyName = "PersonelSonKullanTarih";
            this.PersonelSonKullanTarih.HeaderText = "PersonelSonKullanTarih";
            this.PersonelSonKullanTarih.Name = "PersonelSonKullanTarih";
            // 
            // PersonelResim
            // 
            this.PersonelResim.DataPropertyName = "PersonelResim";
            this.PersonelResim.HeaderText = "PersonelResim";
            this.PersonelResim.Name = "PersonelResim";
            // 
            // Frm_PersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(865, 502);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.PersonelID);
            this.Controls.Add(this.txt_PersonelID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Yenile);
            this.Controls.Add(this.CheckOgretmen);
            this.Controls.Add(this.LisPersonelUnvan);
            this.Controls.Add(this.txt_LisPersonelUnvan);
            this.Controls.Add(this.ListelePersonelAd);
            this.Controls.Add(this.txt_ListelePersonelAd);
            this.Name = "Frm_PersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listele";
            this.Load += new System.EventHandler(this.Frm_PersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ListelePersonelAd;
        private System.Windows.Forms.Label ListelePersonelAd;
        private System.Windows.Forms.Label LisPersonelUnvan;
        private System.Windows.Forms.TextBox txt_LisPersonelUnvan;
        private System.Windows.Forms.CheckBox CheckOgretmen;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KresOtomasyonDataSet1 kresOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private KresOtomasyonDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.Label PersonelID;
        private System.Windows.Forms.TextBox txt_PersonelID;
        private KresOtomasyonDataSet9 kresOtomasyonDataSet9;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private KresOtomasyonDataSet9TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter1;
        private KresOtomasyonDataSet10 kresOtomasyonDataSet10;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource2;
        private KresOtomasyonDataSet10TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter2;
        private System.Windows.Forms.Button btn_Excel;
        private KresOtomasyonDataSet13 kresOtomasyonDataSet13;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource3;
        private KresOtomasyonDataSet13TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelUnvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelOgretmen;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelBaslamaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAyrilmaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTahsilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelCalisSekliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelMukaveleBasTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelMukaveleBitisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelMesaiSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelEvTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelCepTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelDogTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelUyruk;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSonKullanTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelResim;
    }
}