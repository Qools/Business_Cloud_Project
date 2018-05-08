using classlar.Classes;
using classlar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            var order = new Model1().Orders;
            return View(order);
        }
        public ActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOrder(Order entity)
        {
            entity.Customer = DbFactory.DbConnection.Customers.FirstOrDefault(x => x.CustomerCode == entity.CustomerCode);
            entity.Product = DbFactory.DbConnection.Products.FirstOrDefault(x => x.ProductID == entity.ProductID);
            entity.Vendor = DbFactory.DbConnection.Vendors.FirstOrDefault(x => x.VendorID == entity.VendorID);
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
        public JsonResult GetVendors()
        {
            var data = DbFactory.DbConnection.Vendors.Select(x => x.VendorName).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCustomer()
        {
            var data = DbFactory.DbConnection.Customers.Select(x => x.CustomerName).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetProduct()
        {
            var data = DbFactory.DbConnection.Products.Select(x => x.ProductID).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetVendorsProduct(int vendorId)
        {
            var products = DbFactory.DbConnection.Vendors.FirstOrDefault(x => x.VendorID == vendorId).Products;
            List<string> data = new List<string>();
            foreach (var item in products)
            {
                data.Add(item.ProductID.ToString());
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}