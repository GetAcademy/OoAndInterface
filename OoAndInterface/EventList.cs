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
    }
}
