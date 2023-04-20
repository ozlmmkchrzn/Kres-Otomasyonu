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
    public partial class Frm_BorcKayit : Form
    {
        
        public Frm_BorcKayit()
        {
            InitializeComponent();
        }

        

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {




                try
                {
                    baglanti.Open();
                    SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Borclar (OgrAd, OgrSoyad, TaksitSayisi, KalanBorc) values (@p1, @p2, @p3, @p4)", baglanti);
                    komutkaydet.Parameters.AddWithValue("@p1", ograd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", ogrsoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", txt_Taksit.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", txt_ToplamBorc.Text);
                    komutkaydet.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (Exception c)
                {
                    MessageBox.Show("Hata! Lütfen tekrar deneyiniz! " + c.Message);
                }

                MessageBox.Show("Kayıt işlemi başarılı.");
            }
            catch (Exception p )
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz! " + p.Message);
            }
        }
        
        private void Frm_BorcKayit_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select OgrID from Tbl_OgrTemel", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                BorcOgrID.Text = oku[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutid = new SqlCommand("select BorcID from Tbl_Borclar", baglanti);
            SqlDataReader okuid = komutid.ExecuteReader();
            while (okuid.Read())
            {
                BorcID.Text = okuid[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update Tbl_OgrTemel set BorcID = @b1 where OgrID = @b2", baglanti);
            komutguncelle.Parameters.AddWithValue("@b1", BorcID.Text);
            komutguncelle.Parameters.AddWithValue("@b2", BorcOgrID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();

            try
            {
                baglanti.Open();
                SqlCommand komutad = new SqlCommand("select OgrAd, OgrSoyad from Tbl_OgrTemel where BorcID = @c1", baglanti);
                komutad.Parameters.AddWithValue("@c1", BorcID.Text);
                SqlDataReader okuad = komutad.ExecuteReader();
                while (okuad.Read())
                {
                    ograd.Text = okuad[2].ToString();
                    ogrsoyad.Text = okuad[3].ToString();
                }
                baglanti.Close();
            }
            catch (Exception q)
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz! " + q.Message);
            }

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
