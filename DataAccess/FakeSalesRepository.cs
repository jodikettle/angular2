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
                SiteId = "001",
                Hour = 11,
                TodaysValue = 180,
                LastYearsValue = 180
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "001",
                Hour = 12,
                TodaysValue = 0,
                LastYearsValue = 200
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "001",
                Hour = 13,
                TodaysValue = 0,
                LastYearsValue = 230
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "001",
                Hour = 14,
                TodaysValue = 0,
                LastYearsValue = 250
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
