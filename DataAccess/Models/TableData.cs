using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TableData
    {
        public string StoreName { get; set; }
        public double TodaySalesTotal { get; set; }
        public double YesterdaySalesTotal { get; set; }
        public double LastYearSalesTotal { get; set; }
        public double CurrentWeekSalesTotal { get; set; }
        public double WeekLastYearsSalesTotal { get; set; }
    }
}
