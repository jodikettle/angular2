using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public class FakeTodaysSalesRepository : ITodaysSalesRepository
    {
        public List<TableData> GetAllStoresThisWeekAndLast()
        {
            var list = new List<TableData>();

            list.Add(new TableData()
            {
                StoreName = "KNIGHTSBRIDGE",
                TodaySalesTotal = 29,
                CurrentWeekSalesTotal = 393993,
                LastYearSalesTotal = 382983,
                WeekLastYearsSalesTotal = 378222,
                YesterdaySalesTotal = 38783
            
            });
            list.Add(new TableData()
            {
                StoreName = "LEEDS",
                TodaySalesTotal = 29,
                CurrentWeekSalesTotal = 393993,
                LastYearSalesTotal = 382983,
                WeekLastYearsSalesTotal = 378222,
                YesterdaySalesTotal = 38783
            });
            list.Add(new TableData()
            {
                StoreName = "ONLINE",
                TodaySalesTotal = 29,
                CurrentWeekSalesTotal = 393993,
                LastYearSalesTotal = 382983,
                WeekLastYearsSalesTotal = 378222,
                YesterdaySalesTotal = 38783
            });
            list.Add(new TableData()
            {
                StoreName = "LIVERPOOL",
                TodaySalesTotal = 29,
                CurrentWeekSalesTotal = 393993,
                LastYearSalesTotal = 382983,
                WeekLastYearsSalesTotal = 378222,
                YesterdaySalesTotal = 38783
            });
            list.Add(new TableData()
            {
                StoreName = "DUBLIN",
                TodaySalesTotal = 29,
                CurrentWeekSalesTotal = 393993,
                LastYearSalesTotal = 382983,
                WeekLastYearsSalesTotal = 378222,
                YesterdaySalesTotal = 38783
            });

            return list;
        }

        public List<SiteSalesPerHour> GetTodaysSaleByHour()
        {
            var list = new List<SiteSalesPerHour>();

            list.Add(new SiteSalesPerHour()
            {
                Hour = 9,
                LastYearsValue = 23,
                TodaysValue = 87
            });
            list.Add(new SiteSalesPerHour()
            {
                Hour = 10,
                LastYearsValue = 64,
                TodaysValue = 66
            });
            list.Add(new SiteSalesPerHour()
            {
                Hour = 11,
                LastYearsValue = 23,
                TodaysValue = 87
            });
            list.Add(new SiteSalesPerHour()
            {
                Hour = 12,
                LastYearsValue = 64,
                TodaysValue = 66
            });
            list.Add(new SiteSalesPerHour()
            {
                Hour = 13,
                LastYearsValue = 23,
                TodaysValue = 87
            });
            list.Add(new SiteSalesPerHour()
            {
                Hour = 14,
                LastYearsValue = 56,
                TodaysValue = 66
            });

            return list;
        }

        public TotalSalesFigures GetTodaysSales()
        {
            return new TotalSalesFigures()
            {
                TodaysCurrentTotal = 292662,
                LastYearsTotal = 1200489
            };
        }
    }
}
