namespace classlar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vendor")]
    public partial class Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorID { get; set; }

        [Required]
        [StringLength(50)]
        public string VendorName { get; set; }

        [Required]
        [StringLength(50)]
        public string VendorAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string VendorEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
