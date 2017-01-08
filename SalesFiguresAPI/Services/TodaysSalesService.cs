
using DataAccess;
using SalesFiguresAPI.Models;
using AutoMapper;
using System.Collections.Generic;
using System;

namespace SalesFiguresAPI.Services
{
    public class TodaysSalesService : ITodaysSalesService
    {
        private readonly ITodaysSalesRepository repository;

        public TodaysSalesService(ITodaysSalesRepository repository)
        {
            this.repository = repository;
        }

        public List<TodaysSalesByHourViewModel> GetSalesByHour()
        {
            return Mapper.Map<List<TodaysSalesByHourViewModel>>(repository.GetTodaysSaleByHour());
        }

        public SalesByStoreTableDataViewModel GetTableData()
        {
            var tableData = Mapper.Map<List<SalesTableInformation>>(repository.GetAllStoresThisWeekAndLast());
            return new SalesByStoreTableDataViewModel { TableInfo =  tableData };
        }

        public TodaySalesViewModel GetTodaysSalesTotal()
        {
            return Mapper.Map<TodaySalesViewModel>(repository.GetTodaysSales());
        }
    }
}