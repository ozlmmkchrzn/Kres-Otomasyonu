
namespace KresOtomasyon
{
    partial class Frm_OdemeAl
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
            this.txt_KalanTaksit = new System.Windows.Forms.TextBox();
            this.KalanTaksit = new System.Windows.Forms.Label();
            this.txt_Yatirilan = new System.Windows.Forms.TextBox();
            this.Yatirilan = new System.Windows.Forms.Label();
            this.txt_KalanBorc = new System.Windows.Forms.TextBox();
            this.KalanBorc = new System.Windows.Forms.Label();
            this.btn_OdemeAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblBorclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet6 = new KresOtomasyon.KresOtomasyonDataSet6();
            this.tbl_BorclarTableAdapter = new KresOtomasyon.KresOtomasyonDataSet6TableAdapters.Tbl_BorclarTableAdapter();
            this.kresOtomasyonDataSet14 = new KresOtomasyon.KresOtomasyonDataSet14();
            this.tblBorclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BorclarTableAdapter1 = new KresOtomasyon.KresOtomasyonDataSet14TableAdapters.Tbl_BorclarTableAdapter();
            this.veriborcid = new System.Windows.Forms.Label();
            this.veriogrid = new System.Windows.Forms.Label();
            this.kresOtomasyonDataSet15 = new KresOtomasyon.KresOtomasyonDataSet15();
            this.tblBorclarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BorclarTableAdapter2 = new KresOtomasyon.KresOtomasyonDataSet15TableAdapters.Tbl_BorclarTableAdapter();
            this.txt_BorcID = new System.Windows.Forms.TextBox();
            this.OgrBorcID = new System.Windows.Forms.Label();
            this.BorcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaksitSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yatirilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorclarBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KalanTaksit
            // 
            this.txt_KalanTaksit.Location = new System.Drawing.Point(152, 100);
            this.txt_KalanTaksit.Name = "txt_KalanTaksit";
            this.txt_KalanTaksit.Size = new System.Drawing.Size(176, 20);
            this.txt_KalanTaksit.TabIndex = 7;
            // 
            // KalanTaksit
            // 
            this.KalanTaksit.AutoSize = true;
            this.KalanTaksit.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalanTaksit.Location = new System.Drawing.Point(13, 103);
            this.KalanTaksit.Name = "KalanTaksit";
            this.KalanTaksit.Size = new System.Drawing.Size(122, 14);
            this.KalanTaksit.TabIndex = 6;
            this.KalanTaksit.Text = "Kalan Taksit Sayısı:";
            // 
            // txt_Yatirilan
            // 
            this.txt_Yatirilan.Location = new System.Drawing.Point(152, 158);
            this.txt_Yatirilan.Name = "txt_Yatirilan";
            this.txt_Yatirilan.Size = new System.Drawing.Size(176, 20);
            this.txt_Yatirilan.TabIndex = 9;
            // 
            // Yatirilan
            // 
            this.Yatirilan.AutoSize = true;
            this.Yatirilan.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yatirilan.Location = new System.Drawing.Point(29, 161);
            this.Yatirilan.Name = "Yatirilan";
            this.Yatirilan.Size = new System.Drawing.Size(106, 14);
            this.Yatirilan.TabIndex = 8;
            this.Yatirilan.Text = "Yatırılan Miktar:";
            // 
            // txt_KalanBorc
            // 
            this.txt_KalanBorc.Location = new System.Drawing.Point(152, 208);
            this.txt_KalanBorc.Name = "txt_KalanBorc";
            this.txt_KalanBorc.Size = new System.Drawing.Size(176, 20);
            this.txt_KalanBorc.TabIndex = 11;
            // 
            // KalanBorc
            // 
            this.KalanBorc.AutoSize = true;
            this.KalanBorc.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalanBorc.Location = new System.Drawing.Point(62, 211);
            this.KalanBorc.Name = "KalanBorc";
            this.KalanBorc.Size = new System.Drawing.Size(73, 14);
            this.KalanBorc.TabIndex = 10;
            this.KalanBorc.Text = "Kalan Borç:";
            // 
            // btn_OdemeAl
            // 
            this.btn_OdemeAl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdemeAl.Location = new System.Drawing.Point(152, 361);
            this.btn_OdemeAl.Name = "btn_OdemeAl";
            this.btn_OdemeAl.Size = new System.Drawing.Size(121, 23);
            this.btn_OdemeAl.TabIndex = 12;
            this.btn_OdemeAl.Text = "Ödeme Al";
            this.btn_OdemeAl.UseVisualStyleBackColor = true;
            this.btn_OdemeAl.Click += new System.EventHandler(this.btn_OdemeAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorcID,
            this.TaksitSayisi,
            this.yatirilanDataGridViewTextBoxColumn,
            this.kalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBorclarBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(406, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 360);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblBorclarBindingSource
            // 
            this.tblBorclarBindingSource.DataMember = "Tbl_Borclar";
            this.tblBorclarBindingSource.DataSource = this.kresOtomasyonDataSet6;
            // 
            // kresOtomasyonDataSet6
            // 
            this.kresOtomasyonDataSet6.DataSetName = "KresOtomasyonDataSet6";
            this.kresOtomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_BorclarTableAdapter
            // 
            this.tbl_BorclarTableAdapter.ClearBeforeFill = true;
            // 
            // kresOtomasyonDataSet14
            // 
            this.kresOtomasyonDataSet14.DataSetName = "KresOtomasyonDataSet14";
            this.kresOtomasyonDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBorclarBindingSource1
            // 
            this.tblBorclarBindingSource1.DataMember = "Tbl_Borclar";
            this.tblBorclarBindingSource1.DataSource = this.kresOtomasyonDataSet14;
            // 
            // tbl_BorclarTableAdapter1
            // 
            this.tbl_BorclarTableAdapter1.ClearBeforeFill = true;
            // 
            // veriborcid
            // 
            this.veriborcid.AutoSize = true;
            this.veriborcid.Location = new System.Drawing.Point(334, 379);
            this.veriborcid.Name = "veriborcid";
            this.veriborcid.Size = new System.Drawing.Size(53, 13);
            this.veriborcid.TabIndex = 14;
            this.veriborcid.Text = "veriborcid";
            this.veriborcid.Visible = false;
            // 
            // veriogrid
            // 
            this.veriogrid.AutoSize = true;
            this.veriogrid.Location = new System.Drawing.Point(30, 361);
            this.veriogrid.Name = "veriogrid";
            this.veriogrid.Size = new System.Drawing.Size(47, 13);
            this.veriogrid.TabIndex = 15;
            this.veriogrid.Text = "veriogrid";
            this.veriogrid.Visible = false;
            // 
            // kresOtomasyonDataSet15
            // 
            this.kresOtomasyonDataSet15.DataSetName = "KresOtomasyonDataSet15";
            this.kresOtomasyonDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBorclarBindingSource2
            // 
            this.tblBorclarBindingSource2.DataMember = "Tbl_Borclar";
            this.tblBorclarBindingSource2.DataSource = this.kresOtomasyonDataSet15;
            // 
            // tbl_BorclarTableAdapter2
            // 
            this.tbl_BorclarTableAdapter2.ClearBeforeFill = true;
            // 
            // txt_BorcID
            // 
            this.txt_BorcID.Location = new System.Drawing.Point(152, 49);
            this.txt_BorcID.Name = "txt_BorcID";
            this.txt_BorcID.Size = new System.Drawing.Size(176, 20);
            this.txt_BorcID.TabIndex = 17;
            // 
            // OgrBorcID
            // 
            this.OgrBorcID.AutoSize = true;
            this.OgrBorcID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrBorcID.Location = new System.Drawing.Point(71, 52);
            this.OgrBorcID.Name = "OgrBorcID";
            this.OgrBorcID.Size = new System.Drawing.Size(51, 14);
            this.OgrBorcID.TabIndex = 16;
            this.OgrBorcID.Text = "Borç ID:";
            // 
            // BorcID
            // 
            this.BorcID.DataPropertyName = "BorcID";
            this.BorcID.HeaderText = "BorcID";
            this.BorcID.Name = "BorcID";
            this.BorcID.ReadOnly = true;
            // 
            // TaksitSayisi
            // 
            this.TaksitSayisi.DataPropertyName = "TaksitSayisi";
            this.TaksitSayisi.HeaderText = "TaksitSayisi";
            this.TaksitSayisi.Name = "TaksitSayisi";
            // 
            // yatirilanDataGridViewTextBoxColumn
            // 
            this.yatirilanDataGridViewTextBoxColumn.DataPropertyName = "Yatirilan";
            this.yatirilanDataGridViewTextBoxColumn.HeaderText = "Yatirilan";
            this.yatirilanDataGridViewTextBoxColumn.Name = "yatirilanDataGridViewTextBoxColumn";
            // 
            // kalanBorcDataGridViewTextBoxColumn
            // 
            this.kalanBorcDataGridViewTextBoxColumn.DataPropertyName = "KalanBorc";
            this.kalanBorcDataGridViewTextBoxColumn.HeaderText = "KalanBorc";
            this.kalanBorcDataGridViewTextBoxColumn.Name = "kalanBorcDataGridViewTextBoxColumn";
            // 
            // Frm_OdemeAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(868, 427);
            this.Controls.Add(this.txt_BorcID);
            this.Controls.Add(this.OgrBorcID);
            this.Controls.Add(this.veriogrid);
            this.Controls.Add(this.veriborcid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_OdemeAl);
            this.Controls.Add(this.txt_KalanBorc);
            this.Controls.Add(this.KalanBorc);
            this.Controls.Add(this.txt_Yatirilan);
            this.Controls.Add(this.Yatirilan);
            this.Controls.Add(this.txt_KalanTaksit);
            this.Controls.Add(this.KalanTaksit);
            this.Name = "Frm_OdemeAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Al";
            this.Load += new System.EventHandler(this.Frm_OdemeAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorclarBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_KalanTaksit;
        private System.Windows.Forms.Label KalanTaksit;
        private System.Windows.Forms.TextBox txt_Yatirilan;
        private System.Windows.Forms.Label Yatirilan;
        private System.Windows.Forms.TextBox txt_KalanBorc;
        private System.Windows.Forms.Label KalanBorc;
        private System.Windows.Forms.Button btn_OdemeAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KresOtomasyonDataSet6 kresOtomasyonDataSet6;
        private System.Windows.Forms.BindingSource tblBorclarBindingSource;
        private KresOtomasyonDataSet6TableAdapters.Tbl_BorclarTableAdapter tbl_BorclarTableAdapter;
        private KresOtomasyonDataSet14 kresOtomasyonDataSet14;
        private System.Windows.Forms.BindingSource tblBorclarBindingSource1;
        private KresOtomasyonDataSet14TableAdapters.Tbl_BorclarTableAdapter tbl_BorclarTableAdapter1;
        private System.Windows.Forms.Label veriborcid;
        private System.Windows.Forms.Label veriogrid;
        private KresOtomasyonDataSet15 kresOtomasyonDataSet15;
        private System.Windows.Forms.BindingSource tblBorclarBindingSource2;
        private KresOtomasyonDataSet15TableAdapters.Tbl_BorclarTableAdapter tbl_BorclarTableAdapter2;
        private System.Windows.Forms.TextBox txt_BorcID;
        private System.Windows.Forms.Label OgrBorcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaksitSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yatirilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanBorcDataGridViewTextBoxColumn;
    }
}