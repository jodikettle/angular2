using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesFiguresAPI.Models
{
    public class StorePageViewModel
    {
        public string StoreId { get; set; }

        public StoreName StoreName { get; set; }

        public CumulativeSaleByStore CumulativeSalesForToday { get; set; }
    }
}