using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricsOnlineWebApp
{
    public partial class Product
    {
        private ElectricsOnlineEntities _ctx = new ElectricsOnlineEntities();
        public List<Product> All
        {
            get
            {
                return _ctx.Products.ToList<Product>();

            }
        }
    }
}