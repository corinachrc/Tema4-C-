using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public class Eagle:Bird,IFlyingCreature,ICarnivore
    {
        
        public override void Sing()
        {
            Console.WriteLine("I whistle! (Eagle sing)");
        }
        public void Fly()
        {
            Console.WriteLine("I am an eagle. Of course I can fly!");
        }

        public void Yamy()
        {
            Console.WriteLine("I am an eagle. I eat medium size creatures.");
        }
        public override void Hello()
        {
                        Console.WriteLine("Eagle says Hello!");
        }
        public new void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name+" (Eagle Details)");
            Console.WriteLine("Age: " + Age + " (Eagle Details)");
            Console.WriteLine("Weight" + Weight + " (Eagle Details)");
        }
    }
}
