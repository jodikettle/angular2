namespace SalesFiguresAPI.Models
{
    public class TodaysSalesByHourViewModel
    {
        public int Hour { get; set; }
        public double TodaysValue { get; set; }
        public double LastYearsValue { get; set; }
    }
}