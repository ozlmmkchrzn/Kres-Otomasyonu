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
    public partial class Frm_OdemeAl : Form
    {
        public Frm_OdemeAl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VOPBOLR;Initial Catalog=KresOtomasyon;Integrated Security=True");
        int SimdikiWidth;
        int Simdikiheight;
        private void Frm_OdemeAl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresOtomasyonDataSet15.Tbl_Borclar' table. You can move, or remove it, as needed.
            this.tbl_BorclarTableAdapter2.Fill(this.kresOtomasyonDataSet15.Tbl_Borclar);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BorcID from Tbl_Borclar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                veriborcid.Text = oku[0].ToString();
            }
            baglanti.Close();



            //baglanti.Open();
            //SqlCommand komutad = new SqlCommand("select OgrAd, OgrSoyad from Tbl_OgrTemel where BorcID = @c1", baglanti);
            //komutad.Parameters.AddWithValue("@c1", veriborcid.Text);
            //komutad.ExecuteNonQuery();
            //SqlDataReader okuad = komutad.ExecuteReader();
            //while (okuad.Read())
            //{
            //    txt_OgrAd.Text = oku[2].ToString();
            //    txt_OgrSoyad.Text = oku[3].ToString();
            //}
            //baglanti.Close();

            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void btn_OdemeAl_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                
                int kalanborc = Convert.ToInt32(txt_KalanBorc.Text) - Convert.ToInt32(txt_Yatirilan.Text);
                int kalantaksit = Convert.ToInt32(txt_KalanTaksit.Text) - 1;
                int yatirilantoplam = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[2].Value.ToString()) + Convert.ToInt32(txt_Yatirilan.Text);
                

                baglanti.Open();
                SqlCommand komutguncelle = new SqlCommand("update Tbl_Borclar Set TaksitSayisi = @p4, Yatirilan = @p5, KalanBorc = @p6 where BorcID = @p1", baglanti);
                komutguncelle.Parameters.AddWithValue("@p1", txt_BorcID.Text);
                komutguncelle.Parameters.AddWithValue("@p4", kalantaksit);
                komutguncelle.Parameters.AddWithValue("@p5", yatirilantoplam);
                komutguncelle.Parameters.AddWithValue("@p6", kalanborc);
                komutguncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ödeme alma işlemi başarılı");

                this.tbl_BorclarTableAdapter2.Fill(this.kresOtomasyonDataSet15.Tbl_Borclar);



            }
            catch (Exception p)
            {
                MessageBox.Show("Hata! Ödeme alma işlemi başarısız!" + p.Message);
            }
        }

        int secilen;
        string id, ad, soyad, taksit, yatirilan, kalanborc;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            taksit = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yatirilan = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalanborc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txt_BorcID.Text = id;
            txt_KalanTaksit.Text = taksit;
            txt_Yatirilan.Text = yatirilan;
            txt_KalanBorc.Text = kalanborc;

            
        }
        
    }
}
