using StockBrokerAPI.Interface;
using StockBrokerAPI.Models;
using CsvHelper;
using StockBrokerAPI.Mapper;
using System.Text;

namespace StockBrokerAPI.Repository
{
    public class StocksRepository: IStocks
    {
        public List<Stocks> GetStockDetails(int clientId)
        {
            var result = ReadCSVFile().Where(x => x.ClientID == clientId).ToList();

            return result;
        }

        private static List<Stocks> ReadCSVFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = "Data";
            string fullPath = Path.Combine(currentDirectory, path, "StockBrokerData.csv");
            try
            {
                using (var reader = new StreamReader(fullPath, Encoding.Default))
                {
                    using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                    {
                        csv.Context.RegisterClassMap<StockDataMap>();
                        var records = csv.GetRecords<Stocks>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
