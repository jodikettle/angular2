using System.Collections.Generic;

namespace SalesFiguresAPI.Models
{
    public class CumulativeSaleByStore
    {
        public StoreName StoreName { get; set; }

        public string StoreId { get; set; }

        public List<CumulativeSalesData> Data {get;set;}
    }
}