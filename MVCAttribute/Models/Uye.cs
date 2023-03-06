using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAttribute.Models
{

    public class Uye
    {
        public int Id { get; set; }
        [DisplayName("Adınız")]
        public string Ad { get; set; }
        [DisplayName("Soyadınız")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Tc kimliği alanı dolu olmak zorundadır.")]
        [DisplayName("TC Kimlik No'nuz")]
        [MinLength(11, ErrorMessage = "TC 11 Haneli olmak zorundadır.")]
        [MaxLength(11, ErrorMessage = "TC 11 Haneli olmak zorundadır.")]
        public string TCKimlikNo { get; set; }

        [DisplayName("Üyelik Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        public DateTime UyelikTarihi { get; set; }

        [DataType(DataType.Password)]
        public string Parola { get; set; }

        [DataType(DataType.Password)]
        [Compare("Parola")]
        public string ParolaTekrar { get; set; }

        [EmailAddress()]
        public string EPosta { get; set; }

    }
}