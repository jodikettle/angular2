using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesFiguresAPI.Models
{
    public class CumulativeSalesData
    {
        public int Hour { get; set; }
        public double TodaysValue { get; set; }
        public double LastYearsValue { get; set; }
    }
}