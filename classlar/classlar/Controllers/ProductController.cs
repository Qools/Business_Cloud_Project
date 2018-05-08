using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Product entity)
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}