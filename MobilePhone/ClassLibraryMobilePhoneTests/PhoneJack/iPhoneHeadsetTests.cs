using ClassLibraryMobilePhoneTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.PhoneJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.PhoneJack.Tests
{
    [TestClass()]
    public class iPhoneHeadsetTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            var phoneHeadset = new iPhoneHeadset(new OutputFake());
            //phoneHeadset.Play(phoneHeadset);
           var a = phoneHeadset.ToString();
            Assert.AreEqual(a, "iPhoneHeadset sound");
        }
    }
}