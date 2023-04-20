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
    public partial class Frm_GiderListele : Form
    {
        public Frm_GiderListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        int SimdikiWidth = 513;
        int Simdikiheight = 1086;
        private void Frm_GiderListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresOtomasyonDataSet3.Tbl_Giderler' table. You can move, or remove it, as needed.
            this.tbl_GiderlerTableAdapter.Fill(this.kresOtomasyonDataSet3.Tbl_Giderler);

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
                SqlCommand komutsil = new SqlCommand("delete from Tbl_Giderler where GiderID = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", txt_GiderID.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi başarılı.");

                this.tbl_GiderlerTableAdapter.Fill(this.kresOtomasyonDataSet3.Tbl_Giderler);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Silme işlemi gerçekleştirilemedi!" + p.Message);
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutduzenle = new SqlCommand("update Tbl_Giderler Set GiderAd = @p2, GiderAciklama = @p3, GiderMiktar = @p4, GiderTarih = @p5 where GiderID = @p1", baglanti);
                komutduzenle.Parameters.AddWithValue("@p1", txt_GiderID.Text);
                komutduzenle.Parameters.AddWithValue("@p2", txt_GiderAd.Text);
                komutduzenle.Parameters.AddWithValue("@p3", RichGiderAciklama.Text);
                komutduzenle.Parameters.AddWithValue("@p4", txt_GiderMiktar.Text);
                komutduzenle.Parameters.AddWithValue("@p5", MskGiderTarih.Text);
                komutduzenle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");

                this.tbl_GiderlerTableAdapter.Fill(this.kresOtomasyonDataSet3.Tbl_Giderler);
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız!" + p.Message);
            }
        }

        int secilen;
        string giderid, giderad, miktar, aciklama, tarih;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            giderid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            giderad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            aciklama = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            miktar = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tarih = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            txt_GiderID.Text = giderid;
            txt_GiderAd.Text = giderad;
            txt_GiderMiktar.Text = miktar;
            RichGiderAciklama.Text = aciklama;
            MskGiderTarih.Text = tarih;
        }
    }
}
