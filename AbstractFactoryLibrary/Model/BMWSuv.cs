using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class BMWSuv:IBMW
    {
        public void Start()
        {
            Console.WriteLine("BMW Suv starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW Suv stopping");
        }
    }
}
