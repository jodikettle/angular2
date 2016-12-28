using System.Collections.Generic;

namespace DataAccess.Models
{
    public class SiteSalesPerHour
    {
        public string SiteId { get; set; }
        public int Hour { get; set; }
        public double TodaysValue { get; set; }
        public double LastYearsValue { get; set; }
    }
}
