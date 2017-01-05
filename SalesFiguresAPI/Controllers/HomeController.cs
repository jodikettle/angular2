using DataAccess;
using SalesFiguresAPI.Models;
using SalesFiguresAPI.Services;
using System.Web.Mvc;

namespace SalesFiguresAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICumulativeSalesService _service;

        public HomeController(ICumulativeSalesService service)
        {
            this._service = service;
        }

        public ActionResult Index()
        {
            var model = new HomePageViewModel();
            //var cookieInfo = Request.Cookies["HomeStore"];
            //if (cookieInfo != null)
            //{
            //    model.cookieInfo = cookieInfo.Value;
            //}
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
            model.CumulativeSalesForToday = _service.GetCumulativeSalesForToday(id.ToString());

            //return Json(returnData, JsonRequestBehavior.AllowGet);
            return View(model);
        }
    }
}
