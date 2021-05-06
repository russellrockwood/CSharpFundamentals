using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators()
        {
            int a = 22;
            int b = 15;

            int sum = a + b;
            Console.WriteLine(sum);

            int difference = a - b;
            Console.WriteLine(difference);

            int product = a * b;
            Console.WriteLine(product);

            int quotient = a / b;
            Console.WriteLine(quotient);

            int remainder = a % b;
            Console.WriteLine(remainder);

        }
    }
}
