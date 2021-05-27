using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges.BirdMan
{
    [TestClass]
    public class BirdTests
    {
        [TestMethod]
        public void TestGetBirdSequence()
        {
            string[] words = GetBirdSequence();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            
        }


        //public string[] GetBirdSequence()
        //{
        //    string text = System.IO.File.ReadAllText(@"C:\ElevenFiftyProjects\GoldBadge\CSharpFundamentals\00_Challenges\BirdMan\game-sequence.txt");
        //    string[] words = text.Split(',');
        //    Console.WriteLine(words);
        //    return words;

        //}
    }
}
