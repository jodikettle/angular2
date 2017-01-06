namespace SalesFiguresAPI.Services
{
    public interface ITodaysSalesService
    {
        double GetTodaysSalesTotal(string StoreId);
    }
}
