using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Russell";
            string lastName = "Rockwellington";

            //Concatination
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //Composite
            string compositeFullName = string.Format("{0}  {1} is an exceptable human {2}", firstName, lastName, "indeed");
            Console.WriteLine(compositeFullName);

            //Interpolation

            string interpolFullName = $"{firstName} \"Lord\" {lastName} is the best of the best.";
            Console.WriteLine(interpolFullName);

           
        }

        [TestMethod]
        public void Collection()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "friends", "what", "is", "going", "on", stringExample, "?" };

            string firstString = $"{stringArray[0]} {stringArray[2]} {stringArray[3]} {stringArray[4]} {stringArray[7]}";
            Console.WriteLine(firstString);

            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("Hello");
            listOfIntegers.Add(22);
            listOfStrings.Add("World");


            Console.WriteLine(listOfIntegers[0]);
            Console.WriteLine(listOfStrings[1]);

            listOfStrings.Remove(listOfStrings[0]);
            Console.WriteLine(listOfStrings[0]);


            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I am next");
            firstInFirstOut.Enqueue("I am last");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            string whosFirstNow = firstInFirstOut.Peek();
            Console.WriteLine(whosFirstNow);

            //Dictionary
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(001, "EFA Office");

            string badgeDoor = keyAndValue[001];

            Console.WriteLine(badgeDoor);
        }
    }
}
