using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GUI3
{
    public class Constant
    {
        public double capuccino { get; set; }
        public double espresso { get; set; }
        public double latte { get; set; }
        public double icedLatte { get; set; }
        public double icedCapuccino { get; set; }
        public double taxRate { get; set; }
        public Constant()
        {
            capuccino = 2.00;
            espresso = 2.25;
            latte = 1.75;
            icedLatte = 2.50;
            icedCapuccino = 2.50;
            taxRate = 0.08;
        }
        public Constant(double capuccino, double espresso, double latte, double icedLatte, double icedCapuccino, double taxRate)
        {
            this.capuccino = capuccino;
            this.espresso = espresso;
            this.latte = latte;
            this.icedLatte = icedLatte;
            this.icedCapuccino = icedCapuccino;
            this.taxRate = taxRate;
        }
    }
}
