namespace classlar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Orders = new HashSet<Order>();
            Stocks = new HashSet<Stock>();
        }

        [StringLength(50)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductType { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        public int LotID { get; set; }

        public int BuyPrice { get; set; }

        public int? VendorID { get; set; }

        public virtual Lot Lot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual Vendor Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
