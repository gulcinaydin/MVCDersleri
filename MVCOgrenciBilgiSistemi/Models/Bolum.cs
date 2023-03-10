using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOgrenciBilgiSistemi.Models
{
    public class Bolum
    {
        public int Id { get; set; }
        [DisplayName("Bölüm Adı")]
        public string Ad { get; set; }
        [Required]
        public int FakulteId { get; set; }
        [DisplayName("Bölüm Adres")]
        public string Adres { get; set; }

        public virtual Fakulte Fakulte { get; set; }
    }
}