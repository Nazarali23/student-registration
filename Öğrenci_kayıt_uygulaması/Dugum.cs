using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_ekle_çıkar
{
    public class Dugum
    {
        public string Ad;
        public string Soyad;
        public int    Numara;
        public string Bolum;
        public string Adres;

        public Dugum next;
        public Dugum prev;

        public Dugum(string ad, string soyad, int numara, string bolum, string adres)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Numara = numara;
            this.Bolum = bolum;
            this.Adres = adres;
            next = null;
            prev = null;
        }

    }
}
