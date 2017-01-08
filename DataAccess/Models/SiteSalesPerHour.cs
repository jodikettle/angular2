
namespace DataAccess.Models
{
    public class SiteSalesPerHour
    {
        public string SiteName { get; set; }
        public string SiteId { get; set; }
        public int Hour { get; set; }
        public double TodaysValue { get; set; }
        public double LastYearsValue { get; set; }
    }
}
