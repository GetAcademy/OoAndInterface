using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoAndInterface
{
    class Stock
    {
        public string Ticker { get; }
        public string Name { get; }

        public Stock(string ticker, string name)
        {
            Ticker = ticker;
            Name = name;
        }
    }
}
