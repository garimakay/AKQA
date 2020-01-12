using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(EmpDetails model)
        {
            if (!string.IsNullOrWhiteSpace(model.Name))
            {
                ViewBag.WordsNo = model.Name +" "+ NumberToWords.ConvertAmount(model.Number)?.ToUpper();
            }
            else
            {
                ViewBag.WordsNo = "";
            }
            return View(model);
        }

    }
}