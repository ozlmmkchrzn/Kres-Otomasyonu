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

namespace KresOtomasyon
{
    public partial class Frm_SinifListele : Form
    {
        public Frm_SinifListele()
        {
            InitializeComponent();
        }
        int SimdikiWidth;
        int Simdikiheight;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void Frm_SinifListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresOtomasyonDataSet.Tbl_Sinif' table. You can move, or remove it, as needed.
            this.tbl_SinifTableAdapter.Fill(this.kresOtomasyonDataSet.Tbl_Sinif);

            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void btn_SinifSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutsil = new SqlCommand("delete from Tbl_Sinif where SinifID = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", txt_SinifID.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi başarılı.");

                this.tbl_SinifTableAdapter.Fill(this.kresOtomasyonDataSet.Tbl_Sinif);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Silme işlemi başarısız." + p.Message);
            }

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sinifid, sinifad, sinifyas, sinifkapasite;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            sinifid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            sinifad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sinifyas = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sinifkapasite = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txt_SinifID.Text = sinifid;
            txt_SinidAd.Text = sinifad;
            txt_LisYas.Text = sinifyas;
            txt_LisKapasite.Text = sinifkapasite;
        }

        private void btn_SinifDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutduzenle = new SqlCommand("update Tbl_Sinif Set SinifAd = @p1, SinifYas = @p2, SinifKapasite = @p3 where SinifID = @p4", baglanti);
                komutduzenle.Parameters.AddWithValue("@p4", txt_SinifID.Text);
                komutduzenle.Parameters.AddWithValue("@p1", txt_SinidAd.Text);
                komutduzenle.Parameters.AddWithValue("@p2", txt_LisYas.Text);
                komutduzenle.Parameters.AddWithValue("@p3", txt_LisKapasite.Text);
                komutduzenle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");

                this.tbl_SinifTableAdapter.Fill(this.kresOtomasyonDataSet.Tbl_Sinif);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız!" + p.Message);
            }
        }
    }
}
