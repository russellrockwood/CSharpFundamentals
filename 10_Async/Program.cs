using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();

            // Synchronously peel a potato 
            // Cant do other stuff while peeling a potato
            potato.Peel();


            // Asunchonously drop the fries
            // Async so i can do other things
            var fries = kitchen.FryPotatoesAsync(potato);

            // Synchronously assemble a burger while fries are cooking.
            var hamburger = kitchen.AssembleBurger();

            Console.WriteLine("Doing other stuff.");

            kitchen.ServeMeal(fries.Result, hamburger);

            Console.ReadKey();
        }
    }
}
