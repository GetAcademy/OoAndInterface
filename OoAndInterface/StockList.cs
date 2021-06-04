using System.Collections.Generic;
using System.Linq;

namespace OoAndInterface
{
    class StockList
    {
        private List<Stock> _stocks;

        public StockList()
        {
            _stocks = new List<Stock>();
        }

        public Stock Get(string ticker)
        {
            var stock = _stocks.SingleOrDefault(s => s.Ticker == ticker);
            if (stock != null) return stock;
            stock = new Stock(ticker, "Stock with ticker " + ticker);
            _stocks.Add(stock);
            return stock;
        }
    }
}
