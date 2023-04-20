
namespace KresOtomasyon
{
    partial class Frm_Listele
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
            this.txt_LisOgrNo = new System.Windows.Forms.TextBox();
            this.LisOgrNo = new System.Windows.Forms.Label();
            this.btn_LisSil = new System.Windows.Forms.Button();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.ComboLisCinsiyet = new System.Windows.Forms.ComboBox();
            this.LisCinsiyet = new System.Windows.Forms.Label();
            this.ComboLisSinif = new System.Windows.Forms.ComboBox();
            this.LisSinif = new System.Windows.Forms.Label();
            this.txt_LisOgrSoyad = new System.Windows.Forms.TextBox();
            this.LisOgrSoyad = new System.Windows.Forms.Label();
            this.txt_LisOgrAd = new System.Windows.Forms.TextBox();
            this.LisOgrAd = new System.Windows.Forms.Label();
            this.tblOgrTemelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet12 = new KresOtomasyon.KresOtomasyonDataSet12();
            this.tblOgrTemelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet11 = new KresOtomasyon.KresOtomasyonDataSet11();
            this.tblOgrTemelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet8 = new KresOtomasyon.KresOtomasyonDataSet8();
            this.tblOgrTemelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet7 = new KresOtomasyon.KresOtomasyonDataSet7();
            this.txt_OgrID = new System.Windows.Forms.TextBox();
            this.OgrID = new System.Windows.Forms.Label();
            this.tbl_OgrTemelTableAdapter = new KresOtomasyon.KresOtomasyonDataSet7TableAdapters.Tbl_OgrTemelTableAdapter();
            this.checkBoxSut = new System.Windows.Forms.CheckBox();
            this.checkBoxServis = new System.Windows.Forms.CheckBox();
            this.tbl_OgrTemelTableAdapter1 = new KresOtomasyon.KresOtomasyonDataSet8TableAdapters.Tbl_OgrTemelTableAdapter();
            this.tbl_OgrTemelTableAdapter2 = new KresOtomasyon.KresOtomasyonDataSet11TableAdapters.Tbl_OgrTemelTableAdapter();
            this.tbl_OgrTemelTableAdapter3 = new KresOtomasyon.KresOtomasyonDataSet12TableAdapters.Tbl_OgrTemelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKayitTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrReferansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOgrenimSekliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrServisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTanidikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNotlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guzergahIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrResimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_LisOgrNo
            // 
            this.txt_LisOgrNo.Location = new System.Drawing.Point(500, 40);
            this.txt_LisOgrNo.Name = "txt_LisOgrNo";
            this.txt_LisOgrNo.Size = new System.Drawing.Size(155, 20);
            this.txt_LisOgrNo.TabIndex = 80;
            this.txt_LisOgrNo.TextChanged += new System.EventHandler(this.txt_LisOgrNo_TextChanged);
            // 
            // LisOgrNo
            // 
            this.LisOgrNo.AutoSize = true;
            this.LisOgrNo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisOgrNo.Location = new System.Drawing.Point(368, 43);
            this.LisOgrNo.Name = "LisOgrNo";
            this.LisOgrNo.Size = new System.Drawing.Size(114, 14);
            this.LisOgrNo.TabIndex = 79;
            this.LisOgrNo.Text = "Öğrenci Numarası";
            // 
            // btn_LisSil
            // 
            this.btn_LisSil.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_LisSil.Location = new System.Drawing.Point(1101, 90);
            this.btn_LisSil.Name = "btn_LisSil";
            this.btn_LisSil.Size = new System.Drawing.Size(75, 23);
            this.btn_LisSil.TabIndex = 77;
            this.btn_LisSil.Text = "Sil";
            this.btn_LisSil.UseVisualStyleBackColor = true;
            this.btn_LisSil.Click += new System.EventHandler(this.btn_LisSil_Click);
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yenile.Location = new System.Drawing.Point(1101, 33);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_Yenile.TabIndex = 76;
            this.btn_Yenile.Text = "Yenile";
            this.btn_Yenile.UseVisualStyleBackColor = true;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // ComboLisCinsiyet
            // 
            this.ComboLisCinsiyet.FormattingEnabled = true;
            this.ComboLisCinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.ComboLisCinsiyet.Location = new System.Drawing.Point(500, 128);
            this.ComboLisCinsiyet.Name = "ComboLisCinsiyet";
            this.ComboLisCinsiyet.Size = new System.Drawing.Size(155, 21);
            this.ComboLisCinsiyet.TabIndex = 74;
            this.ComboLisCinsiyet.SelectedIndexChanged += new System.EventHandler(this.ComboLisCinsiyet_SelectedIndexChanged);
            // 
            // LisCinsiyet
            // 
            this.LisCinsiyet.AutoSize = true;
            this.LisCinsiyet.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisCinsiyet.Location = new System.Drawing.Point(423, 131);
            this.LisCinsiyet.Name = "LisCinsiyet";
            this.LisCinsiyet.Size = new System.Drawing.Size(59, 14);
            this.LisCinsiyet.TabIndex = 73;
            this.LisCinsiyet.Text = "Cinsiyet:";
            // 
            // ComboLisSinif
            // 
            this.ComboLisSinif.FormattingEnabled = true;
            this.ComboLisSinif.Location = new System.Drawing.Point(500, 83);
            this.ComboLisSinif.Name = "ComboLisSinif";
            this.ComboLisSinif.Size = new System.Drawing.Size(155, 21);
            this.ComboLisSinif.TabIndex = 67;
            this.ComboLisSinif.SelectedIndexChanged += new System.EventHandler(this.ComboLisSinif_SelectedIndexChanged);
            // 
            // LisSinif
            // 
            this.LisSinif.AutoSize = true;
            this.LisSinif.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisSinif.Location = new System.Drawing.Point(440, 86);
            this.LisSinif.Name = "LisSinif";
            this.LisSinif.Size = new System.Drawing.Size(42, 14);
            this.LisSinif.TabIndex = 64;
            this.LisSinif.Text = "Sınıfı:";
            // 
            // txt_LisOgrSoyad
            // 
            this.txt_LisOgrSoyad.Location = new System.Drawing.Point(158, 132);
            this.txt_LisOgrSoyad.Name = "txt_LisOgrSoyad";
            this.txt_LisOgrSoyad.Size = new System.Drawing.Size(155, 20);
            this.txt_LisOgrSoyad.TabIndex = 63;
            this.txt_LisOgrSoyad.TextChanged += new System.EventHandler(this.txt_LisOgrSoyad_TextChanged);
            // 
            // LisOgrSoyad
            // 
            this.LisOgrSoyad.AutoSize = true;
            this.LisOgrSoyad.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisOgrSoyad.Location = new System.Drawing.Point(41, 135);
            this.LisOgrSoyad.Name = "LisOgrSoyad";
            this.LisOgrSoyad.Size = new System.Drawing.Size(99, 14);
            this.LisOgrSoyad.TabIndex = 62;
            this.LisOgrSoyad.Text = "Öğrenci Soyadı:";
            // 
            // txt_LisOgrAd
            // 
            this.txt_LisOgrAd.Location = new System.Drawing.Point(158, 87);
            this.txt_LisOgrAd.Name = "txt_LisOgrAd";
            this.txt_LisOgrAd.Size = new System.Drawing.Size(155, 20);
            this.txt_LisOgrAd.TabIndex = 61;
            this.txt_LisOgrAd.TextChanged += new System.EventHandler(this.txt_LisOgrAd_TextChanged);
            // 
            // LisOgrAd
            // 
            this.LisOgrAd.AutoSize = true;
            this.LisOgrAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisOgrAd.Location = new System.Drawing.Point(60, 90);
            this.LisOgrAd.Name = "LisOgrAd";
            this.LisOgrAd.Size = new System.Drawing.Size(80, 14);
            this.LisOgrAd.TabIndex = 60;
            this.LisOgrAd.Text = "Öğrenci Adı:";
            // 
            // tblOgrTemelBindingSource3
            // 
            this.tblOgrTemelBindingSource3.DataMember = "Tbl_OgrTemel";
            this.tblOgrTemelBindingSource3.DataSource = this.kresOtomasyonDataSet12;
            // 
            // kresOtomasyonDataSet12
            // 
            this.kresOtomasyonDataSet12.DataSetName = "KresOtomasyonDataSet12";
            this.kresOtomasyonDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrTemelBindingSource2
            // 
            this.tblOgrTemelBindingSource2.DataMember = "Tbl_OgrTemel";
            this.tblOgrTemelBindingSource2.DataSource = this.kresOtomasyonDataSet11;
            // 
            // kresOtomasyonDataSet11
            // 
            this.kresOtomasyonDataSet11.DataSetName = "KresOtomasyonDataSet11";
            this.kresOtomasyonDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrTemelBindingSource1
            // 
            this.tblOgrTemelBindingSource1.DataMember = "Tbl_OgrTemel";
            this.tblOgrTemelBindingSource1.DataSource = this.kresOtomasyonDataSet8;
            // 
            // kresOtomasyonDataSet8
            // 
            this.kresOtomasyonDataSet8.DataSetName = "KresOtomasyonDataSet8";
            this.kresOtomasyonDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrTemelBindingSource
            // 
            this.tblOgrTemelBindingSource.DataMember = "Tbl_OgrTemel";
            this.tblOgrTemelBindingSource.DataSource = this.kresOtomasyonDataSet7;
            // 
            // kresOtomasyonDataSet7
            // 
            this.kresOtomasyonDataSet7.DataSetName = "KresOtomasyonDataSet7";
            this.kresOtomasyonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_OgrID
            // 
            this.txt_OgrID.Location = new System.Drawing.Point(158, 44);
            this.txt_OgrID.Name = "txt_OgrID";
            this.txt_OgrID.Size = new System.Drawing.Size(155, 20);
            this.txt_OgrID.TabIndex = 91;
            // 
            // OgrID
            // 
            this.OgrID.AutoSize = true;
            this.OgrID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrID.Location = new System.Drawing.Point(68, 47);
            this.OgrID.Name = "OgrID";
            this.OgrID.Size = new System.Drawing.Size(72, 14);
            this.OgrID.TabIndex = 90;
            this.OgrID.Text = "Öğrenci ID:";
            // 
            // tbl_OgrTemelTableAdapter
            // 
            this.tbl_OgrTemelTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxSut
            // 
            this.checkBoxSut.AutoSize = true;
            this.checkBoxSut.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSut.Location = new System.Drawing.Point(693, 83);
            this.checkBoxSut.Name = "checkBoxSut";
            this.checkBoxSut.Size = new System.Drawing.Size(125, 19);
            this.checkBoxSut.TabIndex = 93;
            this.checkBoxSut.Text = "Süt Kullanıyor";
            this.checkBoxSut.UseVisualStyleBackColor = true;
            this.checkBoxSut.CheckedChanged += new System.EventHandler(this.checkBoxSut_CheckedChanged);
            // 
            // checkBoxServis
            // 
            this.checkBoxServis.AutoSize = true;
            this.checkBoxServis.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxServis.Location = new System.Drawing.Point(693, 37);
            this.checkBoxServis.Name = "checkBoxServis";
            this.checkBoxServis.Size = new System.Drawing.Size(169, 19);
            this.checkBoxServis.TabIndex = 92;
            this.checkBoxServis.Text = "Servis Hizmeti Alıyor";
            this.checkBoxServis.UseVisualStyleBackColor = true;
            this.checkBoxServis.CheckedChanged += new System.EventHandler(this.checkBoxServis_CheckedChanged);
            // 
            // tbl_OgrTemelTableAdapter1
            // 
            this.tbl_OgrTemelTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_OgrTemelTableAdapter2
            // 
            this.tbl_OgrTemelTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_OgrTemelTableAdapter3
            // 
            this.tbl_OgrTemelTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrNoDataGridViewTextBoxColumn,
            this.sinifIDDataGridViewTextBoxColumn,
            this.ogrCinsiyetDataGridViewTextBoxColumn,
            this.ogrKayitTarihDataGridViewTextBoxColumn,
            this.ogrReferansDataGridViewTextBoxColumn,
            this.ogrOgrenimSekliDataGridViewTextBoxColumn,
            this.ogrDurumDataGridViewTextBoxColumn,
            this.ogrSutDataGridViewTextBoxColumn,
            this.ogrServisDataGridViewTextBoxColumn,
            this.ogrTanidikDataGridViewTextBoxColumn,
            this.ogrNotlarDataGridViewTextBoxColumn,
            this.guzergahIDDataGridViewTextBoxColumn,
            this.ogrResimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrTemelBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(21, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1206, 477);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            // 
            // sinifIDDataGridViewTextBoxColumn
            // 
            this.sinifIDDataGridViewTextBoxColumn.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.HeaderText = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.Name = "sinifIDDataGridViewTextBoxColumn";
            // 
            // ogrCinsiyetDataGridViewTextBoxColumn
            // 
            this.ogrCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "OgrCinsiyet";
            this.ogrCinsiyetDataGridViewTextBoxColumn.HeaderText = "OgrCinsiyet";
            this.ogrCinsiyetDataGridViewTextBoxColumn.Name = "ogrCinsiyetDataGridViewTextBoxColumn";
            // 
            // ogrKayitTarihDataGridViewTextBoxColumn
            // 
            this.ogrKayitTarihDataGridViewTextBoxColumn.DataPropertyName = "OgrKayitTarih";
            this.ogrKayitTarihDataGridViewTextBoxColumn.HeaderText = "OgrKayitTarih";
            this.ogrKayitTarihDataGridViewTextBoxColumn.Name = "ogrKayitTarihDataGridViewTextBoxColumn";
            // 
            // ogrReferansDataGridViewTextBoxColumn
            // 
            this.ogrReferansDataGridViewTextBoxColumn.DataPropertyName = "OgrReferans";
            this.ogrReferansDataGridViewTextBoxColumn.HeaderText = "OgrReferans";
            this.ogrReferansDataGridViewTextBoxColumn.Name = "ogrReferansDataGridViewTextBoxColumn";
            // 
            // ogrOgrenimSekliDataGridViewTextBoxColumn
            // 
            this.ogrOgrenimSekliDataGridViewTextBoxColumn.DataPropertyName = "OgrOgrenimSekli";
            this.ogrOgrenimSekliDataGridViewTextBoxColumn.HeaderText = "OgrOgrenimSekli";
            this.ogrOgrenimSekliDataGridViewTextBoxColumn.Name = "ogrOgrenimSekliDataGridViewTextBoxColumn";
            // 
            // ogrDurumDataGridViewTextBoxColumn
            // 
            this.ogrDurumDataGridViewTextBoxColumn.DataPropertyName = "OgrDurum";
            this.ogrDurumDataGridViewTextBoxColumn.HeaderText = "OgrDurum";
            this.ogrDurumDataGridViewTextBoxColumn.Name = "ogrDurumDataGridViewTextBoxColumn";
            // 
            // ogrSutDataGridViewTextBoxColumn
            // 
            this.ogrSutDataGridViewTextBoxColumn.DataPropertyName = "OgrSut";
            this.ogrSutDataGridViewTextBoxColumn.HeaderText = "OgrSut";
            this.ogrSutDataGridViewTextBoxColumn.Name = "ogrSutDataGridViewTextBoxColumn";
            // 
            // ogrServisDataGridViewTextBoxColumn
            // 
            this.ogrServisDataGridViewTextBoxColumn.DataPropertyName = "OgrServis";
            this.ogrServisDataGridViewTextBoxColumn.HeaderText = "OgrServis";
            this.ogrServisDataGridViewTextBoxColumn.Name = "ogrServisDataGridViewTextBoxColumn";
            // 
            // ogrTanidikDataGridViewTextBoxColumn
            // 
            this.ogrTanidikDataGridViewTextBoxColumn.DataPropertyName = "OgrTanidik";
            this.ogrTanidikDataGridViewTextBoxColumn.HeaderText = "OgrTanidik";
            this.ogrTanidikDataGridViewTextBoxColumn.Name = "ogrTanidikDataGridViewTextBoxColumn";
            // 
            // ogrNotlarDataGridViewTextBoxColumn
            // 
            this.ogrNotlarDataGridViewTextBoxColumn.DataPropertyName = "OgrNotlar";
            this.ogrNotlarDataGridViewTextBoxColumn.HeaderText = "OgrNotlar";
            this.ogrNotlarDataGridViewTextBoxColumn.Name = "ogrNotlarDataGridViewTextBoxColumn";
            // 
            // guzergahIDDataGridViewTextBoxColumn
            // 
            this.guzergahIDDataGridViewTextBoxColumn.DataPropertyName = "GuzergahID";
            this.guzergahIDDataGridViewTextBoxColumn.HeaderText = "GuzergahID";
            this.guzergahIDDataGridViewTextBoxColumn.Name = "guzergahIDDataGridViewTextBoxColumn";
            // 
            // ogrResimDataGridViewTextBoxColumn
            // 
            this.ogrResimDataGridViewTextBoxColumn.DataPropertyName = "OgrResim";
            this.ogrResimDataGridViewTextBoxColumn.HeaderText = "OgrResim";
            this.ogrResimDataGridViewTextBoxColumn.Name = "ogrResimDataGridViewTextBoxColumn";
            // 
            // btn_Excel
            // 
            this.btn_Excel.AutoSize = true;
            this.btn_Excel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Excel.Location = new System.Drawing.Point(997, 60);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(75, 26);
            this.btn_Excel.TabIndex = 95;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // Frm_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1239, 706);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxSut);
            this.Controls.Add(this.checkBoxServis);
            this.Controls.Add(this.txt_OgrID);
            this.Controls.Add(this.OgrID);
            this.Controls.Add(this.txt_LisOgrNo);
            this.Controls.Add(this.LisOgrNo);
            this.Controls.Add(this.btn_LisSil);
            this.Controls.Add(this.btn_Yenile);
            this.Controls.Add(this.ComboLisCinsiyet);
            this.Controls.Add(this.LisCinsiyet);
            this.Controls.Add(this.ComboLisSinif);
            this.Controls.Add(this.LisSinif);
            this.Controls.Add(this.txt_LisOgrSoyad);
            this.Controls.Add(this.LisOgrSoyad);
            this.Controls.Add(this.txt_LisOgrAd);
            this.Controls.Add(this.LisOgrAd);
            this.Name = "Frm_Listele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listele";
            this.Load += new System.EventHandler(this.Frm_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrTemelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_LisOgrNo;
        private System.Windows.Forms.Label LisOgrNo;
        private System.Windows.Forms.Button btn_LisSil;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.ComboBox ComboLisCinsiyet;
        private System.Windows.Forms.Label LisCinsiyet;
        private System.Windows.Forms.ComboBox ComboLisSinif;
        private System.Windows.Forms.Label LisSinif;
        private System.Windows.Forms.TextBox txt_LisOgrSoyad;
        private System.Windows.Forms.Label LisOgrSoyad;
        private System.Windows.Forms.TextBox txt_LisOgrAd;
        private System.Windows.Forms.Label LisOgrAd;
        private System.Windows.Forms.TextBox txt_OgrID;
        private System.Windows.Forms.Label OgrID;
        private KresOtomasyonDataSet7 kresOtomasyonDataSet7;
        private System.Windows.Forms.BindingSource tblOgrTemelBindingSource;
        private KresOtomasyonDataSet7TableAdapters.Tbl_OgrTemelTableAdapter tbl_OgrTemelTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxSut;
        private System.Windows.Forms.CheckBox checkBoxServis;
        private KresOtomasyonDataSet8 kresOtomasyonDataSet8;
        private System.Windows.Forms.BindingSource tblOgrTemelBindingSource1;
        private KresOtomasyonDataSet8TableAdapters.Tbl_OgrTemelTableAdapter tbl_OgrTemelTableAdapter1;
        private KresOtomasyonDataSet11 kresOtomasyonDataSet11;
        private System.Windows.Forms.BindingSource tblOgrTemelBindingSource2;
        private KresOtomasyonDataSet11TableAdapters.Tbl_OgrTemelTableAdapter tbl_OgrTemelTableAdapter2;
        private KresOtomasyonDataSet12 kresOtomasyonDataSet12;
        private System.Windows.Forms.BindingSource tblOgrTemelBindingSource3;
        private KresOtomasyonDataSet12TableAdapters.Tbl_OgrTemelTableAdapter tbl_OgrTemelTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKayitTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrReferansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOgrenimSekliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrServisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTanidikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNotlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guzergahIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrResimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Excel;
    }
}