namespace SalesFiguresAPI.Models
{
    public class SalesByHourByStore
    {
        public int Hour { get; set; }
        public double TodaysValue { get; set; }
        public double LastYearsValue { get; set; }
    }
}