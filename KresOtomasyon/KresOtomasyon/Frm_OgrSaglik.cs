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
    public partial class Frm_OgrSaglik : Form
    {
        public Frm_OgrSaglik()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");

        int konusboz = 0;
        int davboz = 0;
        int gorboz = 0;
        int sigorta = 0;
        int yuruboz = 0;
        int alerji = 0;
        int engel = 0;
        int kaza = 0;
        int hastane = 0;
        int asifelc = 0;
        int asiBCG = 0;
        int asiHepatitB = 0;
        int asikizamik = 0;
        int asiBDT = 0;
        int haskizamik = 0;
        int hassarilik = 0;
        int hasHepatitB = 0;
        int hasHepatitA = 0;
        int haskabakulak = 0;
        int hassucicegi = 0;
        int haszaturre = 0;
        int hasmenenjit = 0;

        int konusmadurum = 0;
        int davranisdurum = 0;
        int gormedurum = 0;
        int sigortadurum = 0;
        int yurumedurum = 0;
        int alerjidurum = 0;
        int engeldurum = 0;
        int kazadurum = 0;
        int hastanedurum = 0;
        int asibcg = 0;
        int asihepatitb = 0;
        int asibdt = 0;
        int hashepatitb = 0;
        int hashepatita = 0;


        private void btn_OgrSaglikİleri_Click(object sender, EventArgs e)
        {
            //insert
            //aile açılacak
            //parametresiz

            if (checkBoxKonusma.Checked)
            {
                konusmadurum = 1;
            }
            else
            {
                konusmadurum = 0;
            }

            if (checkBoxDavranis.Checked)
            {
                davranisdurum = 1;
            }
            else
            {
                davranisdurum = 0;
            }

            if (checkBoxGorme.Checked)
            {
                gormedurum = 1;
            }
            else
            {
                gormedurum = 0;
            }

            if (checkBoxSigorta.Checked)
            {
                sigortadurum = 1;
            }
            else
            {
                sigortadurum = 0;
            }

            if (checkBoxYurume.Checked)
            {
                yurumedurum = 1;
            }
            else
            {
                yurumedurum = 0;
            }

            if (checkBoxAlerji.Checked)
            {
                alerjidurum = 1;
            }
            else
            {
                alerjidurum = 0;
            }

            if (checkBoxEngel.Checked)
            {
                engeldurum = 1;
            }
            else
            {
                engeldurum = 0;
            }

            if (checkBoxKaza.Checked)
            {
                kazadurum = 1;
            }
            else
            {
                kazadurum = 0;
            }

            if (checkBoxHastane.Checked)
            {
                hastanedurum = 1;
            }
            else
            {
                hastanedurum = 0;
            }

            if (checkBoxOgrAsiFelc.Checked)
            {
                asifelc = 1;
            }
            else
            {
                asifelc = 0;
            }

            if (checkBoxOgrAsiBCG.Checked)
            {
                asibcg = 1;
            }
            else
            {
                asibcg = 0;
            }

            if (checkBoxOgrAsiHeapatitB.Checked)
            {
                asihepatitb = 1;
            }
            else
            {
                asihepatitb = 0;
            }

            if (checkBoxOgrAsiKizamik.Checked)
            {
                asikizamik = 1;
            }
            else
            {
                asikizamik = 0;
            }

            if (checkBoxOgrAsiBDT.Checked)
            {
                asibdt = 1;
            }
            else
            {
                asibdt = 0;
            }

            if (checkBoxHasKizamik.Checked)
            {
                haskizamik = 1;
            }
            else
            {
                haskizamik = 0;
            }

            if (checkBoxHasSarilik.Checked)
            {
                hassarilik = 1;
            }
            else
            {
                hassarilik = 0;
            }

            if (checkBoxHasHepatitB.Checked)
            {
                hashepatitb = 1;
            }
            else
            {
                hashepatitb = 0;
            }

            if (checkBoxHasHepatitA.Checked)
            {
                hashepatita = 1;
            }
            else
            {
                hashepatita = 0;
            }

            if (checkBoxHasKabakulak.Checked)
            {
                haskabakulak = 1;
            }
            else
            {
                haskabakulak = 0;
            }

            if (checkBoxHasSuCicegi.Checked)
            {
                hassucicegi = 1;
            }
            else
            {
                hassucicegi = 0;
            }

            if (checkBoxHasZaturre.Checked)
            {
                haszaturre = 1;
            }
            else
            {
                haszaturre = 0;
            }

            if (checkBoxHasMenenjit.Checked)
            {
                hasmenenjit = 1;
            }
            else
            {
                hasmenenjit = 0;
            }

            try
            {
                baglanti.Open();
                SqlCommand komutidcek = new SqlCommand("select OgrID from Tbl_OgrTemel", baglanti);
                SqlDataReader okuid = komutidcek.ExecuteReader();
                while (okuid.Read())
                {
                    SaglikOgrID.Text = okuid[0].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komutsaglikcek = new SqlCommand("select OgrSaglikID from Tbl_OgrSaglik", baglanti);
                SqlDataReader okusaglik = komutsaglikcek.ExecuteReader();
                while (okusaglik.Read())
                {
                    SaglikID.Text = okusaglik[0].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_OgrSaglik (OgrSaglikKonusBozuk, OgrSaglikDavBozuk, OgrSaglikGorBozuk, OgrSaglikSigorta,OgrSaglikYuruBozuk, OgrSaglikAlerji, OgrSaglikEngel, OgrSaglikKaza, OgrSaglikHasYat, OgrSaglikHastane, OgrSaglikDoktor, OgrSaglikKronik, OgrSaglikProtez, OgrAsiFelc, OgrAsiBCG, OgrAsiHepatitB, OgrAsiKizamik, OgrAsiBDT, OgrHasKizamik, OgrHasSarilik, OgrHasHepatitB, OgrHasHepatitA, OgrHasKabakulak, OgrHasSuCicegi, OgrHasZaturre, OgrHasMenenjit, OgrKan) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, @p26, @p27)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", konusmadurum);
                komutkaydet.Parameters.AddWithValue("@p2", davranisdurum);
                komutkaydet.Parameters.AddWithValue("@p3", gormedurum);
                komutkaydet.Parameters.AddWithValue("@p4", sigortadurum);
                komutkaydet.Parameters.AddWithValue("@p5", yurumedurum);
                komutkaydet.Parameters.AddWithValue("@p6", alerjidurum);
                komutkaydet.Parameters.AddWithValue("@p7", engeldurum);
                komutkaydet.Parameters.AddWithValue("@p8", kazadurum);
                komutkaydet.Parameters.AddWithValue("@p9", hastanedurum);
                komutkaydet.Parameters.AddWithValue("@p10", txt_OgrHastane.Text);
                komutkaydet.Parameters.AddWithValue("@p11", txt_Doktor.Text);
                komutkaydet.Parameters.AddWithValue("@p12", richTextBoxKronik.Text);
                komutkaydet.Parameters.AddWithValue("@p13", richTextBoxProtez.Text);
                komutkaydet.Parameters.AddWithValue("@p14", asifelc);
                komutkaydet.Parameters.AddWithValue("@p15", asibcg);
                komutkaydet.Parameters.AddWithValue("@p16", asihepatitb);
                komutkaydet.Parameters.AddWithValue("@p17", asikizamik);
                komutkaydet.Parameters.AddWithValue("@p18", asibdt);
                komutkaydet.Parameters.AddWithValue("@p19", haskizamik);
                komutkaydet.Parameters.AddWithValue("@p20", hassarilik);
                komutkaydet.Parameters.AddWithValue("@p21", hashepatitb);
                komutkaydet.Parameters.AddWithValue("@p22", hashepatita);
                komutkaydet.Parameters.AddWithValue("@p23", haskabakulak);
                komutkaydet.Parameters.AddWithValue("@p24", hassucicegi);
                komutkaydet.Parameters.AddWithValue("@p25", haszaturre);
                komutkaydet.Parameters.AddWithValue("@p26", hasmenenjit);
                komutkaydet.Parameters.AddWithValue("@p27", comboBoxOgrKan.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komutguncelle = new SqlCommand("update Tbl_OgrTemel set OgrSaglikID = @b2 where OgrID = @b1", baglanti);
                komutguncelle.Parameters.AddWithValue("@b1", SaglikOgrID.Text);
                komutguncelle.Parameters.AddWithValue("@b2", SaglikID.Text);
                komutguncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı.");

                //Aile parametreli Ogrid
                Frm_Aile frmAile = new Frm_Aile();
                frmAile.Show();
                Hide();
            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyin!" + p.Message);
            }




        }


        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_OgrSaglik_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

        }



    }
}
