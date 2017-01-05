using System;
using System.Collections.Generic;
using DataAccess.Models;

namespace DataAccess
{
    public class SalesRepository : ISalesRepository
    {
        public List<SiteSalesPerHour> GetCumulativeSalesForAllStores()
        {
            throw new NotImplementedException();
        }

        public List<SiteSalesPerHour> GetCumulativeSalesForToday(string StoreId)
        {
            throw new NotImplementedException();
        }
    }
}
