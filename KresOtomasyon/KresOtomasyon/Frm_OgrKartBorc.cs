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
    public partial class Frm_OgrKartBorc : Form
    {
        public Frm_OgrKartBorc()
        {
            InitializeComponent();
        }
        int SimdikiWidth;
        int Simdikiheight;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        private void Frm_OgrKartBorc_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

            baglanti.Open();
            SqlCommand komutid = new SqlCommand("select BorcID from Tbl_Borclar", baglanti);
            SqlDataReader okuid = komutid.ExecuteReader();
            while (okuid.Read())
            {
                BorcID.Text = okuid[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Borclar where BorcID = @b1", baglanti);
            komut.Parameters.AddWithValue("@b1", BorcID.Text);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txt_Taksit.Text = oku[1].ToString();
                txt_ToplamBorc.Text = oku[3].ToString();
            }
            baglanti.Close();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Frm_Aile frm_Aile = new Frm_Aile();
            frm_Aile.Show();
            Hide();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutguncelle = new SqlCommand("update Tbl_Borclar set TaksitSayisi = @p2, KalanBorc = @p3 where BorcID = @p1", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", BorcID.Text);
                komutguncelle.Parameters.AddWithValue("@p2", txt_Taksit.Text);
                komutguncelle.Parameters.AddWithValue("@p3", txt_ToplamBorc.Text);
                komutguncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız! " + p.Message);
            }
        }
    }
}
