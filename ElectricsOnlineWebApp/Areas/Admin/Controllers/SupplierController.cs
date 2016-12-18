using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectricsOnlineWebApp.Areas.Admin.Controllers
{
    public class SupplierController : BaseController
    {
        public SupplierController()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Supplier,Supplier>();
            }); 
        }

        // GET: Admin/Supplier
        public ActionResult Index()
        {
            var suppliers = _ctx.Suppliers.ToList();
            var model = Mapper.Map<List<Supplier>, IEnumerable<Supplier>>(suppliers);
            return View(model);
        }

        private Supplier _get(int id)
        {
            var supplier = _ctx.Suppliers.FirstOrDefault(s => s.SID == id);
            return supplier;
        }

        // GET: Admin/Supplier/Details/5
        public ActionResult Details(int id)
        {
            var model = _get(id);
            return View(model);
        }

        // GET: Admin/Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Supplier/Create
        [HttpPost]
        public ActionResult Create(Supplier supplier)
        {
            try
            {
                // TODO: Add insert logic here
                _ctx.Suppliers.Add(supplier);
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(supplier);
            }
        }

        // GET: Admin/Supplier/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _get(id);
            return View(model);
        }

        // POST: Admin/Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Supplier model)
        {
            try
            {
                // TODO: Add update logic here
                Supplier supplier = _ctx.Suppliers.FirstOrDefault(s => s.SID == id);
                supplier.SName = model.SName;
                supplier.Address1 = model.Address1;
                supplier.Address2 = model.Address2;
                supplier.Email = model.Email;
                supplier.Phone = model.Phone;
                supplier.Postcode = model.Postcode;
                supplier.State = model.State;
                supplier.Suburb = model.Suburb;
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Admin/Supplier/Delete/5
        public ActionResult Delete(int id)
        {
            var supplier = _get(id);
            _ctx.Suppliers.Remove(supplier);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
