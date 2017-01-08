using DataAccess;
using SalesFiguresAPI.Models;
using SalesFiguresAPI.Services;
using System.Web.Mvc;

namespace SalesFiguresAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICumulativeSalesService _service;
        private readonly IOrderDispatchService dispatchService;
        private readonly ITodaysSalesService _totalSales;
        private readonly IFamilyOfBusinessSalesService _familySaleService;

        public HomeController(ICumulativeSalesService service,
            IOrderDispatchService dispatchService,
            ITodaysSalesService _totalSales,
            IFamilyOfBusinessSalesService familySaleServeice)
        {
            this._service = service;
            this.dispatchService = dispatchService;
            this._totalSales = _totalSales;
            this._familySaleService = familySaleServeice;
        }

        public ActionResult Index()
        {
            var model = new HomePageViewModel();
            model.TodaysSalesTotals = _totalSales.GetTodaysSalesTotal();
            model.TableData = _totalSales.GetTableData();
            model.DispatchInfo = dispatchService.GetDispatchInformation();
            model.TodayCumulativeFigures = _service.GetCumulativeSalesForToday("0001");
            model.SalesByFamily = _familySaleService.GetSalesByFamilyOfBusiness();
            model.SalesByFamilyPerHour = _familySaleService.GetSalesByFamilyOfBusinessByHour();
            model.SalesPerHour = _totalSales.GetSalesByHour();
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
            //model.TodaysSalesTotal = _totalSales.GetTodaysSalesTotal(id.ToString());
            model.CumulativeSalesForToday = _service.GetCumulativeSalesForToday(id.ToString());

            //return Json(returnData, JsonRequestBehavior.AllowGet);
            return View(model);
        }
    }
}
