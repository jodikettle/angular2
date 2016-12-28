using AutoMapper;
using DataAccess.Models;
using SalesFiguresAPI.Models;

namespace SalesFiguresAPI.App_Start
{
    public static class AutoMapperBootStrapper
    {
        public static void BootStrap()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<SiteTotalSales, SiteTotalFigures>();
                cfg.CreateMap<SiteSalesPerHour, SalesByHourByStore>();
            });

        }
    }
}