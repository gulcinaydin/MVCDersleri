using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApi.Controllers
{
    public class UrunController : ApiController
    {
        private List<Urun> urunlerList = new List<Urun>
        {
            new Urun{Id=1,Ad="Masaüstü Bilgisayar",Fiyat=3000,KategoriAd="Bilgisayar",StokMiktari=100},
            new Urun{Id=2,Ad="Dizüstü Bilgisayar",Fiyat=3001,KategoriAd="Bilgisayar",StokMiktari=101},
            new Urun{Id=3,Ad="Cep Telefonu",Fiyat=300,KategoriAd="Telefon",StokMiktari=1500},
            new Urun{Id=4,Ad="Ev Telefonu",Fiyat=30,KategoriAd="Telefon",StokMiktari=1200},
        };

        public IEnumerable<Urun> GetAllUrun()
        {
            return urunlerList;
        }

        public IHttpActionResult GetUrun(int id)
        {
            return Unauthorized();
            var arananUrun = (from u in urunlerList
                              where u.Id == id
                              select u);

            if (arananUrun.Count() == 0)
                return NotFound();
            else
                return Ok(arananUrun.FirstOrDefault());


        }
        [HttpPost]
        public IHttpActionResult Post(Urun urun)
        {
            if (urunlerList.Where(u => u.Id == urun.Id).Count() == 0)
            {
                return Ok();

            }
            else
                return Conflict();
        }
    }
}
