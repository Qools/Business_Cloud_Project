using classlar.Classes;
using classlar.Models;
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
            var customer = new Model1().Customers;
            return View(customer);
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
        public JsonResult Chart()
        {
            var loans = DbFactory.DbConnection.Customers.Select(x => x.Loan).ToArray();
            var totalMoney = DbFactory.DbConnection.Customers.Select(x => x.TotalAmountOfMoney).ToArray();
         
            var totalNumber = DbFactory.DbConnection.Customers.Select(x => x.TotalAmountOfNumber).ToArray();


            var data = new { loans, totalMoney, totalNumber };
            return Json(data, JsonRequestBehavior.AllowGet);

        }
    }
}