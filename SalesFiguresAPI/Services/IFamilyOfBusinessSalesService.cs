using SalesFiguresAPI.Models;

namespace SalesFiguresAPI.Services
{
    public interface IFamilyOfBusinessSalesService
    {
        SalesByFamilyOfBusinessViewModel GetSalesByFamilyOfBusiness();

        SalesByFamilyOfBusinessByHourViewModel GetSalesByFamilyOfBusinessByHour();
    }
}
