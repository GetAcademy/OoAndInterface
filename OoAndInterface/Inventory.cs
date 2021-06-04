using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoAndInterface
{
    class Inventory
    {
        public decimal CashAmount { get; private set; }
        public Dictionary<Stock, int> Stocks { get; }

        public Inventory()
        {
            Stocks = new Dictionary<Stock, int>();
        }

        public void Process(IEvent myEvent)
        {
            if (myEvent is BuyOrSellEvent buyOrSellEvent)
            {
                var stock = buyOrSellEvent.Stock;
                if (buyOrSellEvent.IsBuy && !Stocks.ContainsKey(stock)) Stocks.Add(stock, 0);

                var factor = buyOrSellEvent.IsBuy ? 1 : -1;
                Stocks[stock] += buyOrSellEvent.ShareCount * factor;
            }
            else if (myEvent is DepositOrWithdrawEvent depositOrWithdrawEvent)
            {
                var factor = depositOrWithdrawEvent.IsDeposit ? 1 : -1;
                CashAmount += depositOrWithdrawEvent.Amount * factor;
            }
        }

        /*
            Uten interface:

            public void Process(BuyOrSellEvent buyOrSellEvent)
            {
                var stock = buyOrSellEvent.Stock;
                if (buyOrSellEvent.IsBuy && !Stocks.ContainsKey(stock)) Stocks.Add(stock, 0);

                var factor = buyOrSellEvent.IsBuy ? 1 : -1;
                Stocks[stock] += buyOrSellEvent.ShareCount * factor;
            }

            public void Process(DepositOrWithdrawEvent depositOrWithdrawEvent)
            {
                var factor = depositOrWithdrawEvent.IsDeposit ? 1 : -1;
                CashAmount += depositOrWithdrawEvent.Amount * factor;
            }
         */
    }
}
