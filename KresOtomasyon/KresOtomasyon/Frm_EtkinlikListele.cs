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
    public partial class Frm_EtkinlikListele : Form
    {
        public Frm_EtkinlikListele()
        {
            InitializeComponent();
        }
        int SimdikiWidth = 740;
        int Simdikiheight = 1123;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void Frm_EtkinlikListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresOtomasyonDataSet2.Tbl_Etkinlik' table. You can move, or remove it, as needed.
            this.tbl_EtkinlikTableAdapter.Fill(this.kresOtomasyonDataSet2.Tbl_Etkinlik);

            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        int secilen;
        string etkinlikid, etkinlikad, katilimci, etkinlikaciklama, etkinliktarih;

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutsil = new SqlCommand("delete from Tbl_Etkinlik where EtkinlikID = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", txt_EtkinlikID.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi başarılı.");

                this.tbl_EtkinlikTableAdapter.Fill(this.kresOtomasyonDataSet2.Tbl_Etkinlik);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Silme işlemi gerçekleştirilemedi!");
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutduzenle = new SqlCommand("update Tbl_Etkinlik Set EtkinlikAd = @p1, EtkinlikAciklama = @p2, EtkinlikTarih = @p3,  EtkinlikKatilimci = @p4 where EtkinlikID = @p5", baglanti);
                komutduzenle.Parameters.AddWithValue("@p1", txt_EtkinlikAd.Text);
                komutduzenle.Parameters.AddWithValue("@p2", RichEtkinlikAciklama.Text);
                komutduzenle.Parameters.AddWithValue("@p3", MskEtkinlikTarih.Text);
                komutduzenle.Parameters.AddWithValue("@p4", RichKatilimci.Text);
                komutduzenle.Parameters.AddWithValue("@p5", txt_EtkinlikID.Text);
                komutduzenle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");

                this.tbl_EtkinlikTableAdapter.Fill(this.kresOtomasyonDataSet2.Tbl_Etkinlik);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız!" + p.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            etkinlikid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            etkinlikad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            etkinlikaciklama = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            etkinliktarih = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            katilimci = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            

            txt_EtkinlikID.Text = etkinlikid;
            txt_EtkinlikAd.Text = etkinlikad;
            RichKatilimci.Text = katilimci;
            RichEtkinlikAciklama.Text = etkinlikaciklama;
            MskEtkinlikTarih.Text = etkinliktarih;
            
        }

    }
}
