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
    public partial class Frm_YeniEtkinlik : Form
    {
        public Frm_YeniEtkinlik()
        {
            InitializeComponent();
        }
        int SimdikiWidth;
        int Simdikiheight;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void Frm_YeniEtkinlik_Load(object sender, EventArgs e)
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
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Etkinlik(EtkinlikAd, EtkinlikAciklama, EtkinlikTarih, EtkinlikKatilimci) values(@p1, @p2, @p3, @p4)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", txt_EtkinlikAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", RichEtkinlikAciklama.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskEtkinlikTarih.Text);
                komutkaydet.Parameters.AddWithValue("p4", RichKatilimci.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Kayıt BAşarısız!" + p.Message);
            }
        }
    }
}
