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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ÜrünlerButton_Click(object sender, EventArgs e)
        {
            ÜrünForm urunform = new ÜrünForm();
            urunform.Show();
            this.Hide();
        }
        
        private void ÇalışanlarButton_Click(object sender, EventArgs e)
        {
            ÇalışanForm calisanform = new ÇalışanForm();
            calisanform.Show();
            this.Hide();
        }

        private void MarketveTedarikciButton_Click(object sender, EventArgs e)
        {
            Marketler_ve_Tedarikciler marketvetedarikform = new Marketler_ve_Tedarikciler();
            marketvetedarikform.Show();
            this.Hide();
        }
        private void cikis_Click_1(object sender, EventArgs e)
        {
            login giris = new login();
            giris.Show();
            this.Hide();
        }
    }
}
