using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelExample.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }

    }
}