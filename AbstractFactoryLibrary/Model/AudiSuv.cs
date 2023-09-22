using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class AudiSuv:IAudi
    {
        public void Start()
        {
            Console.WriteLine("Audi Suv starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Suv stopping");
        }
    }
}
