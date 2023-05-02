using MVCRouting.RouteConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Anasayfa",
                url: "anasayfa",
                defaults: new { controller = "Site", action = "Anasayfa" }
            );

            int kirilimSayisi = 3;
            string kategoriUrl = "kategori";
            string haberUrl = "haber";

            for (int i = 0; i < kirilimSayisi; i++)
            {

                kategoriUrl += "/{kategori" + i + "}";





                routes.MapRoute(
                     name: "Kategori" + i,
                     url: kategoriUrl,
                     defaults: new { controller = "HaberKategori", action = "Anasayf" }
                 );


                haberUrl += "/{kategori" + i + "}";





                routes.MapRoute(
                     name: "Haber" + i,
                     url: haberUrl + "/{haber}",
                     defaults: new { controller = "Haber", action = "Detay" }


                     );


            }

            routes.MapRoute(
                    name: "ArsivTarih",
                    url: "arsiv/{tarih}",
                    defaults: new { controller = "Site", action = "ArsivTarih" },
                    constraints: new { tarih = @"\d{4}-\d{2}-\d{2}" }

                    );

            routes.MapRoute(
                   name: "HaberGoster",
                   url: "haber/Goster",
                   defaults: new { controller = "Haber", action = "Goster" },
                   constraints: new { metod = new HttpMethodConstraint("GET") }

                   );

            routes.MapRoute(
                 name: "HaberKaydet",
                 url: "haber/Kaydet",
                 defaults: new { controller = "Haber", action = "Kaydet" },
                 constraints: new { metod = new HttpMethodConstraint("POST", "PUT") }

                 );

            routes.MapRoute(
               name: "Kategori",
               url: "kategoriler/{kategori}",
               defaults: new { controller = "HaberKategori", action = "Anasayfa" },
               constraints: new { kategori = new KategoriRouteConstraints() }

               );

        }
    }
}
