using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseType { CyberSecurity, SoftwareDev, WevDev}
    public enum BadgeType { White, Gold, Red }
    public class Student
    {
        public Student(string firstName, string lastname, DateTime dateOfBirth,
            CourseType classTaking, decimal balanceOwed, BadgeType typeOfBadge, bool hasGraduated) 
        {
            FirstName = firstName;
            LastName = lastname;
            DateOfBirth = dateOfBirth;
            ClassTaking = classTaking;
            BalanceOwed = balanceOwed;
            TypeOfBadge = typeOfBadge;
            HasGraduated = hasGraduated;
        }

        public Student() { }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public CourseType ClassTaking { get; set; }

        public decimal BalanceOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }
    }
}


//Create two classes.

//First make a Student class that has the properties of 

//string FirstName
//string LastName
//DateTime dateOfBirth
//CourseType classTaking (enum of CourseType
//{ Cyber Security, Software Development, Web Development}
//decimal BalancedOwed
//BadgeType TypeOfBadge
//bool HasGraduated

//Make an empty and overloaded constructor.

