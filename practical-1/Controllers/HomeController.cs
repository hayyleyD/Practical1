using Newtonsoft.Json;
using practical_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practical_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<HeroesModel> heroes = GetHeroes();
            return View(heroes);
        }

        private List<HeroesModel> GetHeroes()
        {
            var filePath = Server.MapPath("~/files/data.json");

            using(StreamReader streamReader = new StreamReader(filePath))
            {
                string json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<HeroesModel>>(json);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}