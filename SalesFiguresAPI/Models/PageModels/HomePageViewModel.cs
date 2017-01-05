using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class HomePageViewModel
    {
        public List<CumulativeSaleByStore> TodayCumulativeFigures { get; set; }

        public StoreName StoreName { get; set; }

        public string cookieInfo { get; set; }
    }
}