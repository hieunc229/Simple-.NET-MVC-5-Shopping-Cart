using AutoMapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectricsOnlineWebApp.Areas.Admin.Controllers
{
    public class StockController : BaseController
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chart()
        {
            var units = new List<int>();
            var rol = new List<int>();
            var labels = new List<string>();
            foreach (var i in _ctx.Products)
            {
                units.Add(i.UnitsInStock);
                rol.Add(i.ROL);
                labels.Add(i.PName);
            }
            List<object> data = new List<object> { new {
                label = "Units in Stock",
                backgroundColor = "rgba(255, 99, 132, 0.6)",
                data = units
            }, new {
                label = "Re-Order-Level",
                backgroundColor = "rgba(153, 102, 255, 0.6)",
                data = rol
            }, labels};

            var result = Json(data.ToArray(), JsonRequestBehavior.AllowGet);
            return result;
        }

        private string _randomColor()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color c = Color.FromKnownColor(randomColorName);
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}
