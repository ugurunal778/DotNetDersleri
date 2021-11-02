using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLayerForDapper dataLayerForDapper = new DataLayerForDapper();
            DataLayerForAdonet adonetSample = new DataLayerForAdonet();
            DataLayerForEntityFramework dataLayerForEntity = new DataLayerForEntityFramework();





            dataLayerForDapper.ProcRun();
        }
    }
}
