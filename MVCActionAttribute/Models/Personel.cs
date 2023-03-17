using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionAttribute.Models
{
    [Bind(Exclude = "TCKimlikNo")]
    public class Personel
    {
        public int Id { get; set; }

        [DisplayName("Personel Ad")]
        public string Ad { get; set; }
        [DisplayName("Personel Soyad")]
        public string Soyad { get; set; }
        [DisplayName("Personel TC Kimlik")]
        public string TCKimlikNo { get; set; }

    }
}