using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
public abstract class Insect:IAnimal
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set ; }

        public abstract void Fly();
        
        public void Bazzz() 
        {
            Console.WriteLine("I am buzzing! (Insect bazz)");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("My name is " + Name + " and I am a/an " + GetType().Name+ " (Insect Details)");
        }

        public void Hello()
        {
            Console.WriteLine("Insects say Hello!");
        }
    }
}
