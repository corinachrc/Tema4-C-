using System;

namespace Tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Ostrich ostrich1=new Ostrich();
            ostrich1.Age = 1;
            ostrich1.Weight = 1;
            ostrich1.Name = "Ostrich1";
            

            Eagle eagle1= new Eagle();
            eagle1.Name = "Eagle1";
            eagle1.Age= 1;
            eagle1.Weight = 1;

            Bee bee1=new Bee();
            bee1.Name = "Bee1";
            bee1.Age= 1;
            bee1.Weight = 0.01;

            Flea flea1= new Flea();
            flea1.Name = "Flea1";
            flea1.Age= 1;
            flea1.Weight = 0.0001;


            ostrich1.DisplayDetails();
            ((Bird)ostrich1).DisplayDetails();// declarata cu "new"
            ostrich1.Sing();
            ((Bird)ostrich1).Sing();//declarata cu "abstract-override" - 
            ostrich1.Hello();
            ((Bird)ostrich1).Hello();//declarata cu "virtual-override" - 
            Console.WriteLine("==========================");
            Console.WriteLine();

            eagle1.DisplayDetails();
            ((Bird)eagle1).DisplayDetails();
            eagle1.Sing();
            ((Bird)eagle1).Sing();//declarata cu "abstract-override" - 
            eagle1.Hello();
            ((Bird)eagle1).Hello();//declarata cu "virtual-override" - 
            eagle1.Fly();
            Console.WriteLine("==========================");
            Console.WriteLine();

            bee1.DisplayDetails();
            ((Insect)bee1).DisplayDetails();
            ((IFlyingCreature)bee1).DisplayDetails();
            bee1.Fly();
            ((IFlyingCreature)bee1).Fly();           
            bee1.Hello();
            bee1.Bazzz();
            Console.WriteLine("==========================");
            Console.WriteLine();


            flea1.DisplayDetails();

            flea1.Bazzz();
            flea1.Fly();
            





        }
    }
}
