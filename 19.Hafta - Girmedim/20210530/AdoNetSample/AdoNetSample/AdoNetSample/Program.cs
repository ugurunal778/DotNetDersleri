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
            DataLayerForDapper dataLayerForDapper = new DataLayerForDapper();
            DataLayerForAdoNet adoNetSample = new DataLayerForAdoNet();
            DataLayerForEntityFramework dataLayerForEntity = new DataLayerForEntityFramework();

            //var adoNetResult = adoNetSample.GetProductsSupplierNameCategoryNameById(null);
            //var entityFrameworkResult = dataLayerForEntity.GetProductsSupplierNameCategoryNameById(null);
            //var dapperResult = dataLayerForDapper.GetProductsSupplierNameCategoryNameById(null);

            //var adoNetResult = adoNetSample.GetProductsUnitsInStockLessThanUnitsInOrder();
            //var entityFrameworkResult = dataLayerForEntity.GetProductsUnitsInStockLessThanUnitsInOrder();
            //var dapperResult = dataLayerForDapper.GetProductsUnitsInStockLessThanUnitsInOrder();


            //var adoNetResult = adoNetSample.GetProcutsOrderByUnitPriceByTakeCount(10);
            //var entityFrameworkResult = dataLayerForEntity.GetProcutsOrderByUnitPriceByTakeCount(10);
            //var dapperResult = dataLayerForDapper.GetProcutsOrderByUnitPriceByTakeCount(20);

            //dataLayerForDapper.InsertCategory("Ercan", "Ercan Desc");
            //dataLayerForDapper.UpdateCategory(12, "Serkan", "Civayel");
            //dataLayerForDapper.GetProductsSupplierNameCategoryNameById(null);

            dataLayerForDapper.ProcRun();

        }
    }
}
