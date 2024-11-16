using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GUI3
{
    public class Total
    {
        public double subtotal { get; set; }
        public double tax { get; set; }
        public double totalDue { get; set; }
        public double countOrders { get; set; }
        public double countTotalDollarAmount { get; set; }
        public double countAverageSale { get; set; }
        public Total()
        {
            subtotal = 0;
            tax = 0;
            totalDue = 0;
            countOrders = 0;
            countTotalDollarAmount = 0;
            countAverageSale = 0;
        }
        public Total(double subtotal, double tax, double totalDue, double countOrders, double countTotalDollarAmount, double countAverageSale)
        {
            this.subtotal = subtotal;
            this.tax = tax;
            this.totalDue = totalDue;
            this.countOrders = countOrders;
            this.countTotalDollarAmount = countTotalDollarAmount;
            this.countAverageSale = countAverageSale;
        }
        public double showAverageSale(Total total)
        {
            if (total.countTotalDollarAmount <= 0 || total.countOrders <= 0)
            {
                return total.countAverageSale;
            }
            else
            {
                total.countAverageSale = total.countTotalDollarAmount / total.countOrders;
                return total.countAverageSale;
            }
        }
    }
}
