
--Ürünlerin ismini kategorisini ve tedarikçisini gösteren query'yi yazalým.
select ProductName,CompanyName SupplierName,CategoryName from xfvkxruc_northwind.xfvkxruc_northwinduser.Products p
inner join xfvkxruc_northwind.xfvkxruc_northwinduser.Suppliers s on p.SupplierID=s.SupplierId
inner join  xfvkxruc_northwind.xfvkxruc_northwinduser.Categories c on c.CategoryId=p.CategoryId

--Write a query to get Product list (name, units on order , units in stock) of stock is less than the quantity on order

select ProductName,UnitsInStock,UnitsOnOrder from Products where UnitsOnOrder>UnitsInStock

--Write a query to get Product list (name, unit price) of ten most expensive products.
select top 10 ProductName,UnitPrice from Products order by UnitPrice desc


