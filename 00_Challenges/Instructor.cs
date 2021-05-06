using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseTaught { Cyber, WebDev, SoftwareDev}
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNumber { get; set; }
        public CourseTaught Course { get; set; }
    }
}
//Make an Instructor class with the following properties

//string FirstName
//string LastName
//DateTime dateOfBirth
//int EmployeeNumber
//enum CourseTaught { Cyber, Web Dev, Software Dev }

//Make an overloaded constructor and a constructor that takes just a int for EmployeeId