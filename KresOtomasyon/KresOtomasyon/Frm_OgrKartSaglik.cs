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
    public partial class Frm_OgrKartSaglik : Form
    {
        public Frm_OgrKartSaglik()
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

        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_OgrKartSaglik_Load(object sender, EventArgs e)
        {

            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));

            baglanti.Open();
            SqlCommand komutid = new SqlCommand("select OgrSaglikID from Tbl_OgrSaglik", baglanti);
            SqlDataReader okuid = komutid.ExecuteReader();
            while (okuid.Read())
            {
                SaglikID.Text = okuid[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_OgrSaglik where OgrSaglikID = @b1", baglanti);
            komut.Parameters.AddWithValue("@b1", SaglikID.Text);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                konusboz = Convert.ToInt32(oku[1].ToString());
                davboz = Convert.ToInt32(oku[2].ToString());
                gorboz = Convert.ToInt32(oku[3].ToString());
                sigorta = Convert.ToInt32(oku[4].ToString());
                yuruboz = Convert.ToInt32(oku[5].ToString());
                alerji = Convert.ToInt32(oku[6].ToString());
                engel = Convert.ToInt32(oku[7].ToString());
                kaza = Convert.ToInt32(oku[8].ToString());
                hastane = Convert.ToInt32(oku[9].ToString());
                txt_OgrHastane.Text = oku[10].ToString();
                txt_Doktor.Text = oku[11].ToString();
                richTextBoxKronik.Text = oku[12].ToString();
                richTextBoxProtez.Text = oku[13].ToString();
                asifelc = Convert.ToInt32(oku[14].ToString());
                asiBCG = Convert.ToInt32(oku[15].ToString());
                asiHepatitB = Convert.ToInt32(oku[16].ToString());
                asikizamik = Convert.ToInt32(oku[17].ToString());
                asiBDT = Convert.ToInt32(oku[18].ToString());
                haskizamik = Convert.ToInt32(oku[19].ToString());
                hassarilik = Convert.ToInt32(oku[20].ToString());
                hasHepatitB = Convert.ToInt32(oku[21].ToString());
                hasHepatitA = Convert.ToInt32(oku[22].ToString());
                haskabakulak = Convert.ToInt32(oku[23].ToString());
                hassucicegi = Convert.ToInt32(oku[24].ToString());
                haszaturre = Convert.ToInt32(oku[25].ToString());
                hasmenenjit = Convert.ToInt32(oku[26].ToString());
                comboBoxOgrKan.Text = oku[27].ToString();
            }
            baglanti.Close();

            if (konusboz == 1)
            {
                checkBoxKonusma.Checked = true;
            }
            else
            {
                checkBoxKonusma.Checked = false;
            }

            if (davboz == 1)
            {
                checkBoxDavranis.Checked = true;
            }
            else
            {
                checkBoxDavranis.Checked = false;
            }

            if (gorboz == 1)
            {
                checkBoxGorme.Checked = true;
            }
            else
            {
                checkBoxGorme.Checked = false;
            }

            if (sigorta == 1)
            {
                checkBoxSigorta.Checked = true;
            }
            else
            {
                checkBoxSigorta.Checked = false;
            }

            if (yuruboz == 1)
            {
                checkBoxYurume.Checked = true;
            }
            else
            {
                checkBoxYurume.Checked = false;
            }

            if (alerji == 1)
            {
                checkBoxAlerji.Checked = true;
            }
            else
            {
                checkBoxAlerji.Checked = false;
            }

            if (engel == 1)
            {
                checkBoxEngel.Checked = true;
            }
            else
            {
                checkBoxEngel.Checked = false;
            }

            if (kaza == 1)
            {
                checkBoxKaza.Checked = true;
            }
            else
            {
                checkBoxKaza.Checked = false;
            }

            if (hastane == 1)
            {
                checkBoxHastane.Checked = true;
            }
            else
            {
                checkBoxHastane.Checked = false;
            }

            if (asifelc == 1)
            {
                checkBoxOgrAsiFelc.Checked = true;
            }
            else
            {
                checkBoxOgrAsiFelc.Checked = false;
            }

            if (asiBCG == 1)
            {
                checkBoxOgrAsiBCG.Checked = true;
            }
            else
            {
                checkBoxOgrAsiBCG.Checked = false;
            }

            if (asiHepatitB == 1)
            {
                checkBoxOgrAsiHeapatitB.Checked = true;
            }
            else
            {
                checkBoxOgrAsiHeapatitB.Checked = false;
            }

            if (asikizamik == 1)
            {
                checkBoxOgrAsiKizamik.Checked = true;
            }
            else
            {
                checkBoxOgrAsiKizamik.Checked = false;
            }

            if (asiBDT == 1)
            {
                checkBoxOgrAsiBDT.Checked = true;
            }
            else
            {
                checkBoxOgrAsiBDT.Checked = false;
            }

            if (haskizamik == 1)
            {
                checkBoxHasKizamik.Checked = true;
            }
            else
            {
                checkBoxHasKizamik.Checked = false;
            }

            if (hassarilik == 1)
            {
                checkBoxHasSarilik.Checked = true;
            }
            else
            {
                checkBoxHasSarilik.Checked = false;
            }

            if (hasHepatitB == 1)
            {
                checkBoxHasHepatitB.Checked = true;
            }
            else
            {
                checkBoxHasHepatitB.Checked = false;
            }

            if (hasHepatitA == 1)
            {
                checkBoxHasHepatitA.Checked = true;
            }
            else
            {
                checkBoxHasHepatitA.Checked = false;
            }

            if (haskabakulak == 1)
            {
                checkBoxHasKabakulak.Checked = true;
            }
            else
            {
                checkBoxHasKabakulak.Checked = false;
            }

            if (hassucicegi == 1)
            {
                checkBoxHasSuCicegi.Checked = true;
            }
            else
            {
                checkBoxHasSuCicegi.Checked = false;
            }

            if (haszaturre == 1)
            {
                checkBoxHasZaturre.Checked = true;
            }
            else
            {
                checkBoxHasZaturre.Checked = false;
            }

            if (hasmenenjit == 1)
            {
                checkBoxHasMenenjit.Checked = true;
            }
            else
            {
                checkBoxHasMenenjit.Checked = false;
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Frm_OgrKartDetay frm_OgrKartDetay = new Frm_OgrKartDetay();
            frm_OgrKartDetay.Show();
            Hide();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {


            try
            {
                if (checkBoxKonusma.Checked)
                {
                    konusboz = 1;
                }
                else
                {
                    konusboz = 0;
                }

                if (checkBoxDavranis.Checked)
                {
                    davboz = 1;
                }
                else
                {
                    davboz = 0;
                }

                if (checkBoxGorme.Checked)
                {
                    gorboz = 1;
                }
                else
                {
                    gorboz = 0;
                }

                if (checkBoxSigorta.Checked)
                {
                    sigorta = 1;
                }
                else
                {
                    sigorta = 0;
                }

                if (checkBoxYurume.Checked)
                {
                    yuruboz = 1;
                }
                else
                {
                    yuruboz = 0;
                }

                if (checkBoxAlerji.Checked)
                {
                    alerji = 1;
                }
                else
                {
                    alerji = 0;
                }

                if (checkBoxEngel.Checked)
                {
                    engel = 1;
                }
                else
                {
                    engel = 0;
                }

                if (checkBoxKaza.Checked)
                {
                    kaza = 1;
                }
                else
                {
                    kaza = 0;
                }

                if (checkBoxHastane.Checked)
                {
                    hastane = 1;
                }
                else
                {
                    hastane = 0;
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
                    asiBCG = 1;
                }
                else
                {
                    asiBCG = 0;
                }

                if (checkBoxOgrAsiHeapatitB.Checked)
                {
                    asiHepatitB = 1;
                }
                else
                {
                    asiHepatitB = 0;
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
                    asiBDT = 1;
                }
                else
                {
                    asiBDT = 0;
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
                    hasHepatitB = 1;
                }
                else
                {
                    hasHepatitB = 0;
                }

                if (checkBoxHasHepatitA.Checked)
                {
                    hasHepatitA = 1;
                }
                else
                {
                    hasHepatitA = 0;
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

                baglanti.Open();
                SqlCommand komutguncelle = new SqlCommand("update Tbl_OgrSaglik set OgrSaglikKonusBozuk = @p2, OgrSaglikDavBozuk = @p3, OgrSaglikGorBozuk = @p4, OgrSaglikSigorta = @p5, OgrSaglikYuruBozuk = @p6, OgrSaglikAlerji = @p7, OgrSaglikEngel = @p8, OgrSaglikKaza = @p9, OgrSaglikHasYat = @p10, OgrSaglikHastane = @p11, OgrSaglikDoktor = @p12, OgrSaglikKronik = @p13, OgrSaglikProtez = @p14, OgrAsiFelc = @p15, OgrAsiBCG = @p16, OgrAsiHepatitB = @p17, OgrAsiKizamik = @p18, OgrAsiBDT = @p19, OgrHasKizamik = @p20, OgrHasSarilik = @p21, OgrHasHepatitB = @p22, OgrHasHepatitA = @p23, OgrHasKabakulak = @p24, OgrHasSuCicegi = @p25, OgrHasZaturre = @p26, OgrHasMenenjit = @p27, OgrKan = @p28 where OgrSaglikID = @p1", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", SaglikID.Text);
                komutguncelle.Parameters.AddWithValue("@p2", konusboz);
                komutguncelle.Parameters.AddWithValue("@p3", davboz);
                komutguncelle.Parameters.AddWithValue("@p4", gorboz);
                komutguncelle.Parameters.AddWithValue("@p5", sigorta);
                komutguncelle.Parameters.AddWithValue("@p6", yuruboz);
                komutguncelle.Parameters.AddWithValue("@p7", alerji);
                komutguncelle.Parameters.AddWithValue("@p8", engel);
                komutguncelle.Parameters.AddWithValue("@p9", kaza);
                komutguncelle.Parameters.AddWithValue("@p10", hastane);
                komutguncelle.Parameters.AddWithValue("@p11", txt_OgrHastane.Text);
                komutguncelle.Parameters.AddWithValue("@p12", txt_Doktor.Text);
                komutguncelle.Parameters.AddWithValue("@p13", richTextBoxKronik.Text);
                komutguncelle.Parameters.AddWithValue("@p14", richTextBoxProtez.Text);
                komutguncelle.Parameters.AddWithValue("@p15", asifelc);
                komutguncelle.Parameters.AddWithValue("@p16", asiBCG);
                komutguncelle.Parameters.AddWithValue("@p17", asiHepatitB);
                komutguncelle.Parameters.AddWithValue("@p18", asikizamik);
                komutguncelle.Parameters.AddWithValue("@p19", asiBDT);
                komutguncelle.Parameters.AddWithValue("@p20", haskizamik);
                komutguncelle.Parameters.AddWithValue("@p21", hassarilik);
                komutguncelle.Parameters.AddWithValue("@p22", hasHepatitB);
                komutguncelle.Parameters.AddWithValue("@p23", hasHepatitA);
                komutguncelle.Parameters.AddWithValue("@p24", haskabakulak);
                komutguncelle.Parameters.AddWithValue("@p25", hassucicegi);
                komutguncelle.Parameters.AddWithValue("@p26", haszaturre);
                komutguncelle.Parameters.AddWithValue("@p27", hasmenenjit);
                komutguncelle.Parameters.AddWithValue("@p28", comboBoxOgrKan.Text);
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
            Frm_OgrKartAile frm_OgrKartAile = new Frm_OgrKartAile();
            frm_OgrKartAile.Show();
            Hide();
        }
    }
    
}
