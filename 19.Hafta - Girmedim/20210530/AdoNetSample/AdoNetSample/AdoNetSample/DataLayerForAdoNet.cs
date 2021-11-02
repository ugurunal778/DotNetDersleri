using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetSample
{
    public class DataLayerForAdoNet
    {
        public List<ProductDto> GetProductsSupplierNameCategoryNameById(int? productId)
        {
            var query = @"select ProductId,ProductName,CompanyName SupplierName,CategoryName from xfvkxruc_northwind.xfvkxruc_northwinduser.Products p
                        inner join xfvkxruc_northwind.xfvkxruc_northwinduser.Suppliers s on p.SupplierID = s.SupplierId
                        inner join  xfvkxruc_northwind.xfvkxruc_northwinduser.Categories c on c.CategoryId = p.CategoryId";

            if (productId.HasValue)
            {
                query += " where p.ProductId=" + productId.Value;
            }

            SqlDataAdapter dap = new SqlDataAdapter(query, "Server =mssql.anaxanet.com;Database=xfvkxruc_northwind;UID=xfvkxruc_NorthwindUser;PWD=123Pass");
            DataTable dt2 = new DataTable();
            dap.Fill(dt2);

            if (dt2 == null)
            {
                return null;
            }
            List<ProductDto> data = new List<ProductDto>();
            foreach (DataRow item in dt2.Rows)
            {
                ProductDto dto = new ProductDto();
                dto.UnitPrice = Convert.ToInt32(item["ProductId"].ToString());
                dto.ProductName = item["ProductName"].ToString();
                dto.SupplierName = item["SupplierName"].ToString();
                dto.CategoryName = item["CategoryName"].ToString();
                data.Add(dto);
            }
            return data;



        }
        public List<ProductDto> GetProductsUnitsInStockLessThanUnitsInOrder()
        {
            var query = @"select ProductId,ProductName,UnitsInStock,UnitsOnOrder from Products where UnitsOnOrder>UnitsInStock";

            SqlDataAdapter dap = new SqlDataAdapter(query, "Server =mssql.anaxanet.com;Database=xfvkxruc_northwind;UID=xfvkxruc_NorthwindUser;PWD=123Pass");
            DataTable dt2 = new DataTable();
            dap.Fill(dt2);

            if (dt2 == null)
            {
                return null;
            }
            List<ProductDto> data = new List<ProductDto>();
            foreach (DataRow item in dt2.Rows)
            {
                ProductDto dto = new ProductDto();
                dto.UnitPrice = Convert.ToInt32(item["ProductId"].ToString());
                dto.ProductName = item["ProductName"].ToString();
                dto.UnitsInStock = Convert.ToInt32(item["UnitsInStock"].ToString());
                dto.UnitsInOrder = Convert.ToInt32(item["UnitsOnOrder"].ToString());
                data.Add(dto);
            }
            return data;

        }
        public List<ProductDto> GetProcutsOrderByUnitPriceByTakeCount(int takeCount)
        {
            var query = @"select top " + takeCount + "  ProductName,UnitPrice from Products order by UnitPrice desc";

            SqlDataAdapter dap = new SqlDataAdapter(query, "Server =mssql.anaxanet.com;Database=xfvkxruc_northwind;UID=xfvkxruc_NorthwindUser;PWD=123Pass");
            DataTable dt2 = new DataTable();
            dap.Fill(dt2);

            if (dt2 == null)
            {
                return null;
            }
            List<ProductDto> data = new List<ProductDto>();
            foreach (DataRow item in dt2.Rows)
            {
                ProductDto dto = new ProductDto();
                dto.UnitPrice = Convert.ToDecimal(item["UnitPrice"].ToString());
                dto.ProductName = item["ProductName"].ToString();

                data.Add(dto);
            }
            return data;
        }

      
    }
}
