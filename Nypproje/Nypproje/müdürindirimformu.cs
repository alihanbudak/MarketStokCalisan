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
    public partial class müdürindirimformu : Form
    {
        List<Ürün> ürüns2 = new List<Ürün>();
        public void ürünListele()
        {

            for (int i = 0; i < ürüns2.Count; i++)
            listBox1.Items.Add(ürüns2[i].ÜrünNo + "\t" + ürüns2[i].ÜrünAdi + "\t" + ürüns2[i].SubeAdi + "\t" + ürüns2[i].TedarikciAdi + "\t" + ürüns2[i].Fiyat + "\t" + ürüns2[i].StokMiktari + "\t\t" + ürüns2[i].indirimTarihi);  
        }
        public müdürindirimformu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear();
            ürüns2.Clear();
            ürüns2.Add(new Ürün()
            {

                ÜrünNo = 1,
                SubeAdi = "Şube1",
                TedarikciAdi = "Gıda Tedarik",
                ÜrünAdi = "Ekmek",
                Fiyat = 1.5,
                StokMiktari = 20,
            });
            ürüns2.Add(new Ürün()
            {
                ÜrünNo = 2,
                SubeAdi = "Şube1",
                TedarikciAdi = "Temizlik Tedarik",
                ÜrünAdi = "Bez",
                Fiyat = 10,
                StokMiktari = 30,
            });
            ürüns2.Add(new Ürün()
            {
                ÜrünNo = 3,
                SubeAdi = "Şube2",
                TedarikciAdi = "Temizlik Tedarik",
                ÜrünAdi = "Sabun",
                Fiyat = 12,
                StokMiktari = 15,
            });
            ürüns2.Add(new Ürün()
            {
                ÜrünNo = 4,
                SubeAdi = "Şube2",
                TedarikciAdi = "Kampanya Tedarik",
                ÜrünAdi = "Şampuan",
                Fiyat = 10,
                StokMiktari = 10,
            });
            ürüns2.Add(new Ürün()
            {
                ÜrünNo = 5,
                SubeAdi = "Şube1",
                TedarikciAdi = "Kampanya Tedarik",
                ÜrünAdi = "Sucuk",
                Fiyat = 25,
                StokMiktari = 35,
            });
            ürünListele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

      
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            login giris = new login();
            giris.Show();
            this.Hide();

        }

        private void indirimbutonu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ürüns2.Count; i++)
            {
                if (ürüns2[i].ÜrünNo == Convert.ToInt32(textBox1.Text))
                {
                    if (ürüns2[i].TedarikciAdi == "Kampanya Tedarik")
                    {
                        ürüns2[i].indirimTarihi = DateTime.Now;
                        ürüns2[i].Fiyat -= ürüns2[i].Fiyat * Convert.ToDouble(textBox2.Text) / 100;
                        MessageBox.Show("İndirim Başarılı...");
                    }
                    else
                    { 
                        MessageBox.Show("Sadece Kampanya Tedarik Ürünlerine İndirim Yapabilirsiniz...");
                    break;
                    }
                }
               
            }
            listBox1.Items.Clear();
            ürünListele();
        }

    }
}

