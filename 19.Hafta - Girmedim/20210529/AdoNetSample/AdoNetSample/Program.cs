using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLayerForAdoNet adoNetSample = new DataLayerForAdoNet();
            DataLayerForEntityFramework dataLayerForEntity = new DataLayerForEntityFramework();
            //var adoNetResult = adoNetSample.GetProductsSupplierNameCategoryNameById(null);
            //var entityFrameworkResult = dataLayerForEntity.GetProductsSupplierNameCategoryNameById(null);

            //var adoNetResult = adoNetSample.GetProductsUnitsInStockLessThanUnitsInOrder();
            //var entityFrameworkResult = dataLayerForEntity.GetProductsUnitsInStockLessThanUnitsInOrder();
            var adoNetResult = adoNetSample.GetProcutsOrderByUnitPriceByTakeCount(10);
            var entityFrameworkResult = dataLayerForEntity.GetProcutsOrderByUnitPriceByTakeCount(10);


        }
    }
}
