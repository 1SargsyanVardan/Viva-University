using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TarifPlans
    {
        string name;
        double cost;
        double inthernetGB;
        int minutes;
        public TarifPlans()
        {

        }
        public TarifPlans(string name,double cost,double internetGB,int minutes)
        {
            this.name = name;
            this.cost = cost;
            this.inthernetGB = internetGB;
            this.minutes = minutes;
        }
        public string Name { get { return name; } }
        public double Cost { get { return cost; } }
        public double InthernetGB { get { return inthernetGB; } }
        public int Minutes { get { return minutes; } }
    }
}
