using _00_Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125394.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Make);
            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.LeftIndicator);
            Console.WriteLine(secondVehicle.RightIndicator);

        }

        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Ferrari";
            car.Mileage = 65000.4;
            car.Model = "Enzo";
            car.TypeOfVehicle = VehicleType.Car;
            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Starship", 100000, VehicleType.Plane);
            Console.WriteLine($"I rode a spaceship, it was the {rocket.Make}");

        }

        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Russell");

            List<string> students = new List<string>();
            students.Add("Russell");
            students.Add("Fred");
            students.Add("Bob");
            students.Add("Jill");

            foreach (string student in students)
            {
                greeterInstance.SayHello(student);
            }

            string greeting = greeterInstance.GetRandomGreeting();
            Console.WriteLine(greeting);
        }

        [TestMethod]
        public void CalculaterTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.GetSum(3.5, 100.9);
            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1990, 09, 09));

            Console.WriteLine(age);
        }

        [TestMethod]
        public void PersonTests()
        {
            Person person = new Person("Russell", "Rockwood", new DateTime(1990, 09, 09));
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.Age);

            // Empty constructors can be unhelpful: Missing Data


            // Single line instance of new'ing up a person.
            Person andrew = new Person()
            {
                FirstName = "Andrew",
                LastName = "Torr",
                DateOfBirth = new DateTime (1802, 11, 09)
            };
        }

        Person _person = new Person("Luke", "Skywalker", new DateTime(2000, 09, 21));
        [TestMethod]
        public void PersonTransportTest()
        {
            _person.Transport = new Vehicle("x-wing", "starship", 1000, VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make}");

            Person blank = new Person();
            Console.WriteLine($"Fullname: {blank.FullName}");
            Console.WriteLine($"Unset Class: {blank.Transport}");
            Console.WriteLine($"Unset Struct: {blank.DateOfBirth}");

        }

        [TestMethod]
        public void UserPropertiesTests()
        {
            User newUser = new User("Leo", "Tolstoy", 6, new DateTime(1805, 09, 09));
            Console.WriteLine(newUser.FirstName + " " +  newUser.LastName);
        }

        [TestMethod]
        public void UserMethodsTests()
        {
            User secondUser = new User("Fred", "Armiston", 3, new DateTime(1980, 09, 22));
            string secondUserFullName = secondUser.GetFullName();
            int secondUserAge = secondUser.GetUserAge();
            Console.WriteLine(secondUserFullName);
            Console.WriteLine($"{secondUser.FirstName} is {secondUserAge} years old.");

        }
    }
}
