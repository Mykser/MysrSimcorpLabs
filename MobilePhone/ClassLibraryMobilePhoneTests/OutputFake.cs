﻿using MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobilePhoneTests
{
    public class OutputFake : IOutput
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
