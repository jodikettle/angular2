using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class HomePageViewModel
    {
        public StoreName SelectedStore { get; set; }

        public List<SiteTotalFigures> TodaysFigures { get; set; }
    }
}