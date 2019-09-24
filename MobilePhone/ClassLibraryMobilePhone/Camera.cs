using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Camera
    {
        public string Type { get; set; }
        public int MatrixResolution { get; set; }
        public bool Flash { get; set; }
        public Camera(string type, int matrixResolution, bool flash)
        {
            Type = type;
            MatrixResolution = matrixResolution;
            Flash = flash;
        }

    }
}
