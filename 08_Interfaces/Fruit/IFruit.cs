using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    // Naming convention for interfaces: I___
    public interface IFruit
    {
        string Name { get; }
        //Methods in interfaces
        // Can only set the return type, name, and parameters
        bool IsPeeled { get; }
        string Peel();
    }

    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }

        // Use the same interface method but bodies can be different as long as the return type matches.
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the orange.";
            }
        }

        // Classed that use interface can still have unique porperties and methods.
        public string Squeeze()
        {
            return "You squeezed the orange.";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get
            {
                return "Grape";
            }
        }
        // Hardsetting property as false
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "Who peels grapes?";
        }

    }

    // Make an Apple class inheriting from IFruit -challenge
    public class Apple : IFruit
    {
        //public string Name => "Apple";  -Lambda or 'phat arrow', accomplishes same as below.
        public string Name
        {
            get
            {
                return "Apple";
            }
        }
        // Hardsetting property as false
        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            if (IsPeeled)
            {
                return "I love peeled apples";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the apple";
            }
        }  
    }

}
