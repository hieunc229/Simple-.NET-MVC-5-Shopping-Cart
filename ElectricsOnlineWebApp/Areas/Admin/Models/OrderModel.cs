using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricsOnlineWebApp.Models
{
    public class OrderModel : ElectricsOnlineWebApp.Order
    {

        public decimal TotalPayment
        {
            get
            {
                return this.Order_Products.Sum(p => p.TotalSale);
            }
        }
    }
}