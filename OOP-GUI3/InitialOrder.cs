using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GUI3
{
    public class InitialOrder : Constant
    {
        public double quantity { get; set; }
        public double itemAmount { get; set; }
        public InitialOrder()
        {
            quantity = 0;
            itemAmount = 0;
        }
        public double getCoffeePrice(string coffee)
        {
            if (coffee == "cappuccino")
                return cappuccino;
            else if (coffee == "espresso")
                return espresso;
            else if (coffee == "latte")
                return latte;
            else if (coffee == "icedLatte")
                return icedLatte;
            else if (coffee == "icedCappuccino")
                return icedCappuccino;
            else
                return 0.00;
        }
        public void coffeeSelection(Total total, string coffee)
        {
            itemAmount += quantity * getCoffeePrice(coffee);
            total.subtotal += itemAmount;
            total.countTotalDollarAmount += itemAmount;
        }
        public void ifTakeout(Total total)
        {
            total.tax += itemAmount * taxRate;
            total.countTotalDollarAmount += itemAmount * taxRate;
        }

    }
}
