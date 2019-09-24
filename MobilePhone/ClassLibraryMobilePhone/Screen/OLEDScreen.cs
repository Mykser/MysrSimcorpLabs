using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class OLEDScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colorful OLED Screen");
        }
    }
}
