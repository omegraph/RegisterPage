using ProductRecall.Data;
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
    public class RecallController : Controller
    {
        private ApplicationDbContext _ctx = new ApplicationDbContext();
        // GET: Recall
        public ActionResult Index()
        {
            var service = new RecallService();
            var model = service.GetRecalls();
            return View(model);
        }

        //Get: Recall/Create
        public ActionResult Create()
        {
            RecallCreate model = new RecallCreate();

            //Create drop list of product
            ViewBag.ProductItems = _ctx.Products.Select(product => new SelectListItem
            {
                Text = product.ProductName,
                Value = product.ProductId.ToString()
            }).ToArray();

            ViewBag.Manufacturers = _ctx.Manufacturers.Select(manufacturer => new SelectListItem
            {
                Text = manufacturer.ManufacturerName,
                Value = manufacturer.ManufacturerId.ToString()
            }).ToArray();

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecallCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = new RecallService();

            if (service.CreateRecall(model))
            {
                TempData["SaveResult"] = "The product recall was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Product recall could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = new RecallService();
            var model = svc.GetRecallById(id);

            return View(model);
        }

        public JsonResult GetProductsByManufacturereId(int id)
        {
            JsonResult json = new JsonResult();
            var svc = new RecallService();
            var list = svc.GetProductsByManufacturerId(id);

            json.Data = new { data = list, status = "Success" };

            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            var service = new RecallService();
            var detail = service.GetRecallById(id);
            var model =
                new RecallEdit
                {
                    RecallId = detail.RecallId,
                    ManufacturerName = detail.ManufacturerName,
                    ProductName = detail.ProductName,
                    RecallTitle = detail.RecallTitle,
                    RecallDateStart = detail.RecallDateStart,
                    RecallDateEnd = detail.RecallDateEnd
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, RecallEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.RecallId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new RecallService();

            if (service.UpdateRecall(model))
            {
                TempData["SaveResult"] = "The product recall was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The product recall could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new RecallService();
            var model = svc.GetRecallById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = new RecallService();

            service.DeleteRecall(id);

            TempData["SaveResult"] = "The product recall was deleted";

            return RedirectToAction("Index");
        }
    }
}