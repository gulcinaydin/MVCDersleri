using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MVCAsekron.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    public class PersonelVeri
    {
        public async Task<List<Personel>> GetirPersoneller()
        {
            var personeller = Task.Factory.StartNew(() =>
            {
                return new List<Personel>
                {
                    new Personel { Id=1,Ad="Ali",Soyad="Hazır"},
                    new Personel { Id=2,Ad="Ali",Soyad="Hazır"}
                };
            });

            return await personeller;
        }
    }
}