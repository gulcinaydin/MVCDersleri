﻿using MVCOgrenciBilgiSistemi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi.Controllers
{
    public class BolumController : Controller
    {
        OBSContext veritabani = new OBSContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult FakultedekiBolumler(int? id)
        {
            if (id == null) id = 1;

            var bolumler = (from b in veritabani.Bolumler where b.FakulteId == id select b).ToList();
            ViewBag.Bolumler = bolumler;
            return PartialView();
        }
    }
}