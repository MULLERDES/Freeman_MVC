using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;
using ET.Abstraction;


namespace ET.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObj()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_above_100()
        {
            IDiscountHelper target = getTestObj();
            decimal total = 100;
        }
    }
}
