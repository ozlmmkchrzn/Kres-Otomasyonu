
namespace KresOtomasyon
{
    partial class Frm_SinifListele
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
            this.SinifID = new System.Windows.Forms.Label();
            this.txt_SinifID = new System.Windows.Forms.TextBox();
            this.txt_SinidAd = new System.Windows.Forms.TextBox();
            this.SinifAd = new System.Windows.Forms.Label();
            this.btn_SinifDuzenle = new System.Windows.Forms.Button();
            this.btn_SinifSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifKapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kresOtomasyonDataSet = new KresOtomasyon.KresOtomasyonDataSet();
            this.tbl_SinifTableAdapter = new KresOtomasyon.KresOtomasyonDataSetTableAdapters.Tbl_SinifTableAdapter();
            this.LisKapasite = new System.Windows.Forms.Label();
            this.txt_LisKapasite = new System.Windows.Forms.TextBox();
            this.txt_LisYas = new System.Windows.Forms.TextBox();
            this.LisYas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SinifID
            // 
            this.SinifID.AutoSize = true;
            this.SinifID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SinifID.Location = new System.Drawing.Point(49, 26);
            this.SinifID.Name = "SinifID";
            this.SinifID.Size = new System.Drawing.Size(53, 14);
            this.SinifID.TabIndex = 0;
            this.SinifID.Text = "Sınıf ID:";
            // 
            // txt_SinifID
            // 
            this.txt_SinifID.Enabled = false;
            this.txt_SinifID.Location = new System.Drawing.Point(118, 23);
            this.txt_SinifID.Name = "txt_SinifID";
            this.txt_SinifID.Size = new System.Drawing.Size(130, 20);
            this.txt_SinifID.TabIndex = 1;
            // 
            // txt_SinidAd
            // 
            this.txt_SinidAd.Location = new System.Drawing.Point(118, 65);
            this.txt_SinidAd.Name = "txt_SinidAd";
            this.txt_SinidAd.Size = new System.Drawing.Size(130, 20);
            this.txt_SinidAd.TabIndex = 2;
            // 
            // SinifAd
            // 
            this.SinifAd.AutoSize = true;
            this.SinifAd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SinifAd.Location = new System.Drawing.Point(41, 68);
            this.SinifAd.Name = "SinifAd";
            this.SinifAd.Size = new System.Drawing.Size(61, 14);
            this.SinifAd.TabIndex = 3;
            this.SinifAd.Text = "Sınıf Adı:";
            // 
            // btn_SinifDuzenle
            // 
            this.btn_SinifDuzenle.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SinifDuzenle.Location = new System.Drawing.Point(580, 22);
            this.btn_SinifDuzenle.Name = "btn_SinifDuzenle";
            this.btn_SinifDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_SinifDuzenle.TabIndex = 4;
            this.btn_SinifDuzenle.Text = "Düzenle";
            this.btn_SinifDuzenle.UseVisualStyleBackColor = true;
            this.btn_SinifDuzenle.Click += new System.EventHandler(this.btn_SinifDuzenle_Click);
            // 
            // btn_SinifSil
            // 
            this.btn_SinifSil.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SinifSil.Location = new System.Drawing.Point(580, 64);
            this.btn_SinifSil.Name = "btn_SinifSil";
            this.btn_SinifSil.Size = new System.Drawing.Size(75, 23);
            this.btn_SinifSil.TabIndex = 5;
            this.btn_SinifSil.Text = "Sil";
            this.btn_SinifSil.UseVisualStyleBackColor = true;
            this.btn_SinifSil.Click += new System.EventHandler(this.btn_SinifSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifIDDataGridViewTextBoxColumn,
            this.sinifAdDataGridViewTextBoxColumn,
            this.sinifYasDataGridViewTextBoxColumn,
            this.sinifKapasiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSinifBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(107, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 489);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sinifIDDataGridViewTextBoxColumn
            // 
            this.sinifIDDataGridViewTextBoxColumn.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.HeaderText = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.Name = "sinifIDDataGridViewTextBoxColumn";
            this.sinifIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinifAdDataGridViewTextBoxColumn
            // 
            this.sinifAdDataGridViewTextBoxColumn.DataPropertyName = "SinifAd";
            this.sinifAdDataGridViewTextBoxColumn.HeaderText = "SinifAd";
            this.sinifAdDataGridViewTextBoxColumn.Name = "sinifAdDataGridViewTextBoxColumn";
            // 
            // sinifYasDataGridViewTextBoxColumn
            // 
            this.sinifYasDataGridViewTextBoxColumn.DataPropertyName = "SinifYas";
            this.sinifYasDataGridViewTextBoxColumn.HeaderText = "SinifYas";
            this.sinifYasDataGridViewTextBoxColumn.Name = "sinifYasDataGridViewTextBoxColumn";
            // 
            // sinifKapasiteDataGridViewTextBoxColumn
            // 
            this.sinifKapasiteDataGridViewTextBoxColumn.DataPropertyName = "SinifKapasite";
            this.sinifKapasiteDataGridViewTextBoxColumn.HeaderText = "SinifKapasite";
            this.sinifKapasiteDataGridViewTextBoxColumn.Name = "sinifKapasiteDataGridViewTextBoxColumn";
            // 
            // tblSinifBindingSource
            // 
            this.tblSinifBindingSource.DataMember = "Tbl_Sinif";
            this.tblSinifBindingSource.DataSource = this.kresOtomasyonDataSet;
            // 
            // kresOtomasyonDataSet
            // 
            this.kresOtomasyonDataSet.DataSetName = "KresOtomasyonDataSet";
            this.kresOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_SinifTableAdapter
            // 
            this.tbl_SinifTableAdapter.ClearBeforeFill = true;
            // 
            // LisKapasite
            // 
            this.LisKapasite.AutoSize = true;
            this.LisKapasite.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisKapasite.Location = new System.Drawing.Point(327, 68);
            this.LisKapasite.Name = "LisKapasite";
            this.LisKapasite.Size = new System.Drawing.Size(60, 14);
            this.LisKapasite.TabIndex = 10;
            this.LisKapasite.Text = "Kapasite:";
            // 
            // txt_LisKapasite
            // 
            this.txt_LisKapasite.Location = new System.Drawing.Point(404, 65);
            this.txt_LisKapasite.Name = "txt_LisKapasite";
            this.txt_LisKapasite.Size = new System.Drawing.Size(130, 20);
            this.txt_LisKapasite.TabIndex = 9;
            // 
            // txt_LisYas
            // 
            this.txt_LisYas.Location = new System.Drawing.Point(404, 23);
            this.txt_LisYas.Name = "txt_LisYas";
            this.txt_LisYas.Size = new System.Drawing.Size(130, 20);
            this.txt_LisYas.TabIndex = 8;
            // 
            // LisYas
            // 
            this.LisYas.AutoSize = true;
            this.LisYas.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisYas.Location = new System.Drawing.Point(312, 26);
            this.LisYas.Name = "LisYas";
            this.LisYas.Size = new System.Drawing.Size(75, 14);
            this.LisYas.TabIndex = 7;
            this.LisYas.Text = "Yaş Aralığı:";
            // 
            // Frm_SinifListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 715);
            this.Controls.Add(this.LisKapasite);
            this.Controls.Add(this.txt_LisKapasite);
            this.Controls.Add(this.txt_LisYas);
            this.Controls.Add(this.LisYas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SinifSil);
            this.Controls.Add(this.btn_SinifDuzenle);
            this.Controls.Add(this.SinifAd);
            this.Controls.Add(this.txt_SinidAd);
            this.Controls.Add(this.txt_SinifID);
            this.Controls.Add(this.SinifID);
            this.Name = "Frm_SinifListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınıf Listele";
            this.Load += new System.EventHandler(this.Frm_SinifListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kresOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SinifID;
        private System.Windows.Forms.TextBox txt_SinifID;
        private System.Windows.Forms.TextBox txt_SinidAd;
        private System.Windows.Forms.Label SinifAd;
        private System.Windows.Forms.Button btn_SinifDuzenle;
        private System.Windows.Forms.Button btn_SinifSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KresOtomasyonDataSet kresOtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblSinifBindingSource;
        private KresOtomasyonDataSetTableAdapters.Tbl_SinifTableAdapter tbl_SinifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifKapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LisKapasite;
        private System.Windows.Forms.TextBox txt_LisKapasite;
        private System.Windows.Forms.TextBox txt_LisYas;
        private System.Windows.Forms.Label LisYas;
    }
}