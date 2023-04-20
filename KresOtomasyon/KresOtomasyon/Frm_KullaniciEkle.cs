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
    public partial class Frm_KullaniciEkle : Form
    {
        public Frm_KullaniciEkle()
        {
            InitializeComponent();
        }
        int SimdikiWidth;
        int Simdikiheight;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void Frm_KullaniciEkle_Load(object sender, EventArgs e)
        {
            txt_KullaniciSifre.PasswordChar = '*';
            txt_SifreTekrar.PasswordChar = '*';

            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            

            if (txt_KullaniciSifre.Text == txt_SifreTekrar.Text)
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Kullanici(KullaniciAd, KullaniciSifre) values (@p1, @p2)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", txt_KullaniciAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txt_KullaniciSifre.Text);
                komutkaydet.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı.");
            }
            else
            {
                MessageBox.Show("Hata! Şifreler aynı değil! Lütfen tekrar deneyiniz!");
            }
        }

        private void txt_KullaniciSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
