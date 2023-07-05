using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DoubleExtension
    {
        public static double MyRound(this double number, int round)
        {
            double ast = Math.Pow(10, round);
            double retNumber = (int)(number * ast) / ast;
            return retNumber;
        }
    }
}
