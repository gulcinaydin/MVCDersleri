using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi.Controllers
{
    public class DosyalarController : Controller
    {
        // GET: Dosyalar
        public ActionResult Index()
        {
            return View();
        }
        public FileResult UniversiteBilgi()
        {
            string dosyaYolu = Server.MapPath("~/Files/Universitemiz.txt");
            string dosyaIcerikTur = "text/plain";
            return new FilePathResult(dosyaYolu, dosyaIcerikTur);
        }
        public FileStreamResult UniversiteStreamBilgi()
        {
            string metin = "deneme yazısı";
            MemoryStream register = new MemoryStream();
            byte[] bytes = Encoding.UTF8.GetBytes(metin);
            register.Write(bytes, 0, bytes.Length);
            register.Position = 0;
            FileStreamResult fileStreamResult = new FileStreamResult(register, "text/plain");
            fileStreamResult.FileDownloadName = "Bilgi";

            return fileStreamResult;
        }

    }
}