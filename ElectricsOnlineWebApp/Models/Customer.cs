using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectricsOnlineWebApp.Models
{
    public class Customer
    {
        public int CID { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "LastNme is required")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone must be 10 digits")]
        public string Phone { get; set; }

        [Display(Name = "Address1")]
        [Required(ErrorMessage = "Address is required")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Suburb is required")]
        public string Suburb { get; set; }

        [Required(ErrorMessage = "Postcode is required")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Invalid postcode")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Card type is required")]
        [Display(Name = "Card Type")]
        public string Ctype { get; set; }

        [Required(ErrorMessage = "Card number is required")]
        [Display(Name = "Card Number")]
        [StringLength(16, ErrorMessage = "Invalid card numbers entered", MinimumLength = 15)]
        public string CardNo { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Card expiration is required")]
        [Display(Name = "Expiration")]
        public DateTime ExpDate { get; set; }

        [Display(Name = "State")]
        public IEnumerable<SelectListItem> States { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}