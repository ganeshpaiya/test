using MVCcurdAngular.EF;
using MVCcurdAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCcurdAngular.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Getemp()
        {
            Dal _Dal = new Dal();
            List<emp> Listofemp = _Dal.emps.ToList();
            return Json(Listofemp,JsonRequestBehavior.AllowGet);
        }
            
    }
}