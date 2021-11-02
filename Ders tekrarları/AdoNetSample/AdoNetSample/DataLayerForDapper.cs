using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSample
{
    public partial class DataLayerForDapper : BaseRepository
    {
        public List<ProductDto> GetProductSupplierNameCategoryNameById(int? productId)
        {
            List<ProductDto> data = new List<ProductDto>();
            using (IDbConnection db = new SqlConnection(Connection))
            {
                var query = GetProductsSupplierNameCategoryNameById_Query(productId);
                data = db.Query<ProductDto>(query).ToList();
            }
            return data;
        }
        public List<ProductDto> GetProductsUnitsInStockLessThanUnitsInOrder()
        {
            List<ProductDto> data = new List<ProductDto>();
            var query = GetProductsUnitsInStockLessThanUnitsInOrder_Query();
            using (IDbConnection db = new SqlConnection(Connection))
            {
                data = db.Query<ProductDto>(query).ToList();
            }
            return data;
        }
        public List<ProductDto> GetProductsOrderByUnitPriceByTakeCount(int takeCount)
        {
            List<ProductDto> data = new List<ProductDto>();
            var query = GetProcutsOrderByUnitPriceByTakeCount_Query(takeCount);
            using (IDbConnection db = new SqlConnection(Connection))
            {
                data = db.Query<ProductDto>(query).ToList();
            }
            return data;
        }
        public bool InsertCategory(string categoryName, string categoryDesc)
        {
            var query = InsertCategory_Query(categoryName, categoryDesc);
            using (IDbConnection db = new SqlConnection(Connection))
            {
                db.Execute(query);
            }
            return true;
        }
        public bool UpdateCategory(int categoryId, string categoryName, string categooryDesc)
        {
            var query = UpdateCategory_Query(categoryId, categoryName, categooryDesc);
            using (IDbConnection db = new SqlConnection(Connection))
            {
                db.Execute(query);
            }
            return true;
        }
        public bool DEleteCategory (int categoryID)
        {
            var query = DeleteCategory_Query(categoryID);
            using (IDbConnection db = new SqlConnection(Connection))
            {
                db.Execute(query);
            }
            return true;
        }
        public List<Categories> ProcRun()
        {
            List<Categories> result = new List<Categories>();
            var query = ProcRun_Query();
            using (IDbConnection db = new SqlConnection(Connection))
            {
                result = db.Query<Categories>(query).ToList();
            }
            return result;
        }
    }
}