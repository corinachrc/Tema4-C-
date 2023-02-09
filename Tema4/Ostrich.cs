using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public class Ostrich:Bird
    {
        
        public Ostrich() { }

        public override void Sing()
        {
            Console.WriteLine("I can honk and I can chirp!! (Ostrich sing)");
        }
        public override void Hello()
        {
            
            Console.WriteLine("Ostrich says hello!");
        }
        public new void DisplayDetails()
        {
            Console.WriteLine("My name is: " + Name+" (Ostrich details)");
            Console.WriteLine("I am " + Age+ " old (Ostrich details)");
            Console.WriteLine("I have " + Weight+ " kg (Ostrich details)");
        }
    }
}
