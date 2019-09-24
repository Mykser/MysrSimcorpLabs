using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class RetinaScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colorful Retina Screen");
        }
    }
}
