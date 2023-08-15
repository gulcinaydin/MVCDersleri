using MVCAjaxIslemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAjaxIslemleri.Controllers
{
    public class UrunApiController : ApiController
    {
        [HttpGet]
        public Urun Urun()
        {
            var urun = (from u in Veri.Urunler
                        where u.Id == 1
                        select u).FirstOrDefault();
            return urun;
        }

        [HttpPost]
        public void Kaydet(Urun yeniurun)
        {
            Veri.Urunler.Add(yeniurun);
        }
    }
}
