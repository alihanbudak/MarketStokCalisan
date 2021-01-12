using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nypproje
{
    public partial class ÇalışanForm : Form
    {
        public ÇalışanForm()
        {
            InitializeComponent();
        }
        Market sube1 = new Market();
        Market sube2 = new Market();
        private void button1_Click(object sender, EventArgs e)
        {
            sube1.müdür = new Çalışan { CalisanNo = 1, CalisanAdi = "Alpay Duymaz", SubeAdi = "Şube1",CalistigiPozisyon = "Müdür", Maas = 7500, HaftalıkizinKullanımı = true, KalanYıllıkİzin = 14, Adres = "Çeştepe Mahallesi,İnönü Caddesi,No:42 Efeler/Aydın" };
            sube1.müdüryardımcısı = new Çalışan { CalisanNo = 2, CalisanAdi = "Muhammet Akyıldız", SubeAdi = "Şube1", CalistigiPozisyon = "Müdür Yrd", Maas = 6500, HaftalıkizinKullanımı = false, KalanYıllıkİzin = 7, Adres = "Çeştepe Mahallesi,Atatürk Caddesi,No:24 Efeler/Aydın" };
            sube1.kasiyer = new Çalışan { CalisanNo = 3, CalisanAdi = "Çağatay Yunus", SubeAdi = "Şube1", CalistigiPozisyon = "Kasiyer", Maas = 3000, HaftalıkizinKullanımı = true, KalanYıllıkİzin = 4, Adres = "Kurtuluş Mahallesi,Efeler Caddesi,No:11 Efeler/Aydın" };
            sube2.müdür = new Çalışan { CalisanNo = 4, CalisanAdi = "Alihan Budak", SubeAdi = "Şube2", CalistigiPozisyon = "Müdür", Maas = 7500, HaftalıkizinKullanımı = true, KalanYıllıkİzin = 14, Adres = "Çeştepe Mahallesi,İnönü Caddesi,No:42 Efeler/Aydın" };
            sube2.müdüryardımcısı = new Çalışan { CalisanNo = 5, CalisanAdi = "Ozan Varol", SubeAdi = "Şube2", CalistigiPozisyon = "Müdür Yrd", Maas = 6500, HaftalıkizinKullanımı = false, KalanYıllıkİzin = 7, Adres = "Çeştepe Mahallesi,Atatürk Caddesi,No:24 Efeler/Aydın" };
            sube2.kasiyer = new Çalışan { CalisanNo = 6, CalisanAdi = "Yusuf Babat", SubeAdi = "Şube2", CalistigiPozisyon = "Kasiyer", Maas = 3500, HaftalıkizinKullanımı = true, KalanYıllıkİzin = 14, Adres = "Çeştepe Mahallesi,Menderes Caddesi,No:4 Efeler/Aydın" };
            MessageBox.Show("Tüm Çalışanların Bilgileri Yüklendi");
        }      
        public void tümsubeleriGörüntüle()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(sube1.müdür.CalisanNo.ToString() + "\t" + sube1.müdür.CalisanAdi + "\t" + sube1.müdür.SubeAdi + "\t" + sube1.müdür.CalistigiPozisyon + "\t" + sube1.müdür.maas.ToString() + "\t" + sube1.müdür.HaftalıkizinKullanımı.ToString() + " \t" + sube1.müdür.KalanYıllıkİzin.ToString() + "\t\t\t" + sube1.müdür.Adres);
            listBox1.Items.Add(sube1.müdüryardımcısı.CalisanNo.ToString() + "\t" + sube1.müdüryardımcısı.CalisanAdi + "\t" + sube1.müdüryardımcısı.SubeAdi + "\t" + sube1.müdüryardımcısı.CalistigiPozisyon + " " + sube1.müdüryardımcısı.maas.ToString() + " \t" + sube1.müdüryardımcısı.HaftalıkizinKullanımı.ToString() + " \t" + sube1.müdüryardımcısı.KalanYıllıkİzin.ToString() + "\t\t\t" + sube1.müdüryardımcısı.Adres);
            listBox1.Items.Add(sube1.kasiyer.CalisanNo.ToString() + "\t" + sube1.kasiyer.CalisanAdi + "\t" + sube1.kasiyer.SubeAdi + "\t" + sube1.kasiyer.CalistigiPozisyon + "\t" + sube1.kasiyer.maas.ToString() + "\t" + sube1.kasiyer.HaftalıkizinKullanımı.ToString() + " \t" + sube1.kasiyer.KalanYıllıkİzin.ToString() + "\t\t\t" + sube1.kasiyer.Adres);
            listBox1.Items.Add(sube2.müdür.CalisanNo.ToString() + "\t" + sube2.müdür.CalisanAdi + "\t" + sube2.müdür.SubeAdi + "\t" + sube2.müdür.CalistigiPozisyon + "\t" + sube2.müdür.maas.ToString() + "\t" + sube2.müdür.HaftalıkizinKullanımı.ToString() + " \t" + sube2.müdür.KalanYıllıkİzin.ToString() + "\t\t\t" + sube2.müdür.Adres);
            listBox1.Items.Add(sube2.müdüryardımcısı.CalisanNo.ToString() + "\t" + sube2.müdüryardımcısı.CalisanAdi + "\t" + sube2.müdüryardımcısı.SubeAdi + "\t" + sube2.müdüryardımcısı.CalistigiPozisyon + " " + sube2.müdüryardımcısı.maas.ToString() + " \t" + sube2.müdüryardımcısı.HaftalıkizinKullanımı.ToString() + " \t" + sube2.müdüryardımcısı.KalanYıllıkİzin.ToString() + "\t\t\t" + sube2.müdüryardımcısı.Adres);
            listBox1.Items.Add(sube2.kasiyer.CalisanNo.ToString() + "\t" + sube2.kasiyer.CalisanAdi + "\t" + sube2.kasiyer.SubeAdi + "\t" + sube2.kasiyer.CalistigiPozisyon + "\t" + sube2.kasiyer.maas.ToString() + "\t" + sube2.kasiyer.HaftalıkizinKullanımı.ToString() + " \t" + sube2.kasiyer.KalanYıllıkİzin.ToString() + "\t\t\t" + sube2.kasiyer.Adres);
        }
        public void sube1Görüntüle()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(sube1.müdür.CalisanNo.ToString() + "\t" + sube1.müdür.CalisanAdi + "\t" + sube1.müdür.SubeAdi + "\t" + sube1.müdür.CalistigiPozisyon + "\t" + sube1.müdür.maas.ToString() + "\t" + sube1.müdür.HaftalıkizinKullanımı.ToString() + " \t " + sube1.müdür.KalanYıllıkİzin.ToString() + "\t\t\t" + sube1.müdür.Adres);
            listBox1.Items.Add(sube1.müdüryardımcısı.CalisanNo.ToString() + "\t" + sube1.müdüryardımcısı.CalisanAdi + "\t" + sube1.müdüryardımcısı.SubeAdi + "\t" + sube1.müdüryardımcısı.CalistigiPozisyon + " " + sube1.müdüryardımcısı.maas.ToString() + " \t" + sube1.müdüryardımcısı.HaftalıkizinKullanımı.ToString() + " \t" + sube1.müdüryardımcısı.KalanYıllıkİzin.ToString() + "\t\t\t" + sube1.müdüryardımcısı.Adres);
            listBox1.Items.Add(sube1.kasiyer.CalisanNo.ToString() + "\t" + sube1.kasiyer.CalisanAdi + "\t" + sube1.kasiyer.SubeAdi + "\t" + sube1.kasiyer.CalistigiPozisyon + "\t" + sube1.kasiyer.maas.ToString() + "\t" + sube1.kasiyer.HaftalıkizinKullanımı.ToString() + " \t" + sube1.kasiyer.KalanYıllıkİzin.ToString() + "\t\t\t" + sube1.kasiyer.Adres);
        }
        public void sube2Görüntüle()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(sube2.müdür.CalisanNo.ToString() + "\t" + sube2.müdür.CalisanAdi + "\t" + sube2.müdür.SubeAdi + "\t" + sube2.müdür.CalistigiPozisyon + "\t" + sube2.müdür.maas.ToString() + "\t" + sube2.müdür.HaftalıkizinKullanımı.ToString() + " \t" + sube2.müdür.KalanYıllıkİzin.ToString() + "\t\t\t" + sube2.müdür.Adres);
            listBox1.Items.Add(sube2.müdüryardımcısı.CalisanNo.ToString() + "\t" + sube2.müdüryardımcısı.CalisanAdi + "\t" + sube2.müdüryardımcısı.SubeAdi + "\t" + sube2.müdüryardımcısı.CalistigiPozisyon + " " + sube2.müdüryardımcısı.maas.ToString() + " \t" + sube2.müdüryardımcısı.HaftalıkizinKullanımı.ToString() + " \t" + sube2.müdüryardımcısı.KalanYıllıkİzin.ToString() + "\t\t\t" + sube2.müdüryardımcısı.Adres);
            listBox1.Items.Add(sube2.kasiyer.CalisanNo.ToString() + "\t" + sube2.kasiyer.CalisanAdi + "\t" + sube2.kasiyer.SubeAdi + "\t" + sube2.kasiyer.CalistigiPozisyon + "\t" + sube2.kasiyer.maas.ToString() + "\t" + sube2.kasiyer.HaftalıkizinKullanımı.ToString() + " \t" + sube2.kasiyer.KalanYıllıkİzin.ToString() + "\t\t\t" + sube2.kasiyer.Adres);
        }
        private void TümsubGörünt_Click(object sender, EventArgs e)
        {
            tümsubeleriGörüntüle();
        }
        private void Sube1Görünt_Click(object sender, EventArgs e)
        {
            sube1Görüntüle();
        }   
        private void Sube2Görünt_Click(object sender, EventArgs e)
        {
            sube2Görüntüle();
        }
        private void Şube1arttır_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtArtacakmiktar.Text) > 0)
            {
                if (cmbbxpozisyon.Text == "Müdür" && sube1.müdür.CalisanNo == Convert.ToInt32(txtCalisanno.Text))
                    sube1.müdür.Maas += Convert.ToInt32(txtArtacakmiktar.Text);
                else if (cmbbxpozisyon.Text == "Müdür Yardımcısı" && sube1.müdüryardımcısı.CalisanNo == Convert.ToInt32(txtCalisanno.Text))
                    sube1.müdüryardımcısı.Maas += Convert.ToInt32(txtArtacakmiktar.Text);
                else if (cmbbxpozisyon.Text == "Kasiyer" && sube1.kasiyer.CalisanNo == Convert.ToInt32(txtCalisanno.Text))
                    sube1.kasiyer.Maas += Convert.ToInt32(txtArtacakmiktar.Text);
                sube1Görüntüle();
            }
            else MessageBox.Show("Çalışanların maaşı azaltılamaz.");
        }
        private void Sube2arttır_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtArtacakmiktar.Text) > 0)
            {
                if (cmbbxpozisyon.Text == "Müdür" && sube2.müdür.CalisanNo == Convert.ToInt32(txtCalisanno.Text))
                    sube2.müdür.Maas += Convert.ToInt32(txtArtacakmiktar.Text);
                else if (cmbbxpozisyon.Text == "Müdür Yardımcısı" && sube2.müdüryardımcısı.CalisanNo == Convert.ToInt32(txtCalisanno.Text))
                    sube2.müdüryardımcısı.Maas += Convert.ToInt32(txtArtacakmiktar.Text);
                else if (cmbbxpozisyon.Text == "Kasiyer" && sube2.kasiyer.CalisanNo == Convert.ToInt32(txtCalisanno.Text))
                    sube2.kasiyer.Maas += Convert.ToInt32(txtArtacakmiktar.Text);
                sube2Görüntüle();
            }
            else MessageBox.Show("Çalışanların maaşı azaltılamaz.");
        }
        private void Sub1Terfi_Click(object sender, EventArgs e)
        {
            if (cmb1Terfi.Text == "Müdür Yardımcısı" && sube1.müdüryardımcısı.CalisanNo == Convert.ToInt32(txtClsnNoTerfi.Text))
            {
                sube1.müdüryardımcısı.CalistigiPozisyon = "Müdür";
                MessageBox.Show("Birinci şubede ki müdür yardımcısı müdürlüğe terfi edildi");
            }  
            else if (sube1.kasiyer.CalistigiPozisyon == cmb1Terfi.Text && sube1.kasiyer.CalisanNo == Convert.ToInt32(txtClsnNoTerfi.Text))
            {
                sube1.kasiyer.CalistigiPozisyon = "Müdür Yrd";
                MessageBox.Show("Birinci şubede ki kasiyer müdür yardımcılığına terfi edildi");
            }             
            sube1Görüntüle();
        }
        private void Sub2Terfi_Click(object sender, EventArgs e)
        {
            if (cmb1Terfi.Text == "Müdür Yardımcısı" && sube2.müdüryardımcısı.CalisanNo == Convert.ToInt32(txtClsnNoTerfi.Text))
            {
                sube2.müdüryardımcısı.CalistigiPozisyon = "Müdür";
                MessageBox.Show("İkinci şubede ki müdür yardımcısı müdürlüğe terfi edildi");
            }
            else if (sube2.kasiyer.CalistigiPozisyon == cmb1Terfi.Text && sube2.kasiyer.CalisanNo == Convert.ToInt32(txtClsnNoTerfi.Text))
            {
                sube2.kasiyer.CalistigiPozisyon = "Müdür Yrd";
                MessageBox.Show("İkinci şubede ki kasiyer müdür yardımcılığına terfi edildi");
            }
            sube2Görüntüle();
        }
        private void Sube1clsnDegistir_Click(object sender, EventArgs e)
        {
            if (cmbSubdegistir.Text == "Müdür" && sube1.müdür.CalisanNo == Convert.ToInt32(txtSubDegistir.Text))
                sube1.müdür.SubeAdi = "Şube2";
            else if (cmbSubdegistir.Text == "Müdür Yardımcısı" && sube1.müdüryardımcısı.CalisanNo == Convert.ToInt32(txtSubDegistir.Text))
                sube1.müdüryardımcısı.SubeAdi = "Şube2";
            else if (cmbSubdegistir.Text == "Kasiyer" && sube1.kasiyer.CalisanNo == Convert.ToInt32(txtSubDegistir.Text))
                sube1.kasiyer.SubeAdi = "Şube2";
            sube1Görüntüle();
        }
        private void Sub2clsnDegistir_Click(object sender, EventArgs e)
        {
            if (cmbSubdegistir.Text == "Müdür" && sube2.müdür.CalisanNo == Convert.ToInt32(txtSubDegistir.Text))
                sube2.müdür.SubeAdi = "Şube1";
            else if (cmbSubdegistir.Text == "Müdür Yardımcısı" && sube2.müdüryardımcısı.CalisanNo == Convert.ToInt32(txtSubDegistir.Text))
                sube2.müdüryardımcısı.SubeAdi = "Şube1";
            else if (cmbSubdegistir.Text == "Kasiyer" && sube2.kasiyer.CalisanNo == Convert.ToInt32(txtSubDegistir.Text))
                sube2.kasiyer.SubeAdi = "Şube1";
            sube2Görüntüle();
        }
        private void AnaMenüButton_Click(object sender, EventArgs e)
        {
            Form1 anamenudon = new Form1();
            anamenudon.Show();
            this.Hide();
        }
    }
}