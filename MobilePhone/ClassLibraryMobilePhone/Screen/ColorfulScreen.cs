using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class ColorfulScreen : ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colorful Screen");
        }
        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Colorful Screen with brightness");
        }
        public override string ToString()
        {
            return "Colorful Screen ";
        }
    }
}
