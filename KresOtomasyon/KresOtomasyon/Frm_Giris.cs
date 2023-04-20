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
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");


        int SimdikiWidth = 782;
        int Simdikiheight = 465;
        private void Frm_Giris_Load(object sender, EventArgs e)
        {
            txt_Sifre.PasswordChar = '*';

            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand komutgiris = new SqlCommand("Select * from Tbl_Kullanici where KullaniciAd = '" + txt_KullaniciAd.Text + "' And KullaniciSifre = '" + txt_Sifre.Text + "'", baglanti);
                komutgiris.ExecuteNonQuery();
                SqlDataReader okugiris = komutgiris.ExecuteReader();

                if (okugiris.Read())
                {
                    MessageBox.Show("Giriş Başarılı.");

                    Frm_AnaSayfa frm_AnaSayfa = new Frm_AnaSayfa();
                    frm_AnaSayfa.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş! Lütfen tekrar deneyiniz!");
                }
                baglanti.Close();
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata!" + p.Message);
            }


            //baglanti.Open();
            //SqlCommand komutsorgu = new SqlCommand("Selecet * from Tbl_Kullanici where KullaniciAd = @1 and KullaniciSifre = @p2", baglanti);
            //komutsorgu.Parameters.AddWithValue("@p1", txt_KullaniciAd.Text);
            //komutsorgu.Parameters.AddWithValue("@p2", txt_Sifre.PasswordChar);
            //komutsorgu.ExecuteNonQuery();
            //SqlDataReader oku;
            //oku = komutsorgu.ExecuteReader();

            //if (oku.Read())
            //{
            //    MessageBox.Show("Giriş başarılı.");
            //}
            //else
            //{
            //    MessageBox.Show("Giriş başarısız! Lütfen tekrar deneyiniz!");
            //}
            //baglanti.Close();
        }
    }
}
