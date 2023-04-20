using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KresOtomasyon
{
    public partial class Frm_AnaSayfa : Form
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_YeniOgrTemel frm_YeniOgrTemel = new Frm_YeniOgrTemel();
            frm_YeniOgrTemel.Show();
            
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Listele frm_Listele = new Frm_Listele();
            frm_Listele.Show();
            
        }

        private void yenhiSınıfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SinifEkle frm_SinifEkle = new Frm_SinifEkle();
            frm_SinifEkle.Show();
            
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Personel frm_Personel = new Frm_Personel();
            frm_Personel.Show();
            
        }

        private void sınıfListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SinifListele frm_SinifListele = new Frm_SinifListele();
            frm_SinifListele.Show();
            
        }

        int SimdikiWidth = 592;
        int Simdikiheight = 869;
        private void Frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Rectangle ClienCozunurluk = new Rectangle();
            //ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            //float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            //float OranHeight = ((float)ClienCozunurluk.Height / (float)Simdikiheight);
            //this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void yeniEtkinlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_YeniEtkinlik frm_YeniEtkinlik = new Frm_YeniEtkinlik();
            frm_YeniEtkinlik.Show();
            
        }

        private void etkinlikListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EtkinlikListele frm_EtkinlikListele = new Frm_EtkinlikListele();
            frm_EtkinlikListele.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GiderEkle frm_GiderEkle = new Frm_GiderEkle();
            frm_GiderEkle.Show();
        }

        private void giderlerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GiderListele frm_GiderListele = new Frm_GiderListele();
            frm_GiderListele.Show();
        }

        private void gelirListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GelirListele frm_GelirListele = new Frm_GelirListele();
            frm_GelirListele.Show();
        }

        private void gelirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OdemeAl frm_OdemeAl = new Frm_OdemeAl();
            frm_OdemeAl.Show();
        }

        

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KullaniciEkle frm_KullaniciEkle = new Frm_KullaniciEkle();
            frm_KullaniciEkle.Show();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PersonelListele frm_PersonelListele = new Frm_PersonelListele();
            frm_PersonelListele.Show();
        }

        private void servisGüzergahıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ServisGuzergahEkle frm_ServisGuzergahEkle = new Frm_ServisGuzergahEkle();
            frm_ServisGuzergahEkle.Show();
        }

        
    }
}
