using MVCModelExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelExample.Veri
{
    public class PersonelVeriler
    {
        public static List<Personel> listPersoneller = new List<Personel>()
        {
            new Personel
            {
                Id=1,
                Ad="Ali",
                Soyad="Hazır",
                TCKN=11111111111,
                DogumTarihi=new DateTime(1990,12,28),
            },
            new Personel
            {
               Id =2,
               Ad="mert",
               Soyad="aktaş",
               TCKN=22222222222,
               DogumTarihi= new DateTime(1999,07,19),
            },
            new Personel
            {
               Id =3,
               Ad="gülçin",
               Soyad="aktaş",
               TCKN=33333333333,
               DogumTarihi= new DateTime(1999,07,19),
            }

        };

    }
}