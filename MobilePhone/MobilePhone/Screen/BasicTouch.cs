using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class BasicTouch
    {
        public double TouchTime { get; set; }
        public string MoveDirection { get; set; }
    }
}
