
using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class SalesByFamilyOfBusinessViewModel
    {
        public List<FamilyOfBusiness> Sales { get; set; }
    }

    public class FamilyOfBusiness
    {
        public string Category { get; set; }
        public double Percentage { get; set; }
    }

}