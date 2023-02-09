using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public abstract class Bird:IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public abstract void Sing();
        public virtual void Hello() 
        {
            Console.WriteLine("Bird says Hello");
        }
        public void DisplayDetails() 
        { 
            Console.WriteLine("I am a/an: "+GetType().Name+ " (Bird details)");
        }

    }
}
