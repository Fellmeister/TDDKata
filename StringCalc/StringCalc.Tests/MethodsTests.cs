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
        [Test]
        public void WhenPassedEmptyString_ReturnsZero()
        {
            Assert.That(Methods.Add(""), Is.EqualTo(0));
        }

        [Test]
        public void WhenPassedSingleNumber_ReturnsSingleNumber()
        {
            Assert.That(Methods.Add("1"), Is.EqualTo(1));
        }

        [TestCase("1,1", 2)]
        [TestCase("1,2", 3)]
        [TestCase("4,1", 5)]
        public void WhenPassedTwoNumbers_ReturnsSum(string nums, int result)
        {
            Assert.That(Methods.Add(nums), Is.EqualTo(result));
        }

        [TestCase("4,1,4", 9)]
        public void WhenPassedMultipleNumbers_ReturnsSum(string nums, int result)
        {
            Assert.That(Methods.Add(nums), Is.EqualTo(result));
        }

        [TestCase("4\n1,4", 9)]
        public void WhenPassedNewLineCharsAndMultipleNumbers_ReturnsSum(string nums, int result)
        {
            Assert.That(Methods.Add(nums), Is.EqualTo(result));
        }


    }
}
