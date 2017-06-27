﻿using Algorithm.Sandbox.BitAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sandbox.Tests.BitAlgorithms
{
    [TestClass]
    public class BaseConversion_Tests
    {
        //[TestMethod]
        public void SmokeTest()
        {
            Assert.AreEqual("Foo",
                BaseConversion.Convert("9", "0123456789".ToCharArray(), 
                    "oF8".ToCharArray()));

            Assert.AreEqual("9",
                BaseConversion.Convert("Foo", "oF8".ToCharArray(),
                    "0123456789".ToCharArray()));

            Assert.AreEqual("10011",
                BaseConversion.Convert("13", "0123456789abcdef".ToCharArray(),
                    "01".ToCharArray()));

            Assert.AreEqual("Foo",
                BaseConversion.Convert("CODE", "O!CDE?".ToCharArray(),
                    "A?JM!.".ToCharArray()));

        }
    }
}
