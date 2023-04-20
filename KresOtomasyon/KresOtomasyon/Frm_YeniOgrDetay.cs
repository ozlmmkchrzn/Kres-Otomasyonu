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
    public partial class Frm_YeniOgrDetay : Form
    {
        public Frm_YeniOgrDetay()
        {
            InitializeComponent();
        }
        
        

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        int ogrkira = 0;
        int ogryemek = 0;
        int ogroda = 0;

        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_YeniOgrDetay_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

            baglanti.Open();
            SqlCommand komutidcek = new SqlCommand("Select OgrID from Tbl_OgrTemel", baglanti);
            SqlDataReader okuidcek = komutidcek.ExecuteReader();
            while (okuidcek.Read())
            {
                OgrID.Text = okuidcek[0].ToString();
            }
            baglanti.Close();

            
        }
        

        private void btn_OgrDetayIleri_Click(object sender, EventArgs e)
        {

            int ogroda = 0;
            int ogrkira = 0;
            int ogryemek = 0;

            if (checkBoxOgrOda.Checked)
            {
                ogroda = 1;
            }
            else
            {
                ogroda = 0;
            }

            if (checkBoxOgrKira.Checked)
            {
                ogrkira = 1;
            }
            else
            {
                ogrkira = 0;
            }

            if (checkBoxOgrYemek.Checked)
            {
                ogryemek = 1;
            }
            else
            {
                ogryemek = 0;
            }


            try
            {
                baglanti.Open();
                SqlCommand komutidcek = new SqlCommand("Select OgrID from Tbl_OgrTemel", baglanti);
                SqlDataReader okuidcek = komutidcek.ExecuteReader();
                while (okuidcek.Read())
                {
                    OgrID.Text = okuidcek[0].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komutid = new SqlCommand("select OgrDetayID from Tbl_OgrDetay", baglanti);
                SqlDataReader okuid = komutid.ExecuteReader();
                while (okuid.Read())
                {
                    OgrDetayID.Text = okuid[0].ToString();
                    //Ogrid = okuid[0].ToString();
                }
                baglanti.Close();

                    baglanti.Open();
                    SqlCommand komutkaydet = new SqlCommand("insert into Tbl_OgrDetay(OgrTC, OgrDogTarih, OgrSeriNo, OgrUyruk, OgrSonTarih, OgrAdres, OgrKira, OgrOda, OgrYemek, OgrSevdigiYemek, OgrSevmedigiYemek, OgrFobi, OgrSevdigiSeyler, OgrCocukIletisim) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14)", baglanti);
                    komutkaydet.Parameters.AddWithValue("@p1", txt_OgrTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", MskOgrDogTar.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", txt_OgrSeriNo.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", txt_OgrUyruk.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", MskOgrSonTarih.Text);
                    komutkaydet.Parameters.AddWithValue("p6", RichAdres.Text);
                    komutkaydet.Parameters.AddWithValue("p7", ogrkira);
                    komutkaydet.Parameters.AddWithValue("@p8", ogroda);
                    komutkaydet.Parameters.AddWithValue("@p9", ogryemek);
                    komutkaydet.Parameters.AddWithValue("@p10", RichOgrSevdigiYemek.Text);
                    komutkaydet.Parameters.AddWithValue("@p11", RichOgrSevmedigiYemek.Text);
                    komutkaydet.Parameters.AddWithValue("@p12", RichFobi.Text);
                    komutkaydet.Parameters.AddWithValue("@p13", RichOgrSevdigiSeyler.Text);
                    komutkaydet.Parameters.AddWithValue("@p14", RichOgrCocukIletisim.Text);
                    komutkaydet.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt Başarılı.");

                    Frm_OgrSaglik formogrsaglik = new Frm_OgrSaglik();
                    formogrsaglik.Show();
                    Hide();
                
                

                baglanti.Open();
                SqlCommand komutguncelle = new SqlCommand("update Tbl_OgrTemel set OgrDetayID = @b1 where OgrID = @b2", baglanti);
                komutguncelle.Parameters.AddWithValue("@b1", OgrDetayID.Text);
                komutguncelle.Parameters.AddWithValue("@b2", OgrID.Text);
                komutguncelle.ExecuteNonQuery();
                baglanti.Close();
                
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyin!" + p.Message);
            }

            
        }
    }
}
