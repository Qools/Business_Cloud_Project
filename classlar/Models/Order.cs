namespace classlar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public int VendorID { get; set; }

        public int CustomerCode { get; set; }

        public float SellPrice { get; set; }

        public int ProductCound { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
