using MobilePhone.PhoneJack;
using System;
using System.Linq;

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


            IPlayback component = null;
            string[] correctValues = new string[] { "1", "2", "3", "4" };
            var choice = "";

            do
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        component = new iPhoneHeadset(new ConsoleOutput());
                        break;
                    case "2":
                        component = new SamsungHeadset(new ConsoleOutput());
                        break;
                    case "3":
                        component = new UnofficialiPhoneHeadset(new ConsoleOutput());
                        break;
                    case "4":
                        component = new PhoneSpeaker(new ConsoleOutput());
                        break;
                    default:
                        Console.WriteLine("Choose correct playback component 1,2,3 or 4");
                        break;
                }

            }
            while (!correctValues.Contains(choice));


            if (component != null)
            {
               component.Play(component);
            }



            Console.ReadKey();

        }
    }
}
