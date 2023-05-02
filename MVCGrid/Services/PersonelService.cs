using MVCGrid.Models;
using MVCGrid.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGrid.Services
{
    public class PersonelService
    {
        DatabaseContext db = new DatabaseContext();
        public string PersonelSil(int? id)
        {
            var personel = db.Personeller.Where(m => m.Id == id).FirstOrDefault();
            if (personel != null)
            {
                db.Personeller.Remove(personel);
                int deger = db.SaveChanges();
                if (deger > 0)
                {
                    return "Id'si " + personel.Id + " olan personel silindi";
                }
                else
                {
                    return personel.Ad + " Personel silinemedi potansiyel db hatası";
                }
            }
            return "Veritabanında personel bulunamadı";
        }
    }
}