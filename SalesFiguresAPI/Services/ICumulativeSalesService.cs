using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public interface ICumulativeSalesService
    {
        List<CumulativeSaleByStore> GetAllStoresCumulativeSalesForToday();

        CumulativeSaleByStore GetCumulativeSalesForToday(string StoreId);
    }
}
