using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public class Flea : Insect, ICarnivore
    {
        public override void Fly()
        {
            Console.WriteLine("I am a flea. Fleas fly!");
        }

        void ICarnivore.Yamy()
        {
            Console.WriteLine("I ingest blood");
        }
    }
}
