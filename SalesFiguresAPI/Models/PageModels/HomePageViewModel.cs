using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class HomePageViewModel
    {
        public double TodaysSalesTotal { get; set; }
        public double LastYearTodaysSalesTotal { get; set; }

        public List<CumulativeSaleByStore> TodayCumulativeFigures { get; set; }

        public SalesByStoreTableDataViewModel TableData { get; set; }

        public TotalSalesByStoreViewModel TotalSalesPerStore { get; set; }

        public SalesByFamilyOfBusinessViewModel SalesByFamily { get; set; }

        public AllStoresThisYearAndLastViewModel AllStoresThisYearAndLast { get; set; }

        public StoreName StoreName { get; set; }

        public string cookieInfo { get; set; }
    }
}