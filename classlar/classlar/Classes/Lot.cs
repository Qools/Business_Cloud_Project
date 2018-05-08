using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classlar.Classes
{
    public enum LotType
    {
        XXS,XS,S,M,L,XL,XXL
    }
    public class Lot
    {
        public Lot()
        {
            LotId = Guid.NewGuid().ToString();
        }
        [Key]
        [HiddenInput(DisplayValue = false)]
        public string LotId { get; set; }
        [Display(Name = "Lot Type")]
        [Required(ErrorMessage = "Please Enter Lot Type")]
        public LotType LotType { get; set; }
        [Display(Name = "Lot Quantity")]
        [Required(ErrorMessage = "Please Enter Lot Quantity")]
        public int LotQuantity { get; set; }
    
    }
}