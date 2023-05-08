using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApiRouting.Controllers
{
    public class ValuesController : ApiController
    {

        static List<string> liste = new List<string>()
        {
            "ilk değer","ikinci değer"
        };

        // GET api/values
        [HttpGet]
        public IEnumerable<string> ListeGetir()
        {
            return liste;
        }


        // GET api/values/5
        [HttpGet]
        public string ListedenDegerGetir(int id)
        {
            return liste[id];
        }

        // POST api/values
        [HttpPost]
        public string ListeEkle([FromBody] string value)
        {
            liste.Add(value);
            return "başarı ile eklendi.";
        }

        // PUT api/values/5
        [HttpPut]
        public string ListeGuncelle(int id, [FromBody] string value)
        {
            liste[id] = value;
            return "başarı ile güncellendi.";
        }

        // DELETE api/values/5
        [HttpDelete]
        public string ListeSil(int id)
        {
            liste.RemoveAt(id);
            return "başarı ile silindi";
        }
    }
}
