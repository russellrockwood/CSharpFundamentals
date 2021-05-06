using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_Interfaces.Currency
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void CurrencyValueTests()
        {
            ICurrency penny = new Penny();
            ICurrency dime = new Dime();
            ICurrency dollar = new Dollar();

            Assert.AreEqual(.01m, penny.Value);
            Assert.AreEqual(.10m, dime.Value);
            Assert.AreEqual(1m, dollar.Value);
        }

        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(37.12)]
        [DataRow(1.32)]
        [DataRow(18)]

        public void EPaymentTest(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);

            var ePay = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePay.Value);

        }
    }
}
