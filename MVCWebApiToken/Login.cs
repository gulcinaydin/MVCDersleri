using MVCWebApiToken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApiToken
{
    public class Login
    {
        public static bool Giris(string ad, string parola)
        {
            using (PersonelVeritabaniEntities entity = new PersonelVeritabaniEntities())
            {
                return entity.Yetkililer.Any(x => x.kullaniciAd.Equals(ad, StringComparison.OrdinalIgnoreCase) && x.parola == parola);
            }
        }

    }
}