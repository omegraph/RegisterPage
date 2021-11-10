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
    public class DashboardController : Controller
    {
        private ApplicationDbContext _ctx = new ApplicationDbContext();
        // GET: Dashboard
        public ActionResult Index()
        {
            var dashboardModel = new Dashboard();

            // List of today's announcements
            var obj1 = new AnnouncementService();
            var todaysAnnouncements = obj1.GetAnnouncements().Where(x => Convert.ToDateTime(x.AnnouncementDate) == DateTime.Today).ToList();


            // List of products on recall
            var obj2 = new RecallService();
            var recallProducts = obj2.GetRecalls();

            //1. Binding data with models
            dashboardModel.AnnouncementListItem = todaysAnnouncements;
            dashboardModel.RecallListItem = recallProducts.ToList();

            //2. by using ajax request
            return View(dashboardModel);
        }
        public JsonResult GetTodaysAnnouncements()
        {
            var service = new AnnouncementService();
            var model = service.GetAnnouncements().Where(x => Convert.ToDateTime(x.AnnouncementDate) == DateTime.Today).ToList();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProductsOnRecall()
        {
            JsonResult result = new JsonResult();

            var service = new RecallService();
            var model = service.GetRecalls();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

    }
}