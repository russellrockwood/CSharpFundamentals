using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);

                total += 1;
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                if (someCount <= 100)
                {
                    Console.Write(someCount);
                    someCount++;
                }
                else
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void foreachLoops()
        {
            string[] students = { "Russell", "Aarron", "Alexandro", "Ben", "Chris" };

            foreach (string student in students)
            {
                Console.WriteLine($"{student} is in this class yo.");
            }


            string myName = "Lord Russell Rockwood Esquire.";
            foreach (char letter in myName)
            {
                Console.WriteLine(letter);
            }

        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("hello");
            } while (iterator < 5);
        }
    }
}
