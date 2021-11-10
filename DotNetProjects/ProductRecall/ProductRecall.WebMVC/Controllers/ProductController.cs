using Microsoft.AspNet.Identity;
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
    public class ProductController : Controller
    {
        private ApplicationDbContext _ctx = new ApplicationDbContext();

        // GET: Product
        public ActionResult Index()
        {
            //********************************
            //make a new instant of a class
            var service = new ProductService();

            var model = service.GetProducts();

            return View(model);
        }

        //GET: Product/Create
        public ActionResult Create()
        {
            //Create drop list of manufacturer
            ViewBag.ManufacturerItems = _ctx.Manufacturers.Select(manufacturer => new SelectListItem
            {
                Text = manufacturer.ManufacturerName,
                Value = manufacturer.ManufacturerId.ToString()
            }).ToArray();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = new ProductService();

            if (service.CreateProduct(model))
            {
                TempData["SaveResult"] = "The product was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Product could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = new ProductService();
            var model = svc.GetProductById(id);

            return View(model);
        }


        public ActionResult Edit(int id)
        {
            var service = new ProductService();
            var detail = service.GetProductById(id);

            // Get Manufacturer List
            var ManufacturerList = _ctx.Manufacturers.Select(manufacturer => new SelectListItem
            {
                Text = manufacturer.ManufacturerName,
                Value = manufacturer.ManufacturerId.ToString()
            }).ToArray();

            ViewBag.ManufacturerItems = ManufacturerList;

            // Get Product Detail
            var model =
                new ProductEdit
                {
                    ProductId = detail.ProductId,
                    ProductName = detail.ProductName,
                    Price = detail.Price,
                    ManufacturerId = detail.ManufacturerId
                };



            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.ProductId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new ProductService();

            if (service.UpdateProduct(model))
            {
                TempData["SaveResult"] = "The product was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The product could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new ProductService();
            var model = svc.GetProductById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = new ProductService();

            service.DeleteProduct(id);

            TempData["SaveResult"] = "The product was deleted";

            return RedirectToAction("Index");
        }




    }

}