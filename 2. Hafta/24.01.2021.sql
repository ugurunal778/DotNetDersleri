/*
bu calisma northwind database ile yapilmistir
*/
--hangi kategoriden kac tane urun vardir
select c.CategoryName, count(0) from Categories as c
inner join [dbo].[Products] p on c.CategoryID=p.CategoryID
group by c.CategoryName

--%10 indirim almis kac tane urun kategorisi vardir
select c.CategoryName from [dbo].[Order Details] od
inner join Products p on p.ProductID=od.ProductID
inner join Categories c on c.CategoryID=p.CategoryID
where Discount=0.1
group by c.CategoryName

--sipariste %15 yerine, %5 indirim verilseydi ne kadar karli satis olurdu
select OrderID, sum(CurrentValue - OrderForecastDiscountcost*Quantity) ForecastedSalesProfit
from (
	select OrderID, od.Quantity*p.UnitPrice CurrentValue,
	p.UnitPrice ProductUnitPrice,
	od.UnitPrice OrderUnitPrice,
	(od.UnitPrice/85)*100 OrderNonDiscountCost,
	(od.UnitPrice/85)*100*0.95 OrderForecastDiscountCost,
	od.Quantity

	from [Order Details] od
	inner join Products p on p.ProductID=od.ProductID
	where Discount=0.15
	) 
as t
group by t.OrderID

--degisken tanimlama
--sipariste %15 yerine, %5 indirim verilseydi ne kadar karli satis olurdu
declare @OrderDiscountParam as decimal=0.15
declare @OrderForecastDiscountParam as decimal=0.5

select OrderID, sum(CurrentValue - OrderForecastDiscountcost*Quantity) ForecastedSalesProfit
from (
	select OrderID, 
	od.Quantity,
	p.UnitPrice ProductUnitPrice,
	od.UnitPrice OrderUnitPrice,

	od.Quantity * p.UnitPrice CurrentValue,
	(od.UnitPrice/(1-@OrderDiscountParam))*100 OrderNonDiscountCost,
	(od.UnitPrice/(1-@OrderDiscountParam))*(1-@OrderForecastDiscountParam) OrderForecastDiscountCost

	from [Order Details] od
	inner join Products p on p.ProductID=od.ProductID
	where Discount=@OrderDiscountParam
	) 
as t
group by t.OrderID


--kendi ismi ve soyismini iceren yeni bir employee ekle
select * from [Northwind].[dbo].[Employees]
insert into [Northwind].[dbo].[Employees]
	(Lastname, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo Notes, PhotoPath)
values('Unal','Ugur','Technician','Mr','1996-02-25','2020-07.10','Tepeustu mah. Hayirli sk. no:14 Umraniye','Istanbul',null,null,'Turkey','05432723096',null,null,null,null)


--Dovolio Nancy EmployeeId 1 olan kaydin bilgilerini kendi user bilgilerinizle update et
update emp
set FirstName=em2.FirstName,LastName=em2.LastName,Title=em2.Title,BirthDate=em2.BirthDate,HireDate=em2.HireDate,Address=em2.Address,City=em2.City,Region=em2.Region,PostalCode=em2.PostalCode,Country=em2.Country,HomePhone=em2.HomePhone,Extension=em2.Extension,Notes=em2.Notes,ReportsTo=em2.ReportsTo
from [Employees] emp
join [Employees] em2 on em2.EmployeeID=10
where emp.EmployeeID=1


--yeni eklenen kaydi delete et
delete Employees where EmployeeID=10

 delete from [dbo].[Employees]
 where EmployeeID=10


--kendiniza bagli olan calisanlari listeleyen query
select * from [dbo].[Employees]
where ReportsTo=5			--altta calisan olmadigi icin bu sadece sayi vbermek amacli


--parametre olarak yoneticinin employeeid`sini alan ve ona bagli calisanlari listeleyen procedure yaz
crate proc spr_GetDirectReportsEmployeesByMenagerId
@employeeId int 
as 
begin


--nakliye firmalarinin toplamda kac siparisi vardir
select s.CompanyName, count(0) CountOfOrder from Orders o
inner join Shippers s on o.ShipVia=s.ShipperID
group by s.CompanyName
order by count(0) desc


--s1 birim fiyati en dusuk olan urun
select ProductName, min(UnitPrice) UnitPrice from Products 
group by ProductName
order by min(UnitPrice)


--s2 birim fiyati en yuksek olan urun
select ProductName, max(UnitPrice) UnitPrice from Products 
group by ProductName
order by max(UnitPrice) desc


--s3 toplam kac adet urun siparis edilmistir
select sum(Quantity) adetSayi from [Order Details]


--s4 10255 numarali siparisten elde edilecek tutar
select OrderID, sum(UnitPrice) from [Order Details] as od
group by OrderID
delete [Order Details] where OrderID!=10255


--s5 kac adet musteri var // siraladim toplamasini yapamadim
select distinct CustomerID from Customers

--s6 ortalama urun fiyat listeleyen sorgu
select avg(UnitPrice) from [Products]


--s7 R harfi ile baslayan urunlerin listesi
select *
from Products
where ProductName like 'R%'


--s8 urun adi cha ile baslayan ve 4 harften olusan urunlerin sorgusu
select *
from Products
where ProductName like '%cha%'


--s9 satici kimlik kodu 8 disinda olan tum saticilari listele
select * from Suppliers s
where SupplierID!=8


--s10 satici kimlik numarasi 8 ve 10 olan saticilardan alinan urunler arasindan fiyati 20tl ve uzeri olan urunler
--istenen alt tablo ve sutunlari olusturdu ancak urunleri listelemedi
select* from (
	select ProductName, count(0) HigherPrices from Products p
	left join [dbo].[Suppliers] s on p.ProductID=s.SupplierID
	group by ProductName

	union all

	select ProductName, count(0) from Products p
	left join [dbo].[Suppliers] s on p.ProductID=s.SupplierID
	where p.SupplierID = 8 or p.SupplierId = 10
	group by ProductName
)
as t
where t.HigherPrices>=20


--s11 satici kimlik kodu 8 veya 10 olan urunlerin sorgusu
select * from Products
where SupplierID=8 or SupplierID=10


--s12 fiyati 10 ve 20 tl arasinda olan urunleri listeleyen sorgu
select * from Products
where UnitPrice>10 and UnitPrice<20


--s13 satici numarasi 4 olan haric tum saticilardan alinan urunleri listeleyen sorgu


--s14 urunler tablosunu fiyata gore azalan sirada gosteren sorgu
select * from Products
order by UnitPrice desc


--s15 urunlerimize ait satici firma adi, urun adi ve fiyatini goruntuleyen sorgu
select s.CompanyName, ProductName, UnitPrice  from Products p
inner join Suppliers s on p.ProductID=s.SupplierID


--s16 9 numarali urunu siparis veren musterilere ait bilgileri listeleyen sorgu
select e.EmployeeID, e.Lastname, e.FirstName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Photo, e.Notes, e.PhotoPath  from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID=od.OrderID
inner join Employees e on e.EmployeeID=o.EmployeeID
where p.ProductID=9