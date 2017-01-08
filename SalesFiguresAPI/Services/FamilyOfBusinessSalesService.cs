using SalesFiguresAPI.Models;
using System.Collections.Generic;
using DataAccess;
using AutoMapper;

namespace SalesFiguresAPI.Services
{
    public class FamilyOfBusinessSalesService : IFamilyOfBusinessSalesService
    {
        private readonly IFamilyOfBusinessRepository repository;

        public FamilyOfBusinessSalesService(IFamilyOfBusinessRepository repository)
        {
            this.repository = repository;
        }

        public SalesByFamilyOfBusinessViewModel GetSalesByFamilyOfBusiness()
        {
            var sales = new SalesByFamilyOfBusinessViewModel();
            sales.Sales = Mapper.Map<List<FamilyOfBusiness>>(this.repository.GetSalesByFamilyOfBusiness());
            return sales;
        }

        public SalesByFamilyOfBusinessByHourViewModel GetSalesByFamilyOfBusinessByHour()
        {
            return new SalesByFamilyOfBusinessByHourViewModel();
        }
    }
}