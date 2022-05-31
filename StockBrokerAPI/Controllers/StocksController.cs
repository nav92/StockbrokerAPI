using Microsoft.AspNetCore.Mvc;
using StockBrokerAPI.Interface;
using StockBrokerAPI.Models;

namespace StockBrokerAPI.Controllers
{
    [Route("api/[controller]")]
    public class StocksController : Controller
    {
        public IStocks _iStocks;
        public StocksController(IStocks iStocks)
        {
            _iStocks = iStocks;
        }

        [HttpGet]
        [Route("GetStockDetails/{clientId}")]
        public ActionResult<List<Stocks>> GetStockDetails(int clientId)
        {
            var result = _iStocks.GetStockDetails(clientId);
            return result;
        }
    }
}
