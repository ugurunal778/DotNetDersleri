namespace AdoNetSample
{
    public partial class DataLayerForDapper
    {
        private string GetProductsSupplierNameCategoryNameById_Query(int? productId)
        {
            var query = @"select ProductId,ProductName,CompanyName SupplierName,CategoryName from xfvkxruc_northwind.xfvkxruc_northwinduser.Products p
                        inner join xfvkxruc_northwind.xfvkxruc_northwinduser.Suppliers s on p.SupplierID = s.SupplierId
                        inner join  xfvkxruc_northwind.xfvkxruc_northwinduser.Categories c on c.CategoryId = p.CategoryId";

            if (productId.HasValue)
            {
                query += " where p.ProductId=" + productId.Value;
            }
            return query;
        }
        private string GetProductsUnitsInStockLessThanUnitsInOrder_Query()
        {
            var query = @"select ProductId,ProductName,UnitsInStock,UnitsOnOrder from Products where UnitsOnOrder>UnitsInStock";
            return query;
        }
        private string GetProcutsOrderByUnitPriceByTakeCount_Query(int takeCount)
        {
            var query = @"select top " + takeCount + "  ProductName,UnitPrice from Products order by UnitPrice desc";

            return query;
        }
        private string DeleteCategory_Query(int categoryId)
        {
            var query = "delete Categories where CategoryId=" + categoryId;
            return query;
        }
        private string ProcRun_Query()
        {
            var query = "exec spr_Northwind_InsertUpdateDelete";
            return query;
        }
        private string InsertCategory_Query(string categoryName, string categoryDesc)
        {

            var query = "insert into Categories select '" + categoryName + "','" + categoryDesc + "', null";
            return query;
        }
        private string UpdateCategory_Query(int categoryId, string categoryName, string categoryDesc)
        {
            var query = "update Categories set CategoryName= '" + categoryName + "',[Description]= '" + categoryDesc + "' where CategoryId=" + categoryId;
            return query;
        }
    }
}
