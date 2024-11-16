using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GUI3
{
    public class InitialOrder
    {
        public double quantity { get; set; }
        public double itemAmount { get; set; }
        public InitialOrder()
        {
            quantity = 0;
            itemAmount = 0;
        }

    }
}
