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
  
    public partial class ÜrünForm : Form
    {
        public List<Ürün> ürüns = new List<Ürün>();
        public void ürünListele()
        {

            for (int i = 0; i < ürüns.Count; i++)
            {
                if (comboBox1.Text == ürüns[i].SubeAdi && comboBox4.Text == ürüns[i].TedarikciAdi) //Seçilen Şube ve Tedarikçi İçin
                    listBox1.Items.Add(ürüns[i].ÜrünNo + "\t" + ürüns[i].ÜrünAdi + "\t" + ürüns[i].SubeAdi + "\t" + ürüns[i].TedarikciAdi + "\t" + ürüns[i].Fiyat + "\t" + ürüns[i].StokMiktari + "\t" + ürüns[i].indirimTarihi);
                else if (comboBox1.Text == ürüns[i].SubeAdi && comboBox4.Text == "Tüm Tedarikçiler") //Seçilen Şube ve Tüm Tedarikçiler İçin
                    listBox1.Items.Add(ürüns[i].ÜrünNo + "\t" + ürüns[i].ÜrünAdi + "\t" + ürüns[i].SubeAdi + "\t" + ürüns[i].TedarikciAdi + "\t" + ürüns[i].Fiyat + "\t" + ürüns[i].StokMiktari + "\t" + ürüns[i].indirimTarihi);
                else if (comboBox1.Text == "Tüm Şubeler" && comboBox4.Text == ürüns[i].TedarikciAdi) //Tüm Şubelerdeki Seçilen Tedarikçi İçin
                    listBox1.Items.Add(ürüns[i].ÜrünNo + "\t" + ürüns[i].ÜrünAdi + "\t" + ürüns[i].SubeAdi + "\t" + ürüns[i].TedarikciAdi + "\t" + ürüns[i].Fiyat + "\t" + ürüns[i].StokMiktari + "\t" + ürüns[i].indirimTarihi);
                else if (comboBox1.Text == "Tüm Şubeler" && comboBox4.Text == "Tüm Tedarikçiler")   //Tüm Şubelerdeki Tüm Tedarikçiler İçin
                    listBox1.Items.Add(ürüns[i].ÜrünNo + "\t" + ürüns[i].ÜrünAdi + "\t" + ürüns[i].SubeAdi + "\t" + ürüns[i].TedarikciAdi + "\t" + ürüns[i].Fiyat + "\t" + ürüns[i].StokMiktari + "\t" + ürüns[i].indirimTarihi);
            }
        }
        public ÜrünForm()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ÜrünForm_Load(object sender, EventArgs e)
        {

        }

        private void Ürünlist_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ürüns.Clear();
            ürüns.Add(new Ürün()
            {

                ÜrünNo = 1,
                SubeAdi = "Şube1",
                TedarikciAdi = "Gıda Tedarik",
                ÜrünAdi = "Ekmek",
                Fiyat = 1.5,
                StokMiktari = 20,
            });
            ürüns.Add(new Ürün()
            {
                ÜrünNo = 2,
                SubeAdi = "Şube1",
                TedarikciAdi = "Temizlik Tedarik",
                ÜrünAdi = "Bez",
                Fiyat = 10,
                StokMiktari = 30,
            });
            ürüns.Add(new Ürün()
            {
                ÜrünNo = 3,
                SubeAdi = "Şube2",
                TedarikciAdi = "Temizlik Tedarik",
                ÜrünAdi = "Sabun",
                Fiyat = 12,
                StokMiktari = 15,
            });
            ürüns.Add(new Ürün()
            {
                ÜrünNo = 4,
                SubeAdi = "Şube2",
                TedarikciAdi = "Kampanya Tedarik",
                ÜrünAdi = "Şampuan",
                Fiyat = 10,
                StokMiktari = 10,
            });
            ürüns.Add(new Ürün()
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

        private void AnaMenuDon_Click(object sender, EventArgs e)
        {
            Form1 anamenü = new Form1();
            anamenü.Show();
            this.Hide();
        }

        private void Ürünekle_Click(object sender, EventArgs e)
        {
            ürüns.Add(new Ürün()
            {
                ÜrünNo = Convert.ToInt32(txtÜrünNo.Text),
                SubeAdi = comboBox2.Text,
                TedarikciAdi = comboBox3.Text,
                ÜrünAdi = txtÜrünAdı.Text,
                Fiyat = Convert.ToDouble(txtFiyat.Text),
                StokMiktari = Convert.ToInt32(txtStok.Text),
            });
            MessageBox.Show("Ürün Eklendi");
            listBox1.Items.Clear();
            ürünListele();
        }

        private void İndirimYapmaButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ürüns.Count; i++)
                if (ürüns[i].ÜrünNo == Convert.ToInt32(textBox1.Text))
                {
                    ürüns[i].indirimTarihi = DateTime.Now;
                    ürüns[i].Fiyat -= ürüns[i].Fiyat * Convert.ToDouble(textBox2.Text) / 100;
                    MessageBox.Show("İndirim Başarılı...");
                }
                    listBox1.Items.Clear();
                    ürünListele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
