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
    public class AnnouncementController : Controller
    {
        private ApplicationDbContext _ctx = new ApplicationDbContext();

        // GET: Announcement
        public ActionResult Index()
        {
            //make a new instant of a class
            var service = new AnnouncementService();
            var model = service.GetAnnouncements();
            return View(model);
        }

        //GET: Announcement/Create
        public ActionResult Create()
        {
            //Create drop list of recall
            ViewBag.RecallItems = _ctx.Recalls.Select(recall => new SelectListItem
            {
                Text = recall.RecallTitle,
                Value = recall.RecallId.ToString()
            }).ToArray();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnnouncementCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = new AnnouncementService();

            model.AnnouncementDate = DateTime.Today;
            if (service.CreateAnnouncement(model))
            {
                TempData["SaveResult"] = "The announcement was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Announcement could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = new AnnouncementService();
            var model = svc.GetAnnouncementById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = new AnnouncementService();
            var detail = service.GetAnnouncementById(id);
            var model =
                new AnnouncementEdit
                {
                    AnnouncementId = detail.AnnouncementId,
                    AnnouncementTitle = detail.AnnouncementTitle,
                    AnnouncementDate = detail.AnnouncementDate,
                    RecallTitle = detail.RecallTitle
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AnnouncementEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.AnnouncementId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new AnnouncementService();

            if (service.UpdateAnnouncement(model))
            {
                TempData["SaveResult"] = "The announcement was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The announcement could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new AnnouncementService();
            var model = svc.GetAnnouncementById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = new AnnouncementService();

            service.DeleteAnnouncement(id);

            TempData["SaveResult"] = "The announcement was deleted";

            return RedirectToAction("Index");
        }
    }
}