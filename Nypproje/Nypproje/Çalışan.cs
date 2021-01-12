using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nypproje
{
    public class Çalışan:Market
    {
        public int CalisanNo { get; set; }
        public string CalisanAdi { get; set; }
        public string CalistigiPozisyon { get; set; }
        public int maas;
        public int Maas
        {
            get
            {
                return maas;
            }
            set
            {
                if (Maas < value)
                {
                    maas = value;
                }
            }
        }
        public bool HaftalıkizinKullanımı { get; set; }
        public int KalanYıllıkİzin { get; set; }
        public string Sifre { get; set; }
    }
}
