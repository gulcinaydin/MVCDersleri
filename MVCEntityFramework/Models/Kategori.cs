using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFramework.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<Urun> Urun { get; set; }
    }
}