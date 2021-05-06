using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class User
    {
        public User(string firstName, string lastName, int id, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Birthday = birthday;
        }

        public User() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; }
        public DateTime Birthday { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetUserAge()
        {
            TimeSpan ageSpan = DateTime.Now - Birthday;
            double totalAgeInyears = ageSpan.TotalDays / 365.25;
            int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInyears));
            return yearsOld;
        }

    }

    //Give the user a FirstName, LastName, ID (an integer, with no setter), and BirthDate properties.

    //Create a blank constructor and a full constructor for this class.

    //Bonus: Create a method that returns the full name of the user.

    //Double Bonus: Create a method that returns the age of the user in years.
}
