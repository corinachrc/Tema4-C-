using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public interface IAnimal
    {
        double Weight { get; set; }
        int Age { get; set; }
        string Name { get; set; }

        void Hello();
        void DisplayDetails();

    }
}
