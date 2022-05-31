namespace StockBrokerAPI.Models
{
    public class Stocks
    {
        public int ClientID { get; set; }
        public string? ClientName { get; set; }
        public string? StocksName { get; set; }
        public int Quantity { get; set; }
        public string? PurchaseDate { get; set; }
        public int PurchasePrice { get; set; }
        public int CurrentMarketRate { get; set; }

    }
}
