using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Russell";

            bool isEqual = (age == 41);

            bool userIsMichael = userName == "Michael";

            Console.WriteLine(isEqual);
            Console.WriteLine(userIsMichael);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = (firstList == secondList);
            Console.WriteLine(listsAreEqual);

            bool isGreaterThan = age < 36;
            bool isLessThan = age < 36;
            bool isGreaterOrEqual = age >= 36;


            bool isTrue = true;
            bool isFalse = false;
            bool andValue = isTrue == true && isFalse == false;

            bool anotherValue = (age == 25 && userName == "Russell");
            Console.WriteLine(anotherValue);

        }
    }
}
