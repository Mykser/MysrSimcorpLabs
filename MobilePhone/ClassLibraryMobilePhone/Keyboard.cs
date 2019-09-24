using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Keyboard
    {
        public int Figures { get; set; }
        public string Letters { get; set; }
        public Keyboard(int figures, string letters)
        {
            Figures = figures;
            Letters = letters;
        }
    }
}
