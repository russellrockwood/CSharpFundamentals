using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository.NewFolder1
{
    public class Movie : StreamingContent
    {
        public Movie() { }
        public Movie(string title, string description, double starRating, GenreType typeOfGenre, MaturityRating maturityRating, double runTime) : base(title, description, starRating, typeOfGenre, maturityRating) 
        {
            // Setting properties that aren't included in the base constructor
            RunTime = runTime;
        }
    
        public double RunTime { get; set; }
    }
}
