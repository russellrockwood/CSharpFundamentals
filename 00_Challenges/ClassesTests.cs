using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CalculaterMethodsTests()
        {
            Calculater firstCalc = new Calculater();
            Console.WriteLine(firstCalc.AddNumbers(5,4));
            Console.WriteLine(firstCalc.SubtractNumbers(5,4));
            Console.WriteLine(firstCalc.MultiplyNumbers(5,4));
            Console.WriteLine(firstCalc.DivideNumbers(5,4));
        }
    }
}
