using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public class FakeSalesRepository : ISalesRepository
    {
        public List<SiteSalesPerHour> GetCumulativeSalesForAllStores()
        {
            var list = new List<SiteSalesPerHour>();
            list.Add(new SiteSalesPerHour()
            {
                SiteId = "001",
                Hour = 09,
                TodaysValue = 80,
                LastYearsValue = 90
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "001",
                Hour = 10,
                TodaysValue = 150,
                LastYearsValue = 160
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 9,
                TodaysValue = 10,
                LastYearsValue = 15
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 10,
                TodaysValue = 20,
                LastYearsValue = 35
            });
            return list;
        }

        public SiteSalesPerHour GetCumulativeSalesForToday(string StoreId)
        {
            throw new NotImplementedException();
        }
    }
}
