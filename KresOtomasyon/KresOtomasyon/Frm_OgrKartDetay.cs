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
    public partial class Frm_OgrKartDetay : Form
    {
        public Frm_OgrKartDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxOgrKira.Checked)
                {
                    ogrkira = 1;
                }
                else
                {
                    ogrkira = 0;
                }

                if (checkBoxOgrOda.Checked)
                {
                    ogroda = 1;
                }
                else
                {
                    ogroda = 0;
                }

                if (checkBoxOgrYemek.Checked)
                {
                    ogryemek = 1;
                }
                else
                {
                    ogryemek = 0;
                }

                baglanti.Open();
                SqlCommand komutduzenle = new SqlCommand("update Tbl_OgrDetay set OgrTC = @p2, OgrDogTarih = @p3, OgrSeriNo = @p4, OgrUyruk = @p5, OgrSonTarih = @p6, OgrAdres = @p7, OgrKira = @p8, OgrOda = @p9, OgrYemek = @p10, OgrSevdigiYemek = @p11, OgrSevmedigiYemek = @p12, OgrFobi = @p13, OgrSevdigiSeyler = @p14, OgrCocukIletisim = @p15 where OgrDetayID = @p1", baglanti);
                komutduzenle.Parameters.AddWithValue("@p1", OgrDetayID.Text);
                komutduzenle.Parameters.AddWithValue("@p2", txt_OgrTC.Text);
                komutduzenle.Parameters.AddWithValue("@p3", MskOgrDogTar.Text);
                komutduzenle.Parameters.AddWithValue("@p4", txt_OgrSeriNo.Text);
                komutduzenle.Parameters.AddWithValue("@p5", txt_OgrUyruk.Text);
                komutduzenle.Parameters.AddWithValue("@p6", MskOgrSonTarih.Text);
                komutduzenle.Parameters.AddWithValue("@p7", RichAdres.Text);
                komutduzenle.Parameters.AddWithValue("@p8", ogrkira);
                komutduzenle.Parameters.AddWithValue("@p9", ogroda);
                komutduzenle.Parameters.AddWithValue("@p10", ogryemek);
                komutduzenle.Parameters.AddWithValue("@p11", RichOgrSevdigiYemek.Text);
                komutduzenle.Parameters.AddWithValue("@p12", RichOgrSevmedigiYemek.Text);
                komutduzenle.Parameters.AddWithValue("@p13", RichFobi.Text);
                komutduzenle.Parameters.AddWithValue("@p14", RichOgrSevdigiSeyler.Text);
                komutduzenle.Parameters.AddWithValue("@p15", RichOgrCocukIletisim.Text);
                komutduzenle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız! " + p.Message);
            }
        }

        int ogrkira = 0;
        int ogryemek = 0;
        int ogroda = 0;

        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_OgrKartDetay_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));


            baglanti.Open();
            SqlCommand komutid = new SqlCommand("select OgrDetayID from Tbl_OgrDetay", baglanti);
            SqlDataReader okuid = komutid.ExecuteReader();
            while (okuid.Read())
            {
                OgrDetayID.Text = okuid[0].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_OgrDetay where OgrDetayID = @b1", baglanti);
            komut.Parameters.AddWithValue("@b1", OgrDetayID.Text);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txt_OgrTC.Text = oku[1].ToString();
                MskOgrDogTar.Text = oku[2].ToString();
                txt_OgrSeriNo.Text = oku[3].ToString();
                txt_OgrUyruk.Text = oku[4].ToString();
                MskOgrSonTarih.Text = oku[5].ToString();
                RichAdres.Text = oku[6].ToString();
                ogrkira = Convert.ToInt32(oku[7].ToString());
                ogroda = Convert.ToInt32(oku[8].ToString());
                ogryemek = Convert.ToInt32(oku[9].ToString());
                RichOgrSevdigiYemek.Text = oku[10].ToString();
                RichOgrSevmedigiYemek.Text = oku[11].ToString();
                RichFobi.Text = oku[12].ToString();
                RichOgrSevdigiSeyler.Text = oku[13].ToString();
                RichOgrCocukIletisim.Text = oku[14].ToString();
            }
            baglanti.Close();

            if (ogrkira == 1)
            {
                checkBoxOgrKira.Checked = true;
            }
            else
            {
                checkBoxOgrKira.Checked = false;
            }

            if (ogryemek == 1)
            {
                checkBoxOgrYemek.Checked = true;
            }
            else
            {
                checkBoxOgrYemek.Checked = false;
            }

            if (ogroda == 1)
            {
                checkBoxOgrOda.Checked = true;
            }
            else
            {
                checkBoxOgrOda.Checked = false;
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Frm_OgrKartTemel frm_OgrKartTemel = new Frm_OgrKartTemel();
            frm_OgrKartTemel.Show();
            Hide();
        }

        private void btn_Ileri_Click(object sender, EventArgs e)
        {
            Frm_OgrKartSaglik frm_OgrKartSaglik = new Frm_OgrKartSaglik();
            frm_OgrKartSaglik.Show();
            Hide();
        }
    }
}
