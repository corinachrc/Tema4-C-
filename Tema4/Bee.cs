using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public class Bee: Insect,IFlyingCreature
    {
        public Bee() { }
        
        public override void Fly()
        {
            Console.WriteLine("I am an insect. I can fly! (Insect fly)");
        }
        void IFlyingCreature.Fly()
        {
            Console.WriteLine("Of course I can fly (FlyingCreature fly)");
        }
        public new void DisplayDetails()
        {
            Console.WriteLine("My name is: " + Name + " and I am " + Age + " year(s) old (Bee Details)");
        }

    }
}
