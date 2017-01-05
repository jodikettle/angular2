using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess
{
    public interface ISalesRepository
    {
        List<SiteSalesPerHour> GetCumulativeSalesForAllStores();

        List<SiteSalesPerHour> GetCumulativeSalesForToday(string StoreId);
    }
}
