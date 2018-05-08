using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using classlar.Models; 
using System.Web;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class LotController : Controller
    {
        // GET: Lot
        public ActionResult Index()
        {
            var lot = new Model1().Lots;
            return View(lot);
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