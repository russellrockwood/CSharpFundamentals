using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class ConditionsLoop
    {
        [TestMethod]
        public void MorningChallenge()
        {
            string word = "Supercalifragilisticexpialidocious";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'i' || word[i] == 'l')
                {
                    Console.WriteLine(word[i]);
                }
                else
                {
                    Console.WriteLine("Not an i or an l.");
                }
            }

            Console.WriteLine(word.Length);
        }
    }
}
