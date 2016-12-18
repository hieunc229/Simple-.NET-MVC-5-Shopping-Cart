using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElectricsOnlineWebApp.Areas.Admin.Models
{
    public class Product : Base
    {
        public int PID { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name")]
        public string PName { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Units In Stock is required")]
        [Display(Name = "Units In Stock")]
        public int UnitsInStock { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public int SID { get; set; }
        public int ROL { get; set; }
        
        public Supplier Supplier {
            get {
                return _ctx.Suppliers.FirstOrDefault(s => s.SID == this.SID);
            }
        }
    }
}