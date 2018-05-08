using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class LotController : Controller
    {
        // GET: Lot
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateLot()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLot(Lot entity)
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View();
        }
    }
}