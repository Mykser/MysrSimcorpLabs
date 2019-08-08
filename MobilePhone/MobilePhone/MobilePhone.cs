using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class MobilePhone
    {
        public ScreenBase Screen { get; set; }
        public Battery Battery { get; set; }
        public Keyboard Keyboard { get; set; }
        public string Model { get; set; }
        public string Style { get; set; }
        public Dynamic Dynamic { get; set; }
        public int MyProperty { get; set; }

        //TODO: add others here
    }
}
