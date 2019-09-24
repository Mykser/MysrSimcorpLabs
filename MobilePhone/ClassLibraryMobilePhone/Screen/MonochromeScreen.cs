using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class MonochromeScreen : ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Monochrome Screen");
        }
        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Monochrome Screen with brightness");
        }
        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}
