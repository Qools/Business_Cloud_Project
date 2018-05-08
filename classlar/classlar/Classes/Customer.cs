using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Classes
{
    public class Customer
    {
        public Customer()
        {
            CustomerCode = Guid.NewGuid().ToString();
        }
        [Key]
        [HiddenInput(DisplayValue = false)]
        public string CustomerCode { get; set; }
        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Please Enter Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please Enter Country")]
        public string Country { get; set; }
        [Display(Name = "Customer Phone")]
        [Required(ErrorMessage = "Please Enter Customer Phone")]
        public int CustomerPhone { get; set; }
        [Display(Name = " Cargo Name Code")]
        [Required(ErrorMessage = "Please Enter Cargo Name Code")]
        public int CargoNameCode { get; set; }
        [Display(Name = "Loan")]
        [Required(ErrorMessage = "Please Enter Loan")]
        public double Loan { get; set; }
        [Display(Name = "Total Amount Of Money")]
        [Required(ErrorMessage = "Please Enter Total Amount Of Money")]
        public double TotalAmountOfMoney { get; set; }
        [Display(Name = "Total Amount Of Number")]
        [Required(ErrorMessage = "Please Enter Total Amount Of Number")]
        public double TotalAmountOfNumber { get; set; }
    }
}