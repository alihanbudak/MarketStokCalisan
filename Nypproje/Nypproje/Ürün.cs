using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nypproje
{
    public class Ürün : Tedarik
    {
        public int ÜrünNo { get; set; }
        public string ÜrünAdi { get; set; }
        public double Fiyat { get; set; }
        public int StokMiktari { get; set; }
        public DateTime indirimTarihi { get; set; }
    }
}