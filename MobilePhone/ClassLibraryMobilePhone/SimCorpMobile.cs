using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class SimCorpMobile : Mobile
    {
        public override  ScreenBase Screen { get { return vOLEDScreen; } }
        public override Battery Battery { get {return vBattery; } }
        public override Keyboard Keyboard { get { return vKeyboard; } }
        public override Speaker Speaker
        {
            get
            {
                return vSpeaker;
            }
        }
        public override Microphone Microphone
        {
            get
            {
               return vMicrophone;
            }
        }

        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();
        private readonly Battery vBattery = new Battery(4000, ChemistryType.lithium);
        private readonly Keyboard vKeyboard = new Keyboard(1, "latin");
        private readonly Speaker vSpeaker = new Speaker("Dif", "Type", 12.5, 120, 12);
        private readonly Microphone vMicrophone = new Microphone("Man", 135, 14.4, "best");
    }
}
