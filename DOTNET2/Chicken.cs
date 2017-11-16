using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2
{
    class Chicken:Bird
    {
        

        public void GiveMeEgg()
        {
            Console.WriteLine("Masz jajko.");
        }

        override public void Fly()
        {
            Console.WriteLine("Nie potrafie latać.");
        }

        public override void Describe()
        {
            Console.WriteLine("jestem gołębiem.");

        }
    }
}
