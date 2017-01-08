using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public interface ICumulativeSalesService
    {
   
        CumulativeSaleByStoreViewModel GetCumulativeSalesForToday(string StoreId);
    }
}
