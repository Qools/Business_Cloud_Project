using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using classlar.Models;


namespace classlar.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var product = new Model1().Products;
            return View(product);
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