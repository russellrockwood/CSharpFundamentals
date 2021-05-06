using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public double GetSum(double num1, double num2)
        {
            double sumSolution = num1 + num2;
            return sumSolution;
        }

        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
            
        }
    }
}
