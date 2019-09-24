using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Processor
    {
        public string Model { get; }
        public double Frequency { get; }
        public int NumberOfCores { get; }
        public Processor(string model, double frequency, int numberOfCores)
        {
            Model = model;
            Frequency = frequency;
            NumberOfCores = numberOfCores;
        }

    }
}
