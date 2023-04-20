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
    public partial class Frm_OgrKartTemel : Form
    {
        public Frm_OgrKartTemel()
        {
            InitializeComponent();
        }

        public string id, ad, soyad, cinsiyet, kayittarih, referans, no, sinif, ogrenimsekli, ogrenimdurumu, guzergah, notlar, resim;

        private void btn_Resim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxOgr.ImageLocation = openFileDialog1.FileName;
            txt_Resim.Text = openFileDialog1.FileName;
        }

        public int sut, servis, tanidik;

        private void btn_Ileri_Click(object sender, EventArgs e)
        {
            Frm_OgrKartDetay frm_OgrKartDetay = new Frm_OgrKartDetay();
            frm_OgrKartDetay.Show();
            Hide();
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

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

        private void btn_Duzenle_Click(object sender, EventArgs e)
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


            try
            {
                baglanti.Open();
                SqlCommand komutduzenle = new SqlCommand("update Tbl_OgrTemel set OgrNo = @p2, OgrAd = @p3, OgrSoyad = @p4, OgrCinsiyet = @p5, OgrKayitTarih = @p6, OgrReferans = @p7, OgrOgrenimSekli = @p8, OgrDurum = @p9, GuzergahID = @p10, OgrServis = @p11, OgrSut = @p12, OgrTanidik = @p13, OgrNotlar = @p14, SinifID = @p15 where OgrID = @p1", baglanti);
                komutduzenle.Parameters.AddWithValue("@p1", txt_OgrID.Text);
                komutduzenle.Parameters.AddWithValue("@p2", txt_OgrNo.Text);
                komutduzenle.Parameters.AddWithValue("@p3", txt_OgrAd.Text);
                komutduzenle.Parameters.AddWithValue("@p4", txt_OgrSoyad.Text);
                komutduzenle.Parameters.AddWithValue("@p5", comboBoxOgrCinsiyet.Text);
                komutduzenle.Parameters.AddWithValue("@p6", MskKayitTarih.Text);
                komutduzenle.Parameters.AddWithValue("@p7", txt_OgrReferans.Text);
                komutduzenle.Parameters.AddWithValue("@p8", comboBoxOgrenim.Text);
                komutduzenle.Parameters.AddWithValue("@p9", comboBoxOgrDurum.Text);
                komutduzenle.Parameters.AddWithValue("@p10", GuzergahIDGetir(comboBoxGuzergah.Text));
                komutduzenle.Parameters.AddWithValue("@p11", servisdurum);
                komutduzenle.Parameters.AddWithValue("@p12", sutdurum);
                komutduzenle.Parameters.AddWithValue("@p13", tanidikdurum);
                komutduzenle.Parameters.AddWithValue("@p14", richTextBoxOgrTemNot.Text);
                komutduzenle.Parameters.AddWithValue("@p15", SinifIDGetir(comboBoxSinif.Text));
                komutduzenle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");

            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız!" + p.Message);
            }

        }


        int SimdikiWidth;
        int Simdikiheight;

        private void Frm_OgrKart_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

            txt_OgrID.Text = id;
            txt_OgrAd.Text = ad;
            txt_OgrSoyad.Text = soyad;
            comboBoxOgrCinsiyet.Text = cinsiyet;
            MskKayitTarih.Text = kayittarih;
            txt_OgrReferans.Text = referans;
            txt_OgrNo.Text = no;
            comboBoxSinif.Text = sinif;
            comboBoxOgrenim.Text = ogrenimsekli;
            comboBoxOgrDurum.Text = ogrenimdurumu;
            comboBoxGuzergah.Text = guzergah;
            richTextBoxOgrTemNot.Text = notlar;
            txt_Resim.Text = resim;

            pictureBoxOgr.ImageLocation = resim;

            if (sut == 1)
            {
                checkBoxSut.Checked = true;
            }
            else
            {
                checkBoxSut.Checked = false;
            }

            if (servis == 1)
            {
                checkBoxServis.Checked = true;
            }
            else
            {
                checkBoxServis.Checked = false;
            }
            
            if (tanidik == 1)
            {
                checkBoxTanidik.Checked = true;
            }
            else
            {
                checkBoxTanidik.Checked = false;
            }

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
            SqlCommand komutguzergah = new SqlCommand("select GuzergahAd from Tbl_Guzergah", baglanti);
            SqlDataReader okuguzergah = komutguzergah.ExecuteReader();
            while (okuguzergah.Read())
            {
                comboBoxGuzergah.Items.Add(okuguzergah[0].ToString());
            }
            okuguzergah.Close();
            baglanti.Close();
        }
    }
}
