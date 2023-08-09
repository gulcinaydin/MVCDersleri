using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHelperGrid.Models
{
    public class Veri
    {
        private static List<Urun> _urunler = new List<Urun>(){

                new Urun { Id = 1, Ad = "Bilgisayar", Fiyat = 2000, Adet = 20 },
                new Urun { Id = 2, Ad = "Masa", Fiyat = 2001, Adet = 250 },
                new Urun { Id = 3, Ad = "Tv", Fiyat = 2002, Adet = 230 },
                new Urun { Id = 4, Ad = "Telefon", Fiyat = 200, Adet = 200 },
                new Urun { Id = 5, Ad = "Kitap", Fiyat = 205, Adet = 30 },
                new Urun { Id = 6, Ad = "Bilgisayar1", Fiyat = 2000, Adet = 20 },
                new Urun { Id = 7, Ad = "Masa1", Fiyat = 2001, Adet = 250 },
                new Urun { Id = 8, Ad = "Tv1", Fiyat = 2002, Adet = 230 },
                new Urun { Id = 9, Ad = "Telefon1", Fiyat = 200, Adet = 200 },
                new Urun { Id = 10, Ad = "Kitap1", Fiyat = 205, Adet = 30 },
                new Urun { Id = 11, Ad = "Bilgisayar2", Fiyat = 2000, Adet = 20 },
                new Urun { Id = 12, Ad = "Masa2", Fiyat = 2001, Adet = 250 },
                new Urun { Id = 13, Ad = "Tv2", Fiyat = 2002, Adet = 230 },
                new Urun { Id = 14, Ad = "Telefon2", Fiyat = 200, Adet = 200 },
                new Urun { Id = 15, Ad = "Kitap2", Fiyat = 205, Adet = 30 },

               };

        public static List<Urun> Urunler
        {
            get { return _urunler; }
        }

        public static List<Urun> UrunSorgula(string urunAd)
        {
            if (string.IsNullOrEmpty(urunAd))
                return _urunler;
            var urunler = (from u in _urunler where u.Ad.Contains(urunAd) select u).ToList();
            return urunler;
        }

    }
}