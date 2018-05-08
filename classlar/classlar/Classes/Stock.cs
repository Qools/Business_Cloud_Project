using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Classes
{
    public class Stock
    {
        public Stock()
        {
            StockId = Guid.NewGuid().ToString();
        }
        [Key]
        [HiddenInput(DisplayValue = false)]
        public string StockId { get; set; }
        [Display(Name = "Product")]
        [Required(ErrorMessage = "Please Enter Product")]
        public Product Product { get; set; }
        public Lot Lot { get; set; }
        [Display(Name = "Count Of Product")]
        [Required(ErrorMessage = "Please Enter Count Of Product")]
        public int CountOfProduct { get; set; }
    }
}