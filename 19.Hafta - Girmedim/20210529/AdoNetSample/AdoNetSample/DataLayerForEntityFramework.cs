using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSample
{
    public class DataLayerForEntityFramework
    {
        readonly xfvkxruc_northwindEntities entities = new xfvkxruc_northwindEntities();
        public List<ProductDto> GetProductsSupplierNameCategoryNameById(int? id)
        {
            List<ProductDto> result;

            var query = (from p in entities.Products
                         join c in entities.Categories on p.CategoryID equals c.CategoryID
                         join s in entities.Suppliers on p.SupplierID equals s.SupplierID
                         select new ProductDto()
                         {
                             UnitPrice = p.ProductID,
                             CategoryName = c.CategoryName,
                             ProductName = p.ProductName,
                             SupplierName = s.CompanyName
                         });

            if (id.HasValue)
            {
                result = query.Where(x => x.UnitPrice == id.Value).ToList();
            }
            else
            {
                result = query.ToList();
            }
            return result;

        }
        public List<ProductDto> GetProductsUnitsInStockLessThanUnitsInOrder()
        {
            //var result = (from p in entities.Products
            //              where p.UnitsOnOrder > p.UnitsInStock
            //              select new ProductDto()
            //              {
            //                  UnitPrice = p.ProductID,
            //                  UnitsInStock = (int)p.UnitsInStock,
            //                  UnitsInOrder = (int)p.UnitsOnOrder
            //              }).ToList();

            var result = entities.Products.Where(x => x.UnitsInStock > x.UnitsOnOrder)
                .Select(x => new ProductDto()
                {
                    UnitPrice = x.UnitPrice,
                    UnitsInOrder = (int)x.UnitsOnOrder,
                    ProductId = x.ProductID
                }).ToList();
            return result;
        }
        public List<ProductDto> GetProcutsOrderByUnitPriceByTakeCount(int takeCount)
        {
            var result = (from p in entities.Products
                          orderby p.UnitPrice descending
                          select new ProductDto()
                          {
                              UnitPrice = p.UnitPrice,
                              ProductName = p.ProductName

                          }).Take(takeCount).ToList();
            return result;
        }
    }
}
