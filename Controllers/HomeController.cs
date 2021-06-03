using Newtonsoft.Json;
using OrderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OrderAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            IEnumerable<Details> det = null;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44306/api/";
                var json = webClient.DownloadString("Values/" + 10248);
                var list = JsonConvert.DeserializeObject<List<Details>>(json);
                det = list.ToList();
                return View(det);
            }
            ;
        }
    }
}
