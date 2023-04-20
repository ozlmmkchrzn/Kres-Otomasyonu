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
    public partial class Frm_SinifEkle : Form
    {
        public Frm_SinifEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Sinif(SinifAd ,SinifYas, SinifKapasite) values (@p1, @p2, @p3)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", txt_EkleSinifAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txt_EkleSinifYas.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txt_EkleSinifKapasite.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Kayıt Oluşturulamadı!");
            }
        }
        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_SinifEkle_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }
    }
}
