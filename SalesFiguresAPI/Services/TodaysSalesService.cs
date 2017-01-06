using DataAccess;

namespace SalesFiguresAPI.Services
{
    public class TodaysSalesService : ITodaysSalesService
    {
        private readonly ITodaysSalesRepository repository;

        public TodaysSalesService(ITodaysSalesRepository repository)
        {
            this.repository = repository;
        }
        public double GetTodaysSalesTotal(string storeId)
        {
            storeId = "000" + storeId;
            return repository.GetTodaysSales(storeId);
        }
    }
}