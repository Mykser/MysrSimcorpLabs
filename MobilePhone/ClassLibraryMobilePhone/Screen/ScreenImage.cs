using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class ScreenImage : IScreenImage
    {
        public double ImageSize { get; set; }
        public string Drawing { get; set; }

        public ScreenImage(double imageSize, string drawing)
        {
            ImageSize = imageSize;
            Drawing = drawing;
        }

    }
}
