using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess
{
    public interface ITodaysSalesRepository
    {
        TotalSalesFigures GetTodaysSales();

        List<TableData> GetAllStoresThisWeekAndLast();

        List<SiteSalesPerHour> GetTodaysSaleByHour();
    }
}
