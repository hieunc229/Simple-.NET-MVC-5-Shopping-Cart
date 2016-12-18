using AutoMapper;
using ElectricsOnlineWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectricsOnlineWebApp.Areas.Admin.Controllers
{
    public class OrderController : BaseController
    {
        public OrderController()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Order, OrderModel>();
            });
        }

        // GET: Admin/Order
        public ActionResult Index()
        {
            var orders = _ctx.Orders;
            var model = Mapper.Map<IEnumerable<Order>, IEnumerable<OrderModel>>(orders);
            return View(model);
        }

        // GET: Admin/Order/Details/5
        public ActionResult Details(int id)
        {
            var order = _ctx.Orders.FirstOrDefault(o => o.OrderID == id);
            var model = Mapper.Map<OrderModel>(order);
            return View(model);
        }
    }
}
