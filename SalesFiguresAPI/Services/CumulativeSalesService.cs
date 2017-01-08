using AutoMapper;
using System.Linq;
using DataAccess;
using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public class CumulativeSalesService : ICumulativeSalesService
    {
        private readonly ICumulativeSalesRepository repository;

        public CumulativeSalesService(ICumulativeSalesRepository repository)
        {
            this.repository = repository;
        }

        //public List<CumulativeSaleByStoreViewModel> GetAllStoresCumulativeSalesForToday()
        //{

        //    var sales = this.repository.GetCumulativeSalesForAllStores();
        //    var salesGroupedByStore = sales.GroupBy(x => x.SiteId)
        //        .Select(grp => new CumulativeSaleByStoreViewModel() { StoreName = grp.Key, Data = Mapper.Map<List<CumulativeSalesData>>(grp.ToList()) })
        //        .ToList();
        //    return salesGroupedByStore;
        //}

        public CumulativeSaleByStoreViewModel GetCumulativeSalesForToday(string StoreId)
        {
            var sales = this.repository.GetCumulativeSalesForToday(StoreId);            
            var salesByStore = new CumulativeSaleByStoreViewModel() { StoreName = StoreNames.StoreName1[StoreId], Data = Mapper.Map<List<CumulativeSalesData>>(sales) };
            return salesByStore;
        }
    }
}