using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2
{
    class Bird : WingedCreature
    {
        public string Name { get; set; }

        public override void Describe()
        {
            
        }

        public Bird()
        {
            Console.WriteLine("Konstruktor klasy Bird");
        }
        public void CleanFeathers()
        {
            Console.WriteLine("Czyszcze swoje pióra");
        }

        virtual public void Fly()
        {
            Console.WriteLine("Latam");
        }
    }
}
