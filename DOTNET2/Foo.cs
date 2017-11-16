using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2
{
    class Foo
    {
        private int _count;

        public int Count
        {

            get
            {
                _count++;
                return _count; 
            }
            set { _count = value * 10; }
        }

    }
}
