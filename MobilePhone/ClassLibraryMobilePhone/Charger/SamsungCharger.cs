using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Charger
{
    class SamsungCharger : IPhoneCharger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(SamsungCharger)} charging");
        }
    }
}
