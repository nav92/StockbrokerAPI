using StockBrokerAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBrokerAPITest.Controller
{
    public class StocksControllerTest
    {
        StocksController stocksController;

        [SetUp]
        public void SetUp()
        {
            stocksController = new StocksController();
        }
    }
}
