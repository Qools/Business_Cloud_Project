using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Classes
{
    public class Order
    {
        public Order()
        {
            OrderId = Guid.NewGuid().ToString();
        }
        [Key]
        [HiddenInput(DisplayValue = false)]
        public string OrderId { get; set; }
        public Vendor Vendor { get; set; }

        public Customer Customer { get; set; }
        [Display(Name = "Product Id")]
        [Required(ErrorMessage = "Please Enter Product Id")]
        public int ProductId { get; set; }
        [Display(Name = "List Of Color")]
        [Required(ErrorMessage = "Please Enter List Of Color")]
        public Color ListOfColor { get; set; }

    }
}