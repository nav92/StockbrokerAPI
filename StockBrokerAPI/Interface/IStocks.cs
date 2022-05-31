using StockBrokerAPI.Models;

namespace StockBrokerAPI.Interface
{
    public interface IStocks
    {
        List<Stocks> GetStockDetails(int clientId);
    }
}
