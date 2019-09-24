using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class ScreenBase
    {
        protected double Size { get; }
        protected int Pixels { get;}
        protected int Type { get; }
        protected Touch Touch { get;}
        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
    }
    public enum Touch
    {
        basicTouch = 1,
        SingleTouch = 2,
        MultiTouch = 3,
    }
}
