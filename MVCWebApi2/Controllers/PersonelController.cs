using MVCWebApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApi2.Controllers
{
    [RoutePrefix("api/personel")]
    public class PersonelController : ApiController
    {
        static List<Personel> personelList = new List<Personel>()
        {
            new Personel(){Id=1,Ad="Ali"},
            new Personel(){Id=2,Ad="Osman"}

        };
        private object ad;

        [Route("")]
        public IEnumerable<Personel> Get()
        {
            return personelList;
        }

        [Route("{id:int}")]
        public Personel Get(int id)
        {
            return personelList.FirstOrDefault(p => p.Id == id);
        }

        [Route("default/{id:decimal=2}")]
        public Personel Get(decimal id)
        {
            return personelList.FirstOrDefault(p => p.Id == id);
        }

        [Route("{ad:alpha:ilkh}")]
        public Personel Get(string ad)
        {
            return personelList.FirstOrDefault(p => p.Ad.ToUpper() == ad.ToUpper());
        }

        [Route("{id}/gorev")]
        public string GetGorev(int id)
        {
            switch (id)
            {
                case 1:
                    return "görev1";
                case 2:
                    return "görev2";
                default:
                    return null;
            }
        }

        [Route("~/api/gorevler")]
        public IEnumerable<string> GetGorev()
        {
            return new List<string> { "görev1", "görev2" };
        }
    }
}
