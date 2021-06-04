using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoAndInterface
{
    class EventsReader
    {
        private ITransactionsCsvGetter _getter;

        public EventsReader(ITransactionsCsvGetter getter)
        {
            _getter = getter;
        }
        public EventList Get(StockList stockList)
        {
            //var lines = File.ReadAllLines("transactions.txt");
            var lines = _getter.Get();
            var eventList = new EventList();
            foreach (var line in lines)
            {
                var lineParts = line.Split(',');
                var date = DateTime.Parse(lineParts[0]);
                var eventType = lineParts[1];
                var isDeposit = eventType == "deposit";
                var isBuy = eventType == "buy";
                if (isDeposit || eventType == "withdraw")
                {
                    var amount = Convert.ToDecimal(lineParts[2]);
                    var depositOrWithdrawEvent = new DepositOrWithdrawEvent(date, amount, isDeposit);
                    eventList.Add(depositOrWithdrawEvent);
                }
                else if (isBuy || eventType == "sell")
                {
                    var stockTicker = lineParts[2];
                    var stock = stockList.Get(stockTicker);
                    var stockCount = Convert.ToInt32(lineParts[3]);
                    var amountPerStock = Convert.ToDecimal(lineParts[4]);
                    var buyOrSellEvent = new BuyOrSellEvent(date, amountPerStock, stock, stockCount, isBuy);
                    eventList.Add(buyOrSellEvent);
                }
            }

            return eventList;
        }
    }
}
