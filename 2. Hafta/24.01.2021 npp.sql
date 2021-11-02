/*
Bu calisma northwind database ile yapilmistir
*/


--hangi kategoriden kac tane urun vardir
select c.CategoryName, 										--c`deki CategoryName`i sec
count(0) 													--saydirma islemini yap
from Categories as c										--Categories tablosunu c olarak al
inner join [dbo].[Products] p on c.CategoryID=p.CategoryID	--Products tablosunu p olarak al ve c`deki CategoryID ile p`deki CategoryID`yi birlestir
group by c.CategoryName										--c`deki CategoryName`i grupla


--%10 indirim almis kac tane urun kategorisi vardir
select c.CategoryName from [dbo].[Order Details] od		--Order Details tablosunu od olarak al ve c`deki CategoryName`i sec
inner join Products p on p.ProductID=od.ProductID		--Products tablosunu p olarak al ve p`deki ProductID ile od`deki ProductID`yi birlestir
inner join Categories c on c.CategoryID=p.CategoryID	--Categories tablosunu c olarak al ve c`deki CategoryID ile p`deki CategoryID`yi birlestir
where Discount=0.1										--Discount sutunundaki %10 indirimi bul
group by c.CategoryName									--c`deki categoryName`i gruplandir


--sipariste %15 yerine %5 indirim verilseydi ne kadar karli satis olurdu
select OrderID, sum(CurrentValue - OrderForecastDiscountCost * Quantity) ForecastedSalesProfit	--OrderID`yi sec ve islemini yapip ForecastedSalesProfit olarak adlandir
from (																						--
	select OrderID, od.Quantity*p.UnitPrice CurrentValue,									--OrderID`yi sec ve od.Quantity ile p.UnitPrice`i carp ve CurrentValue olarak adlandir
	p.UnitPrice ProductUnitPrice,															--p.UnitPrice`i ProductUnitPrice olarak adlandir
	od.UnitPrice OrderUnitPrice,															--od.UnitPrice`i OrderUnitPrice olarak adlandir
	(od.UnitPrice/85)*100 OrderNonDiscountCost,												--islemini OrderNonDiscountCost olarak adlandir
	(od.UnitPrice/85)*100*0.95 OrderForecastDiscountCost,									--islemini OrderForecastDiscountCost olarak adlandir
	od.Quantity																				--

	from [Order Details] od																	--Order Details tablosunu od olarak al
	inner join Products p on p.ProductID=od.ProductID										--Products tablosunup olarak al ve p`deki ProductID ile od`deki ProductID`yi birlestir
	where Discount=0.15																		--Discount %15 olan yerde islem yap
) as t																						--bu blogu t olarak al
group by t.OrderId																			--t`deki OrderId`ye gore grupla


--yukaridaki islemi degisken tanimlayarak yapmak
declare @OrderDiscountParam as decimal=0.15																	--OrderDiscountParam degiskenini decimal olarak %15 olarak al
declare @OrderForecastDiscountParam as decimal=0.5															--OrderForecastDiscountParam degiskenini decimal olarak %5 olarak al

select OrderID, sum (CurrentValue - OrderForecastDiscountCost * Quantity) ForecastedSalesProfit				--OrderId`yi sec ve sum islemini ForecastedSalesProfitolarak adlandir
from (																										--
	select OrderID,																							--OrderID`yi sec
	od.Quantity,																							--od.Quantity`yi sec
	p.UnitPrice ProductionUnitPrice,																		--p.UnitPrice`i sec ve ProductionUnitPrice olarak adlandir
	od.UnitPrice OrderUnitPrice,																			--od.unitPrice`i sec ve OrderUnitPrice olarak adlandir

	od.Quantity * p.UnitPrice CurrentValue,																	--od.Quantity ile p.UnitPrice`i carpma islemini CurrentValue oalrak adlandir`
	(od.UnitPrice / (1 - @OrderDiscountParam)) * 100 OrderNonDiscountCost,									--islemini OrderNonDiscountCost olarak adlandir
	(od.UnitPrice / (1 - @OrderDiscountParam)) * (1 - OrderForecastDiscountParam) OrderForecastDiscountCost	--islemini OrderForecastDiscountCost olarak adlandir

	from [Order Details] od																					--yukaridaki islemlerini Order Details tablosunu od olarak adlandirarak onun uzerinde yap
	inner join Products p on p.ProductID=od.ProductID														--Products tablosunu p olarak adlandir ve p`deki ProductID ile od`deki ProductID`yi birlestir
	where Discount=@OrderDiscountParam																		--Discount %15 olan yerde islem yap
) as t																										--Yukaridaki blogu t olarak al
group by t.OrderID																							--t`deki OrderId`ye gore grupla


--kendi ismi ve soyismini iceren yeni bir employee ekle
select * from [Northwind].[dbo].[Employees]
insert into [Northwind].[dbo].[Employees]
		(Lastname, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo Notes, PhotoPath)
values('Unal','Ugur','Technician','Mr','1996-02-25','2020-07.10','Tepeustu mah. Hayirli sk. no:14 Umraniye','Istanbul',null,null,'Turkey','05432723096',null,null,null,null)



--Dovolio Nancy EmployeeId 1 olan kaydin bilgilerini kendi user bilgilerinizle update et //bilgilerin tamami asagidaki ornek gibi degistirilmelidir
update emp																										--emp `yi update et
set Firstname=em2.FirstName, LatName=em2.LastName,Title=em2.Title,BirthDate=em2.BirthDate,HireDate=em2.HireDate	--emp`deki satirdaki belirtilen sutunu em2`deki belirtilen satir ve sutun ile degistir
from [Employees] emp																							--Employees tablosunu emp olarak al
join [Employees] em2 on em2.EmployeeId=10																		--Employees tablosundaki
where emp.EmployeeId=1																							--emp`deki EmployeeId=1 olana


--yeni eklenen kaydi delete et
delete Employees where EmployeeID=10	--Employees tablosunda EmployeeID 10 olan satiri sil

 delete from [dbo].[Employees]			-- employees tablosunda
 where EmployeeID=10					--EmployeeID 10 olani sil


--kendiniza bagli olan calisanlari listeleyen query
select * from [dbo].[Employees]	--Employees tablosunda
where ReportsTo=5				--ReportsTo 5 olan hucre // altta calisan olmadigi icin bu sadece sayi vbermek amacli


--parametre olarak yoneticinin employeeid`sini alan ve ona bagli calisanlari listeleyen procedure yaz
crate proc spr_GetDirectReportsEmployeesByMenagerId
@employeeId int
as
begin

select

--nakliye firmalarinin toplamda kac siparisi vardir
select s.CompanyName, count(0) CountOfOrder from Orders o	--s`deki CompanyName`i sec, Orders tablosunu o olarak adlandir ve say
inner join Shippers s on o.ShipVia=s.ShipperID				--shippers tablosunu s olarak al ve o`daki ShipVia ile s`deki ShipperID`yi birlestir
group by s.CompanyName										--s`teki CompanyName`e gore sirala
order by count(0) desc										--sayim sonucunu azalana gore sirala


--s1 birim fiyati en dusuk olan urun
select ProductName, min(UnitPrice) UnitPrice from Products
group by ProductName
order by min(UnitPrice)
--
select top 1 * from Products order by UnitPrice


--s2 birim fiyati en yuksek olan urun
select ProductName, max(UnitPrice) UnitPrice from Products
group by ProductName
order by max(UnitPrice) desc
--
select top 1 * from Products order by UnitPrice desc


--s3 toplam kac adet urun siparis edilmistir
select sum(Quantity) adetSayi from [Order Details]


--s4 10255 numarali siparisten elde edilecek tutar
select OrderID, sum(UnitPrice) from [Order Details] as od
group by OrderID
delete [Order Details] where OrderID!=10255


--s5 kac adet musteri var
--siraladim toplamasini yapamadim
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
/*
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
*/


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
