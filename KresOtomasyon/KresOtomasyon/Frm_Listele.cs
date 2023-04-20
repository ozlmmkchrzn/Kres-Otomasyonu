using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;
namespace KresOtomasyon
{
    public partial class Frm_Listele : Form
    {
        public Frm_Listele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        int SimdikiWidth;
        int Simdikiheight;

        private void Frm_Listele_Load(object sender, EventArgs e)
        {
            //this.Location = new System.Drawing.Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //System.Drawing.Rectangle ClienCozunurluk = new System.Drawing.Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

            // TODO: This line of code loads data into the 'kresOtomasyonDataSet12.Tbl_OgrTemel' table. You can move, or remove it, as needed.
            this.tbl_OgrTemelTableAdapter3.Fill(this.kresOtomasyonDataSet12.Tbl_OgrTemel);

            

            baglanti.Open();
            SqlCommand komutsinif = new SqlCommand("Select SinifAd from Tbl_Sinif", baglanti);
            SqlDataReader okusinif = komutsinif.ExecuteReader();
            while (okusinif.Read())
            {
                ComboLisSinif.Items.Add(okusinif[0].ToString());
            }
            okusinif.Close();
            baglanti.Close();

            
        }

        private void btn_LisSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutsil = new SqlCommand("delete from Tbl_OgrTemel where OgrID = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", txt_OgrID.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi başarılı.");

                this.tbl_OgrTemelTableAdapter3.Fill(this.kresOtomasyonDataSet12.Tbl_OgrTemel);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Silme işlemi başarısız!" + p.Message);
            }
        }

