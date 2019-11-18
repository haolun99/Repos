using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarBrandClientSide.CarBrandServiceReference;

namespace CarBrandClientSide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BrandServiceClient client = new BrandServiceClient();
            var response = client.GetCarBrands();
            string brandNames = "";
            foreach(var item in response)
            {
                brandNames += item.BrandName + " ";
            }
            return View((object)brandNames);
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