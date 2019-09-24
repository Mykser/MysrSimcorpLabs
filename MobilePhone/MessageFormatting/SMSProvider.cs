using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFormatting
{
   public class SMSProvider
    {
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSReceived;
        private void RaiseSMSReceivedEvent(string message)
        {
            var handler = SMSReceived;
            if (handler != null)
            {
                handler(message);
            }

        }
    }
}
