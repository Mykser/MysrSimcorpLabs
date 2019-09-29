using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageFormatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFormatting.Tests
{
    [TestClass()]
    public class MessageFormatterTests
    {
        [TestMethod()]
        public void FormatWithTimeTest()
        {
            var msg = MessageFormatter.FormatWithTime("msg1");
            Assert.AreEqual(msg, $"[{DateTime.Now}]{"msg1" + Environment.NewLine}");
        }

        [TestMethod()]
        public void FormatWithTimeEndTest()
        {
            var msg = MessageFormatter.FormatWithTimeEnd("msg2");
            Assert.AreEqual(msg, $"{"msg2"}[{DateTime.Now}]{Environment.NewLine}");
        }

        [TestMethod()]
        public void FormatWithUpperCaseTest()
        {
            var msg = MessageFormatter.FormatWithUpperCase("msg3");
            Assert.AreEqual(msg, "MSG3" + Environment.NewLine);
        }

        [TestMethod()]
        public void FormatWithLowerCaseTest()
        {
            var msg = MessageFormatter.FormatWithLowerCase("mSG4");
            Assert.AreEqual(msg, "msg4" + Environment.NewLine);
        }

        [TestMethod()]
        public void FormatCustomTest()
        {
            var msg = MessageFormatter.FormatCustom("msg5");
            Assert.AreEqual(msg, "!!!msg5!!!" + Environment.NewLine);
        }
    }
}