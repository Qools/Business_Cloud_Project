using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class VendorController : Controller
    {
        // GET: Vendor
        public ActionResult Index()
        {
            return View();
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