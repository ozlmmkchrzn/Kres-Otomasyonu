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
    public partial class Frm_GelirEkle : Form
    {
        public Frm_GelirEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Gelirler(GelirAd, GelirAciklama, GelirMiktar, GelirTarih) values (@p1, @p2, @p3, @p4)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", txt_GelirAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", RichGelirAciklama.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txt_GelirMiktar.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskGelirTarih.Text); 
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("kaydetme işlemi başarılı.");
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Kaydetme işlemi başarısız!" + p.Message);
            }
        }
        int SimdikiWidth = 395;
        int Simdikiheight = 843;
        private void Frm_GelirEkle_Load(object sender, EventArgs e)
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
