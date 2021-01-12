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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Market Sube = new Market();
            Sube.müdür = new Çalışan();
            Sube.patron = new Çalışan();
            Sube.patron.CalistigiPozisyon = "patron";
            Sube.patron.Sifre = "1234";
            Sube.müdür.CalistigiPozisyon = "müdür";
            Sube.müdür.Sifre = "0000";
            
            if (Sube.patron.CalistigiPozisyon == txtKullanıcıAdı.Text && Sube.patron.Sifre == txtSifre.Text)
            {
                Form1 anamenü = new Form1();
                anamenü.Show();
                this.Hide();
            }
            else if (Sube.müdür.CalistigiPozisyon == txtKullanıcıAdı.Text && Sube.müdür.Sifre == txtSifre.Text)
            {

                müdürindirimformu indirimform = new müdürindirimformu();
                indirimform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...");
                txtKullanıcıAdı.Clear();
                txtSifre.Clear();
            }
                
        }
    }
}
