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
    public partial class Frm_Aile : Form
    {

        int SimdikiWidth = 1015;
        int Simdikiheight = 870;
        public Frm_Aile()
        {
            InitializeComponent();
        }

       

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void Frm_Aile_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
            
        }


        private void btn_AileIleri_Click(object sender, EventArgs e)
        {
            //Ogrid varsa update
            int annesag = 0;
            int anneoz = 0;
            int babasag = 0;
            int babaoz = 0;

            
                if (checkAnneSag.Checked)
                {
                    annesag = 1;
                }
                else
                {
                    annesag = 0;
                }

                if (checkAnneOz.Checked)
                {
                    anneoz = 1;
                }
                else
                {
                    anneoz = 0;
                }

                if (CheckBabaSag.Checked)
                {
                    babasag = 1;
                }
                else
                {
                    babasag = 0;
                }

                if (CheckBabaOz.Checked)
                {
                    babaoz = 1;
                }
                else
                {
                    babaoz = 0;
                }


                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select OgrID from Tbl_OgrTemel", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        AileOgrID.Text = oku[0].ToString();
                    }
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komutid = new SqlCommand("select AileID from Tbl_Aile", baglanti);
                    SqlDataReader okuid = komutid.ExecuteReader();
                    while (okuid.Read())
                    {
                        AileID.Text = okuid[0].ToString();
                    }
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Aile (AnneAd, AnneTC, AnneDogTarih, AnneMeslek, AnneEgitim, AnneCalismaSaat, AnneSag, AnneOz, AnneEvTel, AnneIsTel, AnneCepTel, AnneMail, AnneEvAdres, AnneIsAdres, BabaAd, BabaTC, BabaDogTarih, BabaMeslek, BabaEgitim, BabaCalisSaat, BabaSag, BabaOz, BabaEvTel, BabaIsTel, BabaCepTel, BabaMail, BabaIsAdres, BabaEvAdres) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28)", baglanti);
                    komutkaydet.Parameters.AddWithValue("@p1", txt_AnneAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", txt_AnneTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", MskAnneDog.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", txt_AnneMeslek.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", txt_AnneEgitim.Text);
                    komutkaydet.Parameters.AddWithValue("@p6", txt_AnneCalismaSaat.Text);
                    komutkaydet.Parameters.AddWithValue("@p7", annesag);
                    komutkaydet.Parameters.AddWithValue("@p8", anneoz);
                    komutkaydet.Parameters.AddWithValue("@p9", txt_AnneEvTel.Text);
                    komutkaydet.Parameters.AddWithValue("@p10", txt_AnneIsTel.Text);
                    komutkaydet.Parameters.AddWithValue("@p11", txt_AnneCeptel.Text);
                    komutkaydet.Parameters.AddWithValue("@p12", txt_AnneMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p13", RichAnneEvAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p14", RichAnneIsAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p15", txt_BabaAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p16", txt_BabaTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p17", MskBabaDog.Text);
                    komutkaydet.Parameters.AddWithValue("@p18", txt_BabaMeslek.Text);
                    komutkaydet.Parameters.AddWithValue("@p19", txt_BabaEgitim.Text);
                    komutkaydet.Parameters.AddWithValue("@p20", txt_BabaCalisSaat.Text);
                    komutkaydet.Parameters.AddWithValue("@p21", babasag);
                    komutkaydet.Parameters.AddWithValue("@p22", babaoz);
                    komutkaydet.Parameters.AddWithValue("@p23", txt_BabaEvTel.Text);
                    komutkaydet.Parameters.AddWithValue("@p24", txt_BabaIsTel.Text);
                    komutkaydet.Parameters.AddWithValue("@p25", txt_BabaCepTel.Text);
                    komutkaydet.Parameters.AddWithValue("@p26", txt_BabaMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p27", RichBabaIsAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p28", RichBabaEvAdres.Text);
                    komutkaydet.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komutidcek = new SqlCommand("Select AileID from Tbl_Aile", baglanti);
                    SqlDataReader okuidcek = komutidcek.ExecuteReader();
                    while (okuidcek.Read())
                    {
                        AileID.Text = okuidcek[0].ToString();
                    }
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komutguncelle = new SqlCommand("update Tbl_OgrTemel set AileID = @b1 where OgrID = @b2", baglanti);
                    komutguncelle.Parameters.AddWithValue("@b1", AileID.Text);
                    komutguncelle.Parameters.AddWithValue("@b2", AileOgrID.Text);
                    komutguncelle.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt Başarılı.");

                    Frm_BorcKayit frm_BorcKayit = new Frm_BorcKayit();
                    frm_BorcKayit.Show();
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata! Lütfen tekrar deneyin!");
                }

        }

    }
}
