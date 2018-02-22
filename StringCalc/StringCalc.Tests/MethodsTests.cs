using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using StringCalc.Core;
using Assert = NUnit.Framework.Assert;

namespace StringCalc.Tests
{
    [TestClass]
    public class MethodsTests
    {
        [TestMethod]
        public void WhenPassedEmptyString_ReturnsZero()
        {
            Assert.That(Methods.Add(""), Is.EqualTo(0));
        }
    }
}
