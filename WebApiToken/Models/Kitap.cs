using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiToken.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAd { get; set; }
        public string YazarAd { get; set; }
    }
}