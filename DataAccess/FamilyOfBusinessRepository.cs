using DataAccess.Models;
using System;
using System.Collections.Generic;


namespace DataAccess
{
    public class FamilyOfBusinessRepository : IFamilyOfBusinessRepository
    {
        public List<FamilyOfBusinessPercentage> GetSalesByFamilyOfBusiness()
        {
            var list = new List<FamilyOfBusinessPercentage>();
            list.Add(new FamilyOfBusinessPercentage()
            {
                Category = "Accessories Own Bought",
                Percentage = 25
            });
            list.Add(new FamilyOfBusinessPercentage()
            {
                Category = "Perfumery Own Bought",
                Percentage = 15
            });
            list.Add(new FamilyOfBusinessPercentage()
            {
                Category = "Menswear Own Bought",
                Percentage = 60
            });

            return list;
        }

        public bool GetSalesByFamilyOfBusinessPerHour()
        {
            return false;
        }
    }
}
