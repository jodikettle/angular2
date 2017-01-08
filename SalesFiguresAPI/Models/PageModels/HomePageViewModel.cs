using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class HomePageViewModel
    {
        public TodaySalesViewModel TodaysSalesTotals { get; set; }
         
        public SalesByStoreTableDataViewModel TableData { get; set; }

        public DispatchInfoViewModel DispatchInfo { get; set; }

        public CumulativeSaleByStoreViewModel TodayCumulativeFigures { get; set; }

        public SalesByFamilyOfBusinessViewModel SalesByFamily { get; set; }

        public SalesByFamilyOfBusinessByHourViewModel SalesByFamilyPerHour { get; set; }
    
        public List<TodaysSalesByHourViewModel> SalesPerHour { get; set; }

        public StoreName StoreName { get; set; }

        public string cookieInfo { get; set; }
    }
}