using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
  public class SUVFactory:IAutoFactory
    {
        public ITesla CreateTesla()
        {
            return new TeslaSuv();
        }

        public IBMW CreateBMW()
        {
            return new BMWSuv();
        }

        public IAudi CreateAudi()
        {
            return new AudiSuv();
        }
    }
}
