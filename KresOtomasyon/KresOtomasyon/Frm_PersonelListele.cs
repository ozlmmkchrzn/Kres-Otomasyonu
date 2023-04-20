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
    public partial class Frm_PersonelListele : Form
    {
        public Frm_PersonelListele()
        {
            InitializeComponent();
        }
        int SimdikiWidth;
        int Simdikiheight;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        //DataTable tablo = new DataTable();
        private void Frm_PersonelListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresOtomasyonDataSet13.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter3.Fill(this.kresOtomasyonDataSet13.Tbl_Personel);

            //this.Location = new System.Drawing.Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //System.Drawing.Rectangle ClienCozunurluk = new System.Drawing.Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {             
                baglanti.Open();
                SqlCommand komutsil = new SqlCommand("delete from Tbl_Personel where PersonelID = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", txt_PersonelID.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme İşlemi Başarılı.");
                this.tbl_PersonelTableAdapter3.Fill(this.kresOtomasyonDataSet13.Tbl_Personel);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Silme işlemi gerçekleştirilemedi!");
            }
        }

        //DataView Filtrele()
        //{
        //    DataView dv = new DataView();
        //    dv = this.kresOtomasyonDataSet1.Tbl_Personel.DefaultView;
        //    dv.RowFilter = "PersonelAd like '" + txt_ListelePersonelAd.Text + "%'";
        //    dataGridView1.DataSource = dv;
        //    return dv;
        //}


        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id, ad, unvan, ogretmen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            unvan = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txt_PersonelID.Text = id;
            txt_ListelePersonelAd.Text = ad;
            txt_LisPersonelUnvan.Text = unvan;
            
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter3.Fill(this.kresOtomasyonDataSet13.Tbl_Personel);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            Frm_PersonelKart frm_PersonelKart = new Frm_PersonelKart();
            frm_PersonelKart.perid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm_PersonelKart.perad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm_PersonelKart.perunvan = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm_PersonelKart.perbaslamatarih = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm_PersonelKart.perayrilistarih = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm_PersonelKart.permaas = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm_PersonelKart.perdurum = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm_PersonelKart.pertahsil = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm_PersonelKart.percalismasekli = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frm_PersonelKart.permukbaslamatarih = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            frm_PersonelKart.permukbitistarih = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            frm_PersonelKart.permesai = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            frm_PersonelKart.perevtel = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            frm_PersonelKart.perceptel = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            frm_PersonelKart.permail = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            frm_PersonelKart.peradres = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
            frm_PersonelKart.pertc = dataGridView1.Rows[secilen].Cells[17].Value.ToString();
            frm_PersonelKart.perdogumtarih = dataGridView1.Rows[secilen].Cells[18].Value.ToString();
            frm_PersonelKart.perserino = dataGridView1.Rows[secilen].Cells[19].Value.ToString();
            frm_PersonelKart.peruyruk = dataGridView1.Rows[secilen].Cells[20].Value.ToString();
            frm_PersonelKart.personkullanmatarih = dataGridView1.Rows[secilen].Cells[21].Value.ToString();
            frm_PersonelKart.personelresim = dataGridView1.Rows[secilen].Cells[22].Value.ToString();
            frm_PersonelKart.Show();
        }

        private void Filtrele()
        {
            this.kresOtomasyonDataSet13.Tbl_Personel.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Tbl_Personel where PersonelAd like '%" + txt_ListelePersonelAd.Text + "%' and (PersonelOgretmen = " + (CheckOgretmen.Checked ? "1)" : " 0 or PersonelOgretmen = 1) and PersonelUnvan like '%" + txt_LisPersonelUnvan.Text + "%'"), baglanti);
            adtr.Fill(this.kresOtomasyonDataSet13.Tbl_Personel);
            dataGridView1.DataSource = this.kresOtomasyonDataSet13.Tbl_Personel;
            baglanti.Close();
        }

        private void txt_ListelePersonelAd_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

       
        private void CheckOgretmen_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void txt_LisPersonelUnvan_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

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
                    alan2.Cells[2, 1] = dataGridView1[i, j].Value;
                }
            }
        }
    }
}