        private void txt_LisOgrAd_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void txt_LisOgrSoyad_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void txt_LisOgrNo_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void ComboLisSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void ComboLisCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void checkBoxServis_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void checkBoxSut_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            txt_LisOgrAd.Clear();
            txt_LisOgrNo.Clear();
            txt_LisOgrSoyad.Clear();
            txt_OgrID.Clear();
            checkBoxSut.Checked = false;
            checkBoxServis.Checked = false;
            ComboLisCinsiyet.SelectedItem = null;
            ComboLisSinif.SelectedItem = null;
            this.tbl_OgrTemelTableAdapter3.Fill(this.kresOtomasyonDataSet12.Tbl_OgrTemel);
        }

        public int sut;
        

        int secilen, ogrsut, ogrservis;
        string id, ad, soyad, no, cinsiyet, sinif;

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridView1[i,j].Value;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            Frm_OgrKartTemel frm_OgrKart = new Frm_OgrKartTemel();
            frm_OgrKart.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm_OgrKart.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm_OgrKart.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm_OgrKart.no = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm_OgrKart.sinif = SinifAdGetir(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            frm_OgrKart.cinsiyet = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm_OgrKart.kayittarih = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm_OgrKart.referans = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm_OgrKart.ogrenimsekli = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm_OgrKart.ogrenimdurumu = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frm_OgrKart.sut = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[10].Value.ToString());
            frm_OgrKart.servis = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[11].Value.ToString());
            frm_OgrKart.tanidik = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[12].Value.ToString());
            frm_OgrKart.notlar = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            frm_OgrKart.guzergah = GuzergahAdGetir(dataGridView1.Rows[secilen].Cells[14].Value.ToString());
            frm_OgrKart.resim = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            frm_OgrKart.Show();

            this.tbl_OgrTemelTableAdapter3.Fill(this.kresOtomasyonDataSet12.Tbl_OgrTemel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            no = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            sinif = SinifAdGetir(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            cinsiyet = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            ogrsut = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[10].Value.ToString());
            ogrservis = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[11].Value.ToString());

            txt_OgrID.Text = id;
            txt_LisOgrAd.Text = ad;
            txt_LisOgrSoyad.Text = soyad;
            txt_LisOgrNo.Text = no;
            ComboLisCinsiyet.Text = cinsiyet;
            ComboLisSinif.Text = sinif;

            if (ogrsut == 1)
            {
                checkBoxSut.Checked = true;
            }
            else
            {
                checkBoxSut.Checked = false;
            }

            if (ogrservis == 1)
            {
                checkBoxServis.Checked = true;
            }
            else
            {
                checkBoxServis.Checked = false;
            }
        }

        private string SinifAdGetir(string SinifID)
        {
            string SinifAd = "";

            baglanti.Open();
            SqlCommand komutsinifid = new SqlCommand("select * from Tbl_Sinif where SinifID = '" + dataGridView1.Rows[secilen].Cells[4].Value.ToString() + "'", baglanti);
            komutsinifid.ExecuteNonQuery();
            SqlDataReader okusinif = komutsinifid.ExecuteReader();
            while (okusinif.Read())
            {
                SinifAd = okusinif["SinifAd"].ToString();
            }
            okusinif.Close();
            baglanti.Close();
            return SinifAd;
        }

        private string GuzergahAdGetir(string GuzergahID)
        {
            string GuzergahAd = "";

            baglanti.Open();
            SqlCommand komutguzergah = new SqlCommand("select * from Tbl_Guzergah where GuzergahID = '" + dataGridView1.Rows[secilen].Cells[14].Value.ToString() + "'", baglanti);
            komutguzergah.ExecuteNonQuery();
            SqlDataReader okuguzergah = komutguzergah.ExecuteReader();
            while (okuguzergah.Read())
            {
                GuzergahAd = okuguzergah["GuzergahAd"].ToString();
            }
            okuguzergah.Close();
            baglanti.Close();
            return GuzergahAd;
        }

        public string SinifIDGetir(string SinifAd)
        {
            string SinifID = "";

            SqlCommand komutsinifad = new SqlCommand("Select * from Tbl_Sinif where SinifAd = @p7", baglanti);
            komutsinifad.Parameters.AddWithValue("@p7", ComboLisSinif.Text);
            komutsinifad.ExecuteNonQuery();
            SqlDataReader okusinif = komutsinifad.ExecuteReader();
            while (okusinif.Read())
            {
                SinifID = okusinif["SinifID"].ToString();
            }
            okusinif.Close();
            return SinifID;
        }

        private void Filtrele()
        {
            this.kresOtomasyonDataSet12.Tbl_OgrTemel.Clear();
            
            if (string.IsNullOrEmpty(ComboLisSinif.Text))
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Tbl_OgrTemel where OgrAd like '%" + txt_LisOgrAd.Text + "%' and OgrSoyad like '%" + txt_LisOgrSoyad.Text + "%' and OgrNo like '%" + txt_LisOgrNo.Text + "%' and OgrCinsiyet like '%" + ComboLisCinsiyet.Text + "%' and (OgrSut = " + (checkBoxSut.Checked ? "1)" : " 0 or OgrSut = 1) and (OgrServis = " + (checkBoxServis.Checked ? "1)" : " 0 or OgrServis = 1) " + "")), baglanti);
                adtr.Fill(this.kresOtomasyonDataSet12.Tbl_OgrTemel);
                dataGridView1.DataSource = this.kresOtomasyonDataSet12.Tbl_OgrTemel;
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Tbl_OgrTemel where OgrAd like '%" + txt_LisOgrAd.Text + "%' and OgrSoyad like '%" + txt_LisOgrSoyad.Text + "%' and OgrNo like '%" + txt_LisOgrNo.Text + "%' and OgrCinsiyet like '%" + ComboLisCinsiyet.Text + "%' and (OgrSut = " + (checkBoxSut.Checked ? "1)" : " 0 or OgrSut = 1) and (OgrServis = " + (checkBoxServis.Checked ? "1)" : " 0 or OgrServis = 1) and SinifID = " + SinifIDGetir(ComboLisSinif.Text) + "")), baglanti);
                adtr.Fill(this.kresOtomasyonDataSet12.Tbl_OgrTemel);
                dataGridView1.DataSource = this.kresOtomasyonDataSet12.Tbl_OgrTemel;
                baglanti.Close();
            }

        }
    }
}
