using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoAndInterface
{
    class BuyOrSellEvent : IEvent
    {
        public DateTime Date { get; }
        public decimal AmountPerShare { get; }
        public Stock Stock { get; }
        public int ShareCount { get; }
        public bool IsBuy { get; }

        public BuyOrSellEvent(DateTime date, decimal amountPerShare, Stock stock, int shareCount, bool isBuy)
        {
            Date = date;
            AmountPerShare = amountPerShare;
            Stock = stock;
            ShareCount = shareCount;
            IsBuy = isBuy;
        }
    }
}
