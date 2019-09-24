using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Battery
    {
        public double Capacity { get; }
        public ChemistryType Chemistry { get; }
        public Battery(double capacity, ChemistryType chemistry)
        {
            Capacity = capacity;
            Chemistry = chemistry;
        }
    }

    public enum ChemistryType
    {
        lead = 1,
        nickel = 2,
        lithium = 3
    }
}
