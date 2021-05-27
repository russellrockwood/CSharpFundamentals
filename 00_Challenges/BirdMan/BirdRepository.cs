using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.BirdMan
{
    public class BirdRepository
    {
        //enum BirdPoints { Bird=10, CrestedIbis=100, }
        public string[] GetBirdSequence()
        {
            string text = System.IO.File.ReadAllText(@"C:\ElevenFiftyProjects\GoldBadge\CSharpFundamentals\00_Challenges\BirdMan\game-sequence.txt");
            string[] words = text.Split(',');
            Console.WriteLine(words);
            return words;

        }

        /* Bird: 10 points each
        Crested Ibis: 100 points
        Great Kiskudee: 300 points
        Red Crossbill: 500 points
        Red-necked Phalarope: 700 points
        Evening Grosbeak: 1000 points
        Greater Prairie Chicken: 2000 points
        Iceland Gull: 3000 points
        Orange-Bellied Parrot: 5000 points
        Vulnerable Bird Hunters: 
        #1 in succession: 200 points 
        #2 in succession: 400 points
        #3 in succession: 800 points
        #4 in succession: 1600 points */
    }
}
