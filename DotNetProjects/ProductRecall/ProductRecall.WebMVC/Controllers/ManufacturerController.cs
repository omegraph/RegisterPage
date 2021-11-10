using ProductRecall.Models;
using ProductRecall.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductRecall.WebMVC.Controllers
{
    [Authorize]
    public class ManufacturerController : Controller
    {
        // GET: Manufacturer
        public ActionResult Index()
        {
            var service = new ManufacturerService();
            var model = service.GetManufacturers();
            return View(model);
        }

        // GET: Manufacturer/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ManufacturerCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = new ManufacturerService();

            if (service.CreateManufacturer(model))
            {
                TempData["SaveResult"] = "The manufacturer was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Manufacturer could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = new ManufacturerService();
            var model = svc.GetManufacturerById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = new ManufacturerService();
            var detail = service.GetManufacturerById(id);
            var model =
                new ManufacturerEdit
                {
                    ManufacturerId = detail.ManufacturerId,
                    ManufacturerName = detail.ManufacturerName,
                    City = detail.City,
                    State = detail.State,
                    ZipCode = detail.ZipCode,
                    Address = detail.Address
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ManufacturerEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.ManufacturerId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new ManufacturerService();

            if (service.UpdateManufacturer(model))
            {
                TempData["SaveResult"] = "The manufacturer was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The manufacturer could not be updated.");
            return View(model);
        }


        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new ManufacturerService();
            var model = svc.GetManufacturerById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = new ManufacturerService();

            service.DeleteManufacturer(id);

            TempData["SaveResult"] = "The manufacturer was deleted";

            return RedirectToAction("Index");
        }

    }
}