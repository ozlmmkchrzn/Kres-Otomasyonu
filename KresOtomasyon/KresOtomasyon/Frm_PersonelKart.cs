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
    public partial class Frm_PersonelKart : Form
    {
        public Frm_PersonelKart()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        public string perid, perad, perunvan, perbaslamatarih, perayrilistarih, permaas, perdurum, pertahsil, percalismasekli, permukbaslamatarih, permukbitistarih, permesai, perevtel, perceptel, permail, peradres, pertc, perdogumtarih, perserino, peruyruk, personkullanmatarih, personelresim;

        private void btn_Resim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txt_PersonelResim.Text = openFileDialog1.FileName;
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutduzenle = new SqlCommand("update Tbl_Personel set PersonelAd = @p2, PersonelUnvan = @p3, PersonelBaslamaTarih = @p4, PersonelAyrilmaTarih = @p5, PersonelMaas = @p6, PersonelDurum = @p7, PersonelTahsil = @p8, PersonelCalisSekli = @p9, PersonelMukaveleBasTarih = @p10, PersonelMukaveleBitisTarih = @p11, PersonelMesaiSaat = @p12, PersonelEvTel = @p13, PersonelCepTel = @p14, PersonelMail = @p15, PersonelAdres = @p16, PersonelTC = @p17, PersonelDogTarih = @p18, PersonelSeriNo = @p19, PersonelUyruk = @p20, PersonelSonKullanTarih = @p21 where PersonelID = @p1", baglanti);
                komutduzenle.Parameters.AddWithValue("@p1", txt_PersonelID.Text);
                komutduzenle.Parameters.AddWithValue("@p2", txt_PersonelAd.Text);
                komutduzenle.Parameters.AddWithValue("@p3", txt_PersonelUnvan.Text);
                komutduzenle.Parameters.AddWithValue("@p4", MskBaslamaTarih.Text);
                komutduzenle.Parameters.AddWithValue("@p5", MskAyrilmaTarih.Text);
                komutduzenle.Parameters.AddWithValue("@p6", txt_PersonelMaas.Text);
                komutduzenle.Parameters.AddWithValue("@p7", ComboPersonelDurum.Text);
                komutduzenle.Parameters.AddWithValue("@p8", txt_PersonelTahsil.Text);
                komutduzenle.Parameters.AddWithValue("@p9", txt_PersonelCalisSekli.Text);
                komutduzenle.Parameters.AddWithValue("@p10", MskMukBasTar.Text);
                komutduzenle.Parameters.AddWithValue("@p11", MskMukBitTar.Text);
                komutduzenle.Parameters.AddWithValue("@p12", txt_PersonelMesaiSaat.Text);
                komutduzenle.Parameters.AddWithValue("@p13", txt_PersonelEvTel.Text);
                komutduzenle.Parameters.AddWithValue("@p14", txt_PersonelCepTel.Text);
                komutduzenle.Parameters.AddWithValue("@p15", txt_PersonelMail.Text);
                komutduzenle.Parameters.AddWithValue("@p16", RichPersonelAdres.Text);
                komutduzenle.Parameters.AddWithValue("@p17", txt_PersonelTC.Text);
                komutduzenle.Parameters.AddWithValue("@p18", MskPerDog.Text);
                komutduzenle.Parameters.AddWithValue("@p19", txt_PersonelSeriNo.Text);
                komutduzenle.Parameters.AddWithValue("@p20", txt_PersonelUyruk.Text);
                komutduzenle.Parameters.AddWithValue("@p21", MskPerSonKullanma.Text);
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
        private void Frm_PersonelKart_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

            txt_PersonelID.Text = perid;
            txt_PersonelAd.Text = perad;
            txt_PersonelUnvan.Text = perunvan;
            MskBaslamaTarih.Text = perbaslamatarih;
            MskAyrilmaTarih.Text = perayrilistarih;
            txt_PersonelMaas.Text = permaas;
            ComboPersonelDurum.Text = perdurum;
            txt_PersonelTahsil.Text = pertahsil;
            txt_PersonelCalisSekli.Text = percalismasekli;
            MskMukBasTar.Text = permukbaslamatarih;
            MskMukBitTar.Text = permukbitistarih;
            txt_PersonelMesaiSaat.Text = permesai;
            txt_PersonelEvTel.Text = perevtel;
            txt_PersonelCepTel.Text = perceptel;
            txt_PersonelMail.Text = permail;
            RichPersonelAdres.Text = peradres;
            txt_PersonelTC.Text = pertc;
            MskPerDog.Text = perdogumtarih;
            txt_PersonelSeriNo.Text = perserino;
            txt_PersonelUyruk.Text = peruyruk;
            MskPerSonKullanma.Text = personkullanmatarih;
            txt_PersonelResim.Text = personelresim;

            pictureBox1.ImageLocation = personelresim;
        }
    }
}
