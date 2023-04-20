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
    public partial class Frm_Personel : Form
    {
        public Frm_Personel()
        {
            InitializeComponent();
        }
        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_Personel_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        private void btn_PersonelTemelIleri_Click(object sender, EventArgs e)
        {
            int ogretmendurum = 0;

            if (CheckPersonelOgretmen.Checked)
            {
                ogretmendurum = 1;
            }
            else
            {
                ogretmendurum = 0;
            }

            try
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Personel (PersonelAd, PersonelUnvan, PersonelBaslamaTarih, PersonelAyrilmaTarih, PersonelMaas, PersonelDurum, PersonelTahsil, PersonelCalisSekli, PersonelMukaveleBasTarih, PersonelMukaveleBitisTarih, PersonelMesaiSaat, PersonelOgretmen, PersonelEvTel, PersonelCepTel, PersonelMail, PersonelAdres, PersonelTC, PersonelDogTarih, PersonelSeriNo, PersonelUyruk, PersonelSonKullanTarih, PersonelResim) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", txt_PersonelAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txt_PersonelUnvan.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskBaslamaTarih.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskAyrilmaTarih.Text);
                komutkaydet.Parameters.AddWithValue("@p5", txt_PersonelMaas.Text);
                komutkaydet.Parameters.AddWithValue("@p6", ComboPersonelDurum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txt_PersonelTahsil.Text);
                komutkaydet.Parameters.AddWithValue("@p8", txt_PersonelCalisSekli.Text);
                komutkaydet.Parameters.AddWithValue("@p9", MskMukBasTar.Text);
                komutkaydet.Parameters.AddWithValue("@p10", MskMukBitTar.Text);
                komutkaydet.Parameters.AddWithValue("@p11", txt_PersonelMesaiSaat.Text);
                komutkaydet.Parameters.AddWithValue("@p12", ogretmendurum);
                komutkaydet.Parameters.AddWithValue("@p13", txt_PersonelEvTel.Text);
                komutkaydet.Parameters.AddWithValue("@p14", txt_PersonelCepTel.Text);
                komutkaydet.Parameters.AddWithValue("@p15", txt_PersonelMail.Text);
                komutkaydet.Parameters.AddWithValue("@p16", RichPersonelAdres.Text);
                komutkaydet.Parameters.AddWithValue("@p17", txt_PersonelTC.Text);
                komutkaydet.Parameters.AddWithValue("@p18", MskPerDog.Text);
                komutkaydet.Parameters.AddWithValue("@p19", txt_PersonelSeriNo.Text);
                komutkaydet.Parameters.AddWithValue("@p20", txt_PersonelUyruk.Text);
                komutkaydet.Parameters.AddWithValue("@p21", MskPerSonKullanma.Text);
                komutkaydet.Parameters.AddWithValue("@p22", txt_PersonelResim.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz!" + p.Message);

                MessageBox.Show("Kayıt Başarılı.");
            }
        }

        private void btn_Resim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txt_PersonelResim.Text = openFileDialog1.FileName;
        }
    }
}
