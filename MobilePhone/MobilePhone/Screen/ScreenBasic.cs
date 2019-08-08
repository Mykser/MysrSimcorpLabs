using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class ScreenBasic
    {
        public double Size { get; set; }
        public int Pixels { get; set; }
        public int Type { get; set; }
        public Touch Touch { get; set; }
    }

    public enum Touch
    {
        basicTouch = 1,
        SingleTouch = 2,
        MultiTouch = 3,
    }
}
