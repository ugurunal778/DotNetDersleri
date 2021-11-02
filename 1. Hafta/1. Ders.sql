--Tanım Tabloları, Müşteri ve Araç
select * from [Sales Operation].[dbo].[Customer]	--sales operatıon db'sinden customer tablosunu getir
SELECT * FROM [Sales Operation].[dbo].[Vehicle]		--sales operation db`sinden vehicle tablosunu getir

-- Operasyon Tablosu
select * from [dbo].[Sales]	-- satis tablosunu getir


SELECT fromCustomer.FirstName,fromCustomer.LastName, fromCustomer.BirthDate, toCustomer.FirstName,toCustomer.LastName, toCustomer.BirthDate, vehicle.Marka,vehicle.Model,vehicle.[Model Yılı],vehicle.Renk,
vehicle.Şasi,[Sales].Cost,Sales.Discount 
from [Sales Operation].[dbo].[Sales] --sales operation db`sindeki sales tablosundan sadece belirtilen sutunlari getir

inner join [Sales Operation].[dbo].[Customer] fromCustomer on fromCustomer.Id=Sales.[FromId]	--customer tablosunu fromcustomer olarak al ardindan fromcustomerID ile salesID` birlestir ortak paydayi al
inner join [Sales Operation].[dbo].[Customer] toCustomer on toCustomer.Id= Sales.Told			--customer tablosunu toCustomer olarak al ardindan tocustomerID ile salesToId birlestir ortak paydayi al
inner join [Sales Operation].[dbo].[Vehicle] vehicle on Vehicle.Id = Sales.VehicleId			--vehicle tablosunu vehicle olarak al ardindan vehicleId ile salesVehicleId`yi birlestir ortak paydayi al