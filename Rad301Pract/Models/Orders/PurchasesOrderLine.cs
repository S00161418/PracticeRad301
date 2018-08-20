using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301Pract.Models.Orders
{
    public class PurchasesOrderLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [ForeignKey("Purchases Order ID")]
        public int poid { get; set; }

        [ForeignKey("Product ID")]
        public int productid{ get; set; }

        [Display(Name = "Quantity Ordered")]
        public int qtyordered { get; set; }

    }
}