using AutoMapper;
using DataAccess.Models;
using SalesFiguresAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesFiguresAPI.App_Start
{
    public static class AutoMapperBootStrapper
    {
        public static void BootStrap()
        {
            Mapper.Initialize(cfg => {
                //cfg.CreateMap<SiteTotalSales, SiteTotalFigures>();
                cfg.CreateMap<SiteSalesPerHour, TodaysSalesByHourViewModel>();
                cfg.CreateMap<SiteSalesPerHour, CumulativeSalesData>();
                cfg.CreateMap<TotalSalesFigures, TodaySalesViewModel>();
                cfg.CreateMap<DispatchInformation, DispatchInfoViewModel>();
                cfg.CreateMap<TableData, SalesTableInformation>();
                cfg.CreateMap<FamilyOfBusinessPercentage, FamilyOfBusiness>();
            });
        }
    }
}