using AutoMapper;
using System.Linq;
using DataAccess;
using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public class CumulativesSalesService
    {
        private readonly ISalesRepository repository;

        public CumulativesSalesService(ISalesRepository repository)
        {
            this.repository = repository;
        }
        public List<CumulativeSaleByStore> GetAllStoresCumulativeSalesForToday()
        {
            var sales = this.repository.GetCumulativeSalesForAllStores();
            var salesGroupedByStore = sales.GroupBy(x => x.SiteId)
                .Select(grp => new CumulativeSaleByStore() { StoreId = grp.Key, Data = Mapper.Map<List<CumulativeSalesData>>(grp.ToList()) })
                .ToList();
            return salesGroupedByStore;
        }

        public CumulativeSaleByStore GetCumulativeSalesForToday(string StoreId)
        {
            var sales = this.repository.GetCumulativeSalesForToday(StoreId);
            return Mapper.Map<CumulativeSaleByStore>(sales);
        }
    }
}