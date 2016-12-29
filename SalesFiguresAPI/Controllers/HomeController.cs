using DataAccess;
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
            var service = new CumulativesSalesService(new FakeSalesRepository());
            model.TodayCumulativeFigures = service.GetAllStoresCumulativeSalesForToday();
            return View(model);
        }

        public ActionResult Store(string storeId)
        {
            var model = new StorePageViewModel();
            var service = new CumulativesSalesService(new SalesRepository());
            //model.Data = service.GetCumulativeSalesForToday(storeId);
            return View(model);
        }
    }
}
