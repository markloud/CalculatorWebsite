using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorSite.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Add(decimal num1, decimal num2)
        {
            return Json(num1 + num2, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Subtract(decimal num1, decimal num2)
        {
            return Json(num1 - num2, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Multiply(decimal num1, decimal num2)
        {
            return Json(num1 * num2, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Divide(decimal num1, decimal num2)
        {
            return Json(num1 != 0 ? num1 / num2 : 0, JsonRequestBehavior.AllowGet);
        }
    }
}