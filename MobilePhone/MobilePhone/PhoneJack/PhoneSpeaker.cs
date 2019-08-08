using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.PhoneJack
{
    public class PhoneSpeaker : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
