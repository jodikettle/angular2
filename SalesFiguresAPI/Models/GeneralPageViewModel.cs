using DataAccess.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class GeneralPageViewModel
    {
        public List<SiteTotalSales> TodaysTotalSales { get; set; }

        public int LastYearsSales { get; set; }
    }
}