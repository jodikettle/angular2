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
                cfg.CreateMap<SiteTotalSales, SiteTotalFigures>();
                cfg.CreateMap<SiteSalesPerHour, SalesByHourByStore>();
                cfg.CreateMap<SiteSalesPerHour, CumulativeSalesData>();
            });
            //Mapper.CreateMap<IEnumerable<IGrouping<String, Zone>>, IEnumerable<IGrouping<String, ZoneDTO>>>()
        }
    }
}