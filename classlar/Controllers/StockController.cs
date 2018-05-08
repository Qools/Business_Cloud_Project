using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using classlar.Models;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            var stock = new Model1().Stocks;
            return View(stock);
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
        public JsonResult GetChartData()
        {
            var data = DbFactory.DbConnection.Stocks.Select(x => x.CountOfProduct).ToList();
            data.Add(1);
            data.AddRange(new int[]{ 1, 2, 3, 4 });
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}