using classlar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomer(Customer entity)
        {
            DbFactory.DbConnection.Customers.Add(entity);
            DbFactory.DbConnection.SaveChanges();
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}