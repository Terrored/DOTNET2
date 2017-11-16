using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2
{
    class Phone
    {
        private string _producer;

        public string Producer
        {
            get
            {
                Console.WriteLine("Pobieram zawar.");
                return _producer;
            }
            set
            {
                Console.WriteLine("Ustawiam zawar.");
                _producer = value;
            }
        }

        public string Model { get; set; }





        public Phone()
        {
            
        }
        public Phone(string producer)
        {
            _producer = producer;
        }

        public void SetProducer(string producer)
        {
            _producer = producer;
            Model = "xd";
        }

        public string GetProducer()
        {
            return _producer;
        }
    }
}
