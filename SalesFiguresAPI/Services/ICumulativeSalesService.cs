using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public interface ICumulativeSalesService
    {
        List<CumulativeSaleByStore> GetAllStoresCumulativeSalesForToday();

        List<CumulativeSaleByStore> GetCumulativeSalesForToday(string StoreId);
    }
}
