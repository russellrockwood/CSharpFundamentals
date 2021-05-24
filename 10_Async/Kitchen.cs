using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    public class Kitchen
    {
        public async Task<Fries> FryPotatoesAsync(Potato potato)
        {
            if (potato.IsPeeled)
            {
                PrettyPrint("Dropping in the fries.", 14);
                await Task.Delay(5000);
                PrettyPrint("Fries are frying", 14);
                await Task.Delay(5000);
                PrettyPrint("Fries done.", 14);
                return new Fries(potato);
            }
            else
            {
                Console.WriteLine("This potato ain't peeled");
                return null;
            }
        }

        public Hamburger AssembleBurger()
        {
            var time = 2000;
            PrettyPrint("Assembling Burger.", 13);
            PrettyPrint("Setting bun down", 4);
            Task.Delay(time).Wait();
            PrettyPrint("Set patty down", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Placing cheese", 6);
            Task.Delay(time).Wait();
            PrettyPrint("Lettuce being added", 10);
            Task.Delay(time).Wait();
            PrettyPrint("Putting down pickles", 2);
            Task.Delay(time).Wait();
            PrettyPrint("Adding sauce", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Top Bun", 4);
            Task.Delay(time).Wait();
            PrettyPrint("Burger Assembled", 13);
            return new Hamburger();
        }
        public bool ServeMeal(Fries fries, Hamburger hamburger)
        {
            if (fries == null)
            {
                Console.WriteLine("Fries are not ready");
                return false;
            }
            else
            {
                Console.WriteLine("You combined burger and fries and served a meal.");
                return true;
            }
        }
        public void PrettyPrint(string step, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(step);
            Console.ResetColor();
            //Black   0
            //DarkBlue    1
            //DarkGreen   2
            //DarkCyan    3
            //DarkRed 4
            //DarkMagenta 5
            //DarkYellow  6
            //Gray    7
            //DarkGray    8
            //Blue    9
            //Green   10
            //Cyan    11
            //Red 12
            //Magenta 13
            //Yellow  14
            //White   15

        }
    }
}
