using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Speaker
    {

        public string Diffuser { get; }
        public string TypeOfHead { get; }
        public double Diametr { get; }
        public double Power { get; }
        public int Impedance { get; }

        public Speaker(string diffuser, string typeOfHead, double diametr, double power, int impedance)

        {
            Diffuser = diffuser;
            TypeOfHead = typeOfHead;
            Diametr = diametr;
            Power = power;
            Impedance = impedance;

        }
    }
}

