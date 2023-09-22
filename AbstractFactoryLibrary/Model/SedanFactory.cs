using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class SedanFactory:IAutoFactory
    {
        public ITesla CreateTesla()
        {
            return new TeslaSedan();
        }

        public IBMW CreateBMW()
        {
            return new BMWSedan();
        }

        public IAudi CreateAudi()
        {
            return new AudiSedan();
        }
    }
}
