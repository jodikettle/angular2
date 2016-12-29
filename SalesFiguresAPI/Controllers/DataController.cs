using DataAccess.Models;
using SalesFiguresAPI.Models;
using SalesFiguresAPI.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SalesFiguresAPI.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            //Inject 
            var service = new TodaysSalesService();
            var model = new GeneralPageViewModel();
            model.TodaysTotalSales = new List<SiteTotalSales>();//service.GetTodaySales();
            return View(model);
        }

        [HttpGet]
        public JsonResult GetTodaysSalesFigures()
        {
            var service = new TodaysSalesService();
            var returnData = service.GetTodaySales();
            return Json(returnData, JsonRequestBehavior.AllowGet);
        }
    }
}