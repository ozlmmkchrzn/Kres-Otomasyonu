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
    public partial class Frm_YeniOgrTemel : Form
    {
        public string Ogrid = "";
        public Frm_YeniOgrTemel()
        {
            InitializeComponent();
        }

        

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        public string ogrno, ograd, ogrsoyad, ogrcinsiyet, ogrkayittarih, ogrreferans, ogrogrenimsekli, ogrdurum, ogrresim, ogrnotlar;
        public int ogrservis, ogrsut, ogrtanidik, sinifid, guzergahid;
        public string SinifIDGetir(string SinifAd)
        {
            string SinifID = "";
            
            SqlCommand komutsinifad = new SqlCommand("Select * from Tbl_Sinif where SinifAd = @p7", baglanti);
            komutsinifad.Parameters.AddWithValue("@p7", comboBoxSinif.Text);
            komutsinifad.ExecuteNonQuery();
            SqlDataReader okusinif = komutsinifad.ExecuteReader();
            while (okusinif.Read())
            {
                SinifID = okusinif["SinifID"].ToString();
            }
            okusinif.Close();
            return SinifID;
        }

        

        private string GuzergahIDGetir(string GuzergahAd)
        {
            string GuzergahID = "";

            SqlCommand komutguzergahad = new SqlCommand("Select * from Tbl_Guzergah where GuzergahAd = @p11", baglanti);
            komutguzergahad.Parameters.AddWithValue("@p11", comboBoxGuzergah.Text);
            komutguzergahad.ExecuteNonQuery();
            SqlDataReader okuguzergahad = komutguzergahad.ExecuteReader();
            while (okuguzergahad.Read())
            {
                GuzergahID = okuguzergahad["GuzergahID"].ToString();
            }
            okuguzergahad.Close();
            return GuzergahID;
        }

        private string SinifAdGetir(int SinifID)
        {
            string SinifAd = "";

            baglanti.Open();
            SqlCommand komutsinifid = new SqlCommand("select * from Tbl_Sinif where SinifID = @b1", baglanti);
            komutsinifid.Parameters.AddWithValue("@b1", sinifadi.Text);
            komutsinifid.ExecuteNonQuery();
            SqlDataReader okusinifid = komutsinifid.ExecuteReader();
            while (okusinifid.Read())
            {
                SinifAd = okusinifid["SinifAd"].ToString();
            }
            okusinifid.Close();
            baglanti.Close();
            return SinifAd;
        }

        private string GuzergahAdGetir(int GuzergahID)
        {
            string GuzergahAd = "";

            baglanti.Open();
            SqlCommand komutguzergahad = new SqlCommand("select * from Tbl_Guzergah where GuzergahID = @b2", baglanti);
            komutguzergahad.Parameters.AddWithValue("@b2", Guzergahad.Text);
            komutguzergahad.ExecuteNonQuery();
            SqlDataReader okuguzergahad = komutguzergahad.ExecuteReader();
            while (okuguzergahad.Read())
            {
                GuzergahAd = okuguzergahad["GuzergahAd"].ToString();
            }
            okuguzergahad.Close();
            baglanti.Close();
            return GuzergahAd;
        }

        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_YeniOgrTemel_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));


            baglanti.Open();
            SqlCommand komutsinif = new SqlCommand("Select SinifAd from Tbl_Sinif", baglanti);
            SqlDataReader okusinif = komutsinif.ExecuteReader();
            while (okusinif.Read())
            {
                comboBoxSinif.Items.Add(okusinif[0].ToString());
            }
            okusinif.Close();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutguzergah = new SqlCommand("Select GuzergahAd from Tbl_Guzergah", baglanti);
            SqlDataReader okuguzergah = komutguzergah.ExecuteReader();
            while (okuguzergah.Read())
            {
                comboBoxGuzergah.Items.Add(okuguzergah[0].ToString());
            }
            okuguzergah.Close();
            baglanti.Close();

            
            baglanti.Open();
            SqlCommand komutsinifid = new SqlCommand("select SinifID from Tbl_Sinif", baglanti);
            SqlDataReader okusinifid = komutsinifid.ExecuteReader();
            while (okusinifid.Read())
            {
                sinifadi.Text = okusinifid[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutguzergahid = new SqlCommand("select GuzergahID from Tbl_Guzergah", baglanti);
            SqlDataReader okuguzergahid = komutguzergahid.ExecuteReader();
            while (okuguzergahid.Read())
            {
                Guzergahad.Text = okuguzergahid[0].ToString();
            }
            baglanti.Close();

        }

        public int deger;

        

        private void btn_Ileri_Click(object sender, EventArgs e)
        {
            int sutdurum = 0;
            if (checkBoxSut.Checked)
            {
                sutdurum = 1;
            }
            else
            {
                sutdurum = 0;
            }

            int servisdurum = 0;
            if (checkBoxServis.Checked)
            {
                servisdurum = 1;
            }
            else
            {
                servisdurum = 0;
            }

            int tanidikdurum = 0;
            if (checkBoxTanidik.Checked)
            {
                tanidikdurum = 1;
            }
            else
            {
                tanidikdurum = 0;
            }

            //insert
            
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_OgrTemel (OgrNo, OgrAd, OgrSoyad, OgrCinsiyet, OgrKayitTarih, OgrReferans, SinifID,  OgrOgrenimSekli, OgrDurum, GuzergahID, OgrServis, OgrSut, OgrTanidik, OgrNotlar, OgrResim) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p11, @p12, @p13, @p14, @p15, @p16)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", txt_OgrNo.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txt_OgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txt_OgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p4", comboBoxOgrCinsiyet.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskKayitTarih.Text);
                komutkaydet.Parameters.AddWithValue("@p6", txt_OgrReferans.Text);
                komutkaydet.Parameters.AddWithValue("@p7", SinifIDGetir(comboBoxSinif.Text));
                komutkaydet.Parameters.AddWithValue("@p8", comboBoxOgrenim.Text);
                komutkaydet.Parameters.AddWithValue("@p9", comboBoxOgrDurum.Text);
                komutkaydet.Parameters.AddWithValue("@p11", GuzergahIDGetir(comboBoxGuzergah.Text));
                komutkaydet.Parameters.AddWithValue("@p12", servisdurum);
                komutkaydet.Parameters.AddWithValue("@p13", sutdurum);
                komutkaydet.Parameters.AddWithValue("@p14", tanidikdurum);
                komutkaydet.Parameters.AddWithValue("@p15", richTextBoxOgrTemNot.Text);
                komutkaydet.Parameters.AddWithValue("@p16", txt_Resim.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komutidcek = new SqlCommand("Select OgrID from Tbl_OgrTemel", baglanti);
                SqlDataReader okuidcek = komutidcek.ExecuteReader();
                while (okuidcek.Read())
                {
                    Ogrid = okuidcek[0].ToString();
                }
                baglanti.Close();
                MessageBox.Show("Kayıt başarılı.");

                Frm_YeniOgrDetay frm_YeniOgrDetay = new Frm_YeniOgrDetay();
                frm_YeniOgrDetay.Show();
                Hide();
                
            
        }

        private void btn_Resim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxOgr.ImageLocation = openFileDialog1.FileName;
            txt_Resim.Text = openFileDialog1.FileName;
        }


        //Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True
    }
}
