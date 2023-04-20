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
    public partial class Frm_GelirListele : Form
    {
        public Frm_GelirListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        int SimdikiWidth = 545;
        int Simdikiheight = 1026;
        private void Frm_GelirListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresOtomasyonDataSet4.Tbl_Gelirler' table. You can move, or remove it, as needed.
            this.tbl_GelirlerTableAdapter.Fill(this.kresOtomasyonDataSet4.Tbl_Gelirler);

            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
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
                SqlCommand komutsil = new SqlCommand("delete from Tbl_Gelirler where GelirID = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", txt_GelirID.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi başarılı.");

                this.tbl_GelirlerTableAdapter.Fill(this.kresOtomasyonDataSet4.Tbl_Gelirler);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Silme işlemi başarısız!" + p.Message);
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutduzenle = new SqlCommand("update Tbl_Gelirler Set GelirAd = @p2, GelirAciklama = @p3, GelirMiktar = @p4, GelirTarih = @p5 where GelirID = @p1", baglanti);
                komutduzenle.Parameters.AddWithValue("@p1", txt_GelirID.Text);
                komutduzenle.Parameters.AddWithValue("@p2", txt_GelirAd.Text);
                komutduzenle.Parameters.AddWithValue("@p3", RichGelirAciklama.Text);
                komutduzenle.Parameters.AddWithValue("@p4", txt_GelirMiktar.Text);
                komutduzenle.Parameters.AddWithValue("@p5", MskGiderTarih.Text);
                komutduzenle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");

                this.tbl_GelirlerTableAdapter.Fill(this.kresOtomasyonDataSet4.Tbl_Gelirler);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız!" + p.Message);
            }
        }

        int secilen;
        string gelirid, gelirad, aciklama, tarih, miktar;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            gelirid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            gelirad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            aciklama = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            miktar = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tarih = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            txt_GelirID.Text = gelirid;
            txt_GelirAd.Text = gelirad;
            RichGelirAciklama.Text = aciklama;
            txt_GelirMiktar.Text = miktar;
            MskGiderTarih.Text = tarih;
        }
    }
}
