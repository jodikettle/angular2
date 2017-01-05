using AutoMapper;
using System.Linq;
using DataAccess;
using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public class CumulativeSalesService : ICumulativeSalesService
    {
        private readonly ISalesRepository repository;

        public CumulativeSalesService(ISalesRepository repository)
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

        public List<CumulativeSaleByStore> GetCumulativeSalesForToday(string StoreId)
        {
            var sales = this.repository.GetCumulativeSalesForToday(StoreId);
            return Mapper.Map<List<CumulativeSaleByStore>>(sales);
        }
    }
}