using System;

namespace OoAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockList = new StockList();
            var eventsReader = new EventsReader(new FileTransactionsCsvGetter());
            var eventList = eventsReader.Get(stockList);
        }
    }
}
