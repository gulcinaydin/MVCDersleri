using MVCAsekron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAsekron.Controllers
{
    public class PersonelController : AsyncController
    {
        public async void PersonelListesiAsync()
        {
            PersonelVeri veri = new PersonelVeri();
            AsyncManager.Parameters["personeller"] = await veri.GetirPersoneller();
        }

        public ActionResult PersonelListesiCompleted(List<Personel> personeller)
        {
            return View(personeller);
        }
    }
}