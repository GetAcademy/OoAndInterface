using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoAndInterface
{
    class EventList
    {
        private List<IEvent> _events;

        public EventList()
        {
            _events = new List<IEvent>();
        }

        public void Add(IEvent myEvent)
        {
            _events.Add(myEvent);
        }

        public Inventory CreateInventory(DateTime date)
        {
            var inventory = new Inventory();
            foreach (var myEvent in _events.Where(e=>e.Date <= date))
            {
                inventory.Process(myEvent);
            }
            return inventory;
        }

        /*
            Uten interface: 

            private List<BuyOrSellEvent> _buyOrSellEvents;
            private List<DepositOrWithdrawEvent> _depositOrWithdrawEvents;

            public EventList()
            {
                _buyOrSellEvents = new List<BuyOrSellEvent>();
                _depositOrWithdrawEvents = new List<DepositOrWithdrawEvent>();
            }

            public void Add(DepositOrWithdrawEvent myEvent)
            {
                _depositOrWithdrawEvents.Add(myEvent);
            }

            public void Add(BuyOrSellEvent buyOrSellEvent)
            {
                _buyOrSellEvents.Add(buyOrSellEvent);
            }

            public Inventory CreateInventory(DateTime date)
            {
                var inventory = new Inventory();
                foreach (var buyOrSellEvent in _buyOrSellEvents.Where(e=>e.Date <= date))
                {
                    inventory.Process(buyOrSellEvent);
                }
                foreach (var depositOrWithdrawEvent in _depositOrWithdrawEvents.Where(e => e.Date <= date))
                {
                    inventory.Process(depositOrWithdrawEvent);
                }

                return inventory;
            }
         
         */
    }
}
