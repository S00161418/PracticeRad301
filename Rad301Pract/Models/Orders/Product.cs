using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301Pract.Models.Orders
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Quantity In Stock")]
        public int qtyinstock { get; set; }

        [Display(Name = "Unit Price")]
        public int unitprice { get; set; }

    }
}