using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GUI3
{
    public class Constant
    {
        public double cappuccino { get; set; }
        public double espresso { get; set; }
        public double latte { get; set; }
        public double icedLatte { get; set; }
        public double icedCappuccino { get; set; }
        public double taxRate { get; set; }
        public Constant()
        {
            cappuccino = 2.00;
            espresso = 2.25;
            latte = 1.75;
            icedLatte = 2.50;
            icedCappuccino = 2.50;
            taxRate = 0.08;
        }
        public Constant(double cappuccino, double espresso, double latte, double icedLatte, double icedCappuccino, double taxRate)
        {
            this.cappuccino = cappuccino;
            this.espresso = espresso;
            this.latte = latte;
            this.icedLatte = icedLatte;
            this.icedCappuccino = icedCappuccino;
            this.taxRate = taxRate;
        }
    }
}
