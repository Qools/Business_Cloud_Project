using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateStock()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStock(Stock entity)
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}