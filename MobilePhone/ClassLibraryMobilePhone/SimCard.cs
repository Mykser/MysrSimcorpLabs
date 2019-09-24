using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class SimCard
    {
        public string SimType { get; }
        public string Operator { get; }

        public SimCard(string simType, string Operator)
        {
            SimType = simType;
            this.Operator = Operator;

        }
    }
}
