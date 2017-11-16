using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            //phone1.SetProducer("Samsung");
            //Console.WriteLine("Nazwa producenta to " + phone1.GetProducer());

            phone1.Producer = "Samsung";
            Console.WriteLine(phone1.Producer);
            phone1.Model = "S6";

            Foo foo1 = new Foo();
            foo1.Count = 10;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(foo1.Count);

            }

            Chicken chick = new Chicken();

            chick.Fly();

            chick.Describe();

            





            Console.ReadKey();
        }
    }
}
