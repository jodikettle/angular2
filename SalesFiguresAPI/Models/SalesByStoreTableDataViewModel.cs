using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class SalesByStoreTableDataViewModel
    {
        List<SalesTableInformation> tableInfo = new List<SalesTableInformation>();
    }

    internal class SalesTableInformation
    {
        public string StoreName { get; set; }
        public double TodaySalesTotal { get; set; }
        public double YesterdaySalesTotal { get; set; }
        public double LastYearSalesTotal { get; set; }
        public double CurrentWeekSalesTotal { get; set; }
        public double WeekLastYearsSalesTotal { get; set; }

    }
}