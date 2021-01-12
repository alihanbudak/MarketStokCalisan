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
    public partial class Marketler_ve_Tedarikciler : Form
    {
        public Marketler_ve_Tedarikciler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Market şube1 = new Market { Adres = "AAA Mahallesi, BBB Caddesi, CCC Sokak, No:4", SubeAdi = "Şube1" };
            Market şube2 = new Market { Adres = "YYY Mahallesi, KKK Caddesi, LLL Sokak, No:4", SubeAdi = "Şube2" };
            listBox1.Items.Add(şube1.Adres + "\t\t\t" + şube1.SubeAdi);
            listBox1.Items.Add(şube2.Adres + "\t\t\t" + şube2.SubeAdi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Tedarik gida = new Tedarik {Adres = "AA Mahallesi, BB Caddesi, CC Sokak, No:4", TedarikciAdi = "Gıda Tedarik" };
            Tedarik temizlik = new Tedarik {Adres = "EE Mahallesi, HH Caddesi, UU Sokak, No:8", TedarikciAdi = "Temizlik Tedarik" };
            Tedarik kampanya = new Tedarik {Adres = "NN Mahallesi, MM Caddesi, TT Sokak, No:9", TedarikciAdi = "Kampanya Tedarik" };
            listBox1.Items.Add(gida.Adres + "\t\t" + gida.TedarikciAdi);
            listBox1.Items.Add(temizlik.Adres + "\t\t" + temizlik.TedarikciAdi);
            listBox1.Items.Add(kampanya.Adres + "\t\t" + kampanya.TedarikciAdi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.Show();
            this.Hide();
        }
    }
}
