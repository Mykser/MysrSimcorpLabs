using MobilePhone.Microphone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class ProneMicrophone: IVoiceListener
    {
        public string Manufacturer { get; set; }
        public double Sensitivity { get; set; }
        public double NoiseLevel { get; set; }
    }
}
