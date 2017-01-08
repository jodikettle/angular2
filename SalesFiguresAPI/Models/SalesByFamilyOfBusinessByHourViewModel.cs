using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class SalesByFamilyOfBusinessByHourViewModel
    {
        public int Hour { get; set; }

        public List<SalesByFamilyOfBusinessViewModel> Data { get; set; }
    }
}