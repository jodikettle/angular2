using DataAccess;
using SalesFiguresAPI.Models;
using SalesFiguresAPI.Services;
using System.Web.Mvc;

namespace SalesFiguresAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICumulativeSalesService _service;
        private readonly ITodaysSalesService _totalSales;

        public HomeController(ICumulativeSalesService service, ITodaysSalesService _totalSales)
        {
            this._service = service;
            this._totalSales = _totalSales;
        }

        public ActionResult Index()
        {
            var model = new HomePageViewModel();

            model.TodayCumulativeFigures = _service.GetAllStoresCumulativeSalesForToday();
            return View(model);
        }

        public ActionResult Store(int id)
        {
            if (id == 0)
            {
                Response.Redirect("Home/Index");
            }
            var model = new StorePageViewModel();
            model.StoreName = (StoreName)id;
            model.TodaysSalesTotal = _totalSales.GetTodaysSalesTotal(id.ToString());
            model.CumulativeSalesForToday = _service.GetCumulativeSalesForToday(id.ToString());

            //return Json(returnData, JsonRequestBehavior.AllowGet);
            return View(model);
        }
    }
}
