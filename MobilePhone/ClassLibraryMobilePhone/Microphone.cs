
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Microphone : IVoiceListener
    {
        public string Manufacturer { get; }
        public double Sensitivity { get; }
        public double NoiseLevel { get; }
        public string Type { get; } // built-in or external

        public Microphone(string manufacter, double sensitivity, double noiseLevel, string type)
        {
            Manufacturer = manufacter;
            Sensitivity = sensitivity;
            NoiseLevel = noiseLevel;
            Type = type;
        }

        public void Listen()
        {
            Console.WriteLine($"{nameof(Microphone)} sound");
        }

    }
}
