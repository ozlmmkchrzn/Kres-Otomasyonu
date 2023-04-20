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
    public partial class Frm_GiderEkle : Form
    {
        public Frm_GiderEkle()
        {
            InitializeComponent();
        }
        int SimdikiWidth = 434;
        int Simdikiheight = 929;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void Frm_GiderEkle_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void btn_İptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Giderler(GiderAd, GiderAciklama, GiderMiktar, GiderTarih) values (@p1, @p2, @p3, @p4)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", txt_GiderAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", RichGiderAciklama.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txt_GiderMiktar.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskGiderTarih.Text);
                komutkaydet.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Kaydetme işlemi gerçekleştirilemedi!" + p.Message);
            }
        }
    }
}
