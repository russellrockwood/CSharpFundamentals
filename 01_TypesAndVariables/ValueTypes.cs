using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true;

            bool isDeclaredAndInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numberChar = '7';
            char symbol = '*';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShortEx = 32767;
            int intMin = -21474836;
            Int32 intMax = 2147483647;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.5649841f;
            double doubleExample = 1.65498923874d;
            decimal deciEx = 1.87364827364m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(deciEx);
        }

        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli}
        [TestMethod]
        public void Enum ()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType myPastry2 = PastryType.Cupcake;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1988, 04, 11);

            TimeSpan age = today - birthday;
            int ageInDays = age.Days;

            Console.WriteLine(ageInDays / 365);
        }
    }
}
