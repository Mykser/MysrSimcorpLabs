using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFormatting

{
    public delegate string FormatDelegate(string text);
   static public   class MessageFormatter
    {

          public static string FormatWithTime(string message)
        {
            return $"[{DateTime.Now}]{message + Environment.NewLine}";
        }
        public static string FormatWithTimeEnd(string message)
        {
            return $"{message}[{DateTime.Now}]{Environment.NewLine}";
        }

        public static string FormatWithUpperCase(string message)
        {
            return message.ToUpper() + Environment.NewLine;
        }

        public static string FormatWithLowerCase(string message)
        {
            return message.ToLower() + Environment.NewLine;
        }
        public static string FormatCustom(string message)
        {
            return "!!!"+message+ "!!!" + Environment.NewLine;
        }

    }
}
