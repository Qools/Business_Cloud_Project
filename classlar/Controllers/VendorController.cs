using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using classlar.Models;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class VendorController : Controller
    {
        // GET: Vendor
        public ActionResult Index()
        {
            var vendor = new Model1().Vendors;
            return View(vendor);
        }
        public ActionResult CreateVendor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateVendor(Vendor entity)
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}