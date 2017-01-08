using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public interface ITodaysSalesService
    {
        TodaySalesViewModel GetTodaysSalesTotal();

        SalesByStoreTableDataViewModel GetTableData();

        List<TodaysSalesByHourViewModel> GetSalesByHour();
    }
}
