using CsvHelper.Configuration;
using StockBrokerAPI.Models;

namespace StockBrokerAPI.Mapper
{
    public sealed class StockDataMap: ClassMap<Stocks>
    {
        public StockDataMap()
        {
            Map(x => x.ClientID).Name("Client Id");
            Map(x => x.ClientName).Name("Client Name");
            Map(x => x.StocksName).Name("Stocks Name");
            Map(x => x.Quantity).Name("Quantity");
            Map(x => x.PurchaseDate).Name("Purchase Date");
            Map(x => x.PurchasePrice).Name("Purchase Price");
            Map(x => x.CurrentMarketRate).Name("Current Market Rate");
        }
    }
}
