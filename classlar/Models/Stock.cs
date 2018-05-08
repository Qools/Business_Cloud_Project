namespace classlar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductID { get; set; }

        public int LotID { get; set; }

        public int CountOfProduct { get; set; }

        public virtual Lot Lot { get; set; }

        public virtual Product Product { get; set; }
    }
}
