using SalesFiguresAPI.Models;
using SalesFiguresAPI.Services;
using System.Web.Mvc;

namespace SalesFiguresAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomePageViewModel();
            var service = new TodaysSalesService();
            model.TodaysFigures = service.GetTodaySales();
            ViewBag.Title = "Sales Board";
            return View(model);
        }

        public ActionResult Store()
        {
            var model = new StorePageViewModel();
            var service = new TodaysSalesService();
            model.Data = service.GetSalesByHourByStore();
            return View(model);
        }
    }
}
