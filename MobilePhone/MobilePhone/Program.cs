using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.PhoneJack;

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobile = new SimCorpMobile();

            Console.WriteLine(mobile.GetDescription());


            Console.WriteLine("Select playback component (specify index):");
            Console.WriteLine("1 - iPhoneHeadset");
            Console.WriteLine("2 - SamsungHeadset");
            Console.WriteLine("3 - UnofficialiPhoneHeadset");
            Console.WriteLine("4 - PhoneSpeaker");

            var iPhoneHeadset = new iPhoneHeadset();
            iPhoneHeadset.Play("text");

            Console.ReadKey();

        }
    }
}
