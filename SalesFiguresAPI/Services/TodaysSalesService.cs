using AutoMapper;
using DataAccess;
using DataAccess.Models;
using SalesFiguresAPI.Models;
using System.Collections.Generic;

namespace SalesFiguresAPI.Services
{
    public class TodaysSalesService
    {
        public List<SiteTotalFigures> GetTodaySales()
        {
            var repo = new TodaysSalesRepository();
            return Mapper.Map<List<SiteTotalFigures>>(repo.GetTodaysSales());
        }
    }
}