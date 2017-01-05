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
                TodaysValue = 0,
                LastYearsValue = 0
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

        public List<SiteSalesPerHour> GetCumulativeSalesForToday(string StoreId)
        {
            var list = new List<SiteSalesPerHour>();

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 9,
                TodaysValue = 0,
                LastYearsValue = 0
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 10,
                TodaysValue = 20,
                LastYearsValue = 35
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 11,
                TodaysValue = 50,
                LastYearsValue = 75
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 12,
                TodaysValue = 80,
                LastYearsValue = 95
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 13,
                TodaysValue = 90,
                LastYearsValue = 125
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 14,
                TodaysValue = 0,
                LastYearsValue = 105
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 15,
                TodaysValue = 0,
                LastYearsValue = 145
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 16,
                TodaysValue = 0,
                LastYearsValue = 155
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 17,
                TodaysValue = 0,
                LastYearsValue = 165
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 18,
                TodaysValue = 0,
                LastYearsValue = 180
            });

            list.Add(new SiteSalesPerHour()
            {
                SiteId = "003",
                Hour = 19,
                TodaysValue = 0,
                LastYearsValue = 200
            });

            return list;
        }
    }
}
