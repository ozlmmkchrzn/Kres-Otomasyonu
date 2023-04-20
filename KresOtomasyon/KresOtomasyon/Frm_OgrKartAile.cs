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
    public partial class Frm_OgrKartAile : Form
    {
        public Frm_OgrKartAile()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        int annesag = 0;
        int anneoz = 0;
        int babasag = 0;
        int babaoz = 0;

        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_OgrKartAile_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

            baglanti.Open();
            SqlCommand komutid = new SqlCommand("select AileID from Tbl_Aile", baglanti);
            SqlDataReader okuid = komutid.ExecuteReader();
            while (okuid.Read())
            {
                AileID.Text = okuid[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Aile where AileID = @b1", baglanti);
            komut.Parameters.AddWithValue("@b1", AileID.Text);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txt_AnneAd.Text = oku[1].ToString();
                txt_AnneTC.Text = oku[2].ToString();
                MskAnneDog.Text = oku[3].ToString();
                txt_AnneMeslek.Text = oku[4].ToString();
                txt_AnneEgitim.Text = oku[5].ToString();
                txt_AnneCalismaSaat.Text = oku[6].ToString();
                annesag = Convert.ToInt32(oku[7].ToString());
                anneoz = Convert.ToInt32(oku[8].ToString());
                txt_AnneEvTel.Text = oku[9].ToString();
                txt_AnneIsTel.Text = oku[10].ToString();
                txt_AnneCeptel.Text = oku[11].ToString();
                txt_AnneMail.Text = oku[12].ToString();
                RichAnneEvAdres.Text = oku[13].ToString();
                RichAnneIsAdres.Text = oku[14].ToString();
                txt_BabaAd.Text = oku[15].ToString();
                txt_BabaTC.Text = oku[16].ToString();
                MskBabaDog.Text = oku[17].ToString();
                txt_BabaMeslek.Text = oku[18].ToString();
                txt_BabaEgitim.Text = oku[19].ToString();
                txt_BabaCalisSaat.Text = oku[20].ToString();
                babasag = Convert.ToInt32(oku[21].ToString());
                babaoz = Convert.ToInt32(oku[22].ToString());
                txt_BabaEvTel.Text = oku[23].ToString();
                txt_BabaIsTel.Text = oku[24].ToString();
                txt_BabaCepTel.Text = oku[25].ToString();
                txt_BabaMail.Text = oku[26].ToString();
                RichBabaIsAdres.Text = oku[27].ToString();
                RichBabaEvAdres.Text = oku[28].ToString();

            }
            baglanti.Close();

            if(annesag == 1)
            {
                checkAnneSag.Checked = true;
            }
            else
            {
                checkAnneSag.Checked = false;
            }

            if (anneoz == 1)
            {
                checkAnneOz.Checked = true;
            }
            else
            {
                checkAnneOz.Checked = false;
            }

            if (babasag == 1)
            {
                CheckBabaSag.Checked = true;
            }
            else
            {
                CheckBabaSag.Checked = false;
            }

            if (babaoz == 1)
            {
                CheckBabaOz.Checked = true;
            }
            else
            {
                CheckBabaOz.Checked = false;
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Frm_OgrKartSaglik frm_OgrKartSaglik = new Frm_OgrKartSaglik();
            frm_OgrKartSaglik.Show();
            Hide();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            if (checkAnneOz.Checked)
            {
                anneoz = 1;
            }
            else
            {
                anneoz = 0;
            }

            if (checkAnneSag.Checked)
            {
                annesag = 1;
            }
            else
            {
                annesag = 0;
            }

            if (CheckBabaOz.Checked)
            {
                babaoz = 1;
            }
            else
            {
                babaoz = 0;
            }

            if (CheckBabaSag.Checked)
            {
                babasag = 1;
            }
            else
            {
                babasag = 0;
            }

            try
            {
                baglanti.Open();
                SqlCommand komutguncelle = new SqlCommand("update Tbl_Aile set AnneAd = @p2, AnneTC = @p3, AnneDogTarih = @p4, AnneMeslek = @p5, AnneEgitim = @p6, AnneCalismaSaat = @p7, AnneSag = @p8, AnneOz = @p9, AnneEvTel = @p10, AnneIsTel = @p11, AnneCepTel = @p12, AnneMail = @p13, AnneEvAdres = @p14, AnneIsAdres = @p15, BabaAd = @p16, BabaTC = @p17, BabaDogTarih = @p18, BabaMeslek = @p19, BabaEgitim = @p20, BabaCalisSaat = @p21, BabaSag = @p22, BabaOz = @p23, BabaEvTel = @p24, BabaIsTel = @p25, BabaCepTel = @p26, BabaMail = @p27, BabaIsAdres = @p28, BabaEvAdres = @p29 where AileID = @p1", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", AileID.Text);
                komutguncelle.Parameters.AddWithValue("@p2", txt_AnneAd.Text);
                komutguncelle.Parameters.AddWithValue("@p3", txt_AnneTC.Text);
                komutguncelle.Parameters.AddWithValue("@p4", MskAnneDog.Text);
                komutguncelle.Parameters.AddWithValue("@p5", txt_AnneMeslek.Text);
                komutguncelle.Parameters.AddWithValue("@p6", txt_AnneEgitim.Text);
                komutguncelle.Parameters.AddWithValue("@p7", txt_AnneCalismaSaat.Text);
                komutguncelle.Parameters.AddWithValue("@p8", annesag);
                komutguncelle.Parameters.AddWithValue("@p9", anneoz);
                komutguncelle.Parameters.AddWithValue("@p10", txt_AnneEvTel.Text);
                komutguncelle.Parameters.AddWithValue("@p11", txt_AnneIsTel.Text);
                komutguncelle.Parameters.AddWithValue("@p12", txt_AnneCeptel.Text);
                komutguncelle.Parameters.AddWithValue("@p13", txt_AnneMail.Text);
                komutguncelle.Parameters.AddWithValue("@p14", RichAnneEvAdres.Text);
                komutguncelle.Parameters.AddWithValue("@p15", RichAnneIsAdres.Text);
                komutguncelle.Parameters.AddWithValue("@p16", txt_BabaAd.Text);
                komutguncelle.Parameters.AddWithValue("@p17", txt_BabaTC.Text);
                komutguncelle.Parameters.AddWithValue("@p18", MskBabaDog.Text);
                komutguncelle.Parameters.AddWithValue("@p19", txt_BabaMeslek.Text);
                komutguncelle.Parameters.AddWithValue("@p20", txt_BabaEgitim.Text);
                komutguncelle.Parameters.AddWithValue("@p21", txt_BabaCalisSaat.Text);
                komutguncelle.Parameters.AddWithValue("@p22", babasag);
                komutguncelle.Parameters.AddWithValue("@p23", babaoz);
                komutguncelle.Parameters.AddWithValue("@p24", txt_BabaEvTel.Text);
                komutguncelle.Parameters.AddWithValue("@p25", txt_BabaIsTel.Text);
                komutguncelle.Parameters.AddWithValue("@p26", txt_BabaCepTel.Text);
                komutguncelle.Parameters.AddWithValue("@p27", txt_BabaMail.Text);
                komutguncelle.Parameters.AddWithValue("@p28", RichBabaIsAdres.Text);
                komutguncelle.Parameters.AddWithValue("@p29", RichBabaEvAdres.Text);
                komutguncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Düzenleme işlemi başarılı.");
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Düzenleme işlemi başarısız! " + p.Message);
            }
        }

        private void btn_Ileri_Click(object sender, EventArgs e)
        {
            Frm_OgrKartBorc frm_OgrKartBorc = new Frm_OgrKartBorc();
            frm_OgrKartBorc.Show();
            Hide();
        }
    }

}
