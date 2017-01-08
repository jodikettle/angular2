using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class CumulativeSaleByStoreViewModel
    {
        public string StoreName { get; set; }

        public List<CumulativeSalesData> Data { get; set;}
    }
}