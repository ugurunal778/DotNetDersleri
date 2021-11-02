select * from  Customer 
select FirstName,LastName from  Customer 
select * from  Customer where FirstName='Ercan' -- Eþittir
select * from  Customer where LastName='Üstün' --Eþittir
select * from  Customer where FirstName!='Ercan' -- Eþit Deðildir
select * from  Customer where FirstName<>'Ercan' -- Eþit Deðildir
select * from  Customer where BirthDate='1993-06-10 00:00:00.000' -- Tarih Eþittir
select * from  Customer where Id=5 -- Sayýsal Deðer Eþittir
select * from  Customer where BirthDate<'1989-04.09' -- Küçüktür 
select * from  Customer where BirthDate<='1989-04.09'-- Küçük Eþit
select * from  Customer where BirthDate>'1989-04.09' -- Büyüktür
select * from  Customer where BirthDate>='1989-04.09' -- Büyük Eþit
--Sýralama
select * from Customer order by FirstName
select * from Customer order by LastName desc ,FirstName desc
select * from Customer order by Id
select * from Customer order by Id desc
select * from Customer order by CreatedOn desc
select * from Customer order by CreatedOn


--Update Samples
update Customer
set BirthDate='1989-04-09 00:00:00.000'
where Id=1

-- DoðumTarihi 1990-01-01 dan küçük olanlarýn Ýsmi Kendi isminiz olsun.
update Customer
set FirstName='Tolga'
where BirthDate<'1990-01-01'

--Ýnsert Örnek
insert into Customer(FirstName,LastName,BirthDate,ModifiedOn,CreatedOn)
values('Vincent','Aboubakar','1992-01-01',GETDATE(),GETDATE())

insert into Customer(FirstName,LastName,BirthDate,ModifiedOn,CreatedOn)
values('Cyle','Larin','1997-01-01',GETDATE(),GETDATE())

--Delete Örnek
delete Customer
where Id >10

--inner join
--left join
--right join

--Eþleþen kayýtlarý getir
select * from Sales s
inner join Customer fCust on s.FromId=fCust.Id

-- Sol taraftaki tabloyu baz alara kbaðla, Sales
select * from Sales s
left join Customer fCust on s.FromId=fCust.Id

-- Sað taraftaki tabloyu baz alarak baðla, Customer
select  * from Sales s
right join Customer fCust on s.FromId=fCust.Id

-- tüm kesisim kümesini al
select  * from Sales s
full outer join Customer fCust on s.FromId=fCust.Id


--The Shawshank Redemption Filmi kaç kere yayýnlanmýþtýr ?
select COUNT(*) CountOfTheaters from [dbo].[Theaters] th 
inner join  [dbo].[Movies] mv  on th.MovieID= mv.MovieID   
where mv.Movie ='The Shawshank Redemption'

--Toplamda kaçtane film yayýnlanmýþtýr ? 
select distinct Movie from [dbo].[Theaters] th 
inner join  [dbo].[Movies] mv  on th.MovieID= mv.MovieID   

-- Hangi Film Hangi Session da hangi salonda ve hangi haftada yayýnlanmýþtýr?_
select mv.[Movie],sl.[Saloons],ss.[Sessions],wk.[Week] from [dbo].[Theaters] th 
inner join [dbo].[Movies] mv on th.[MovieID] = mv.[MovieID] 
inner join [dbo].[Sessions] ss on th.[SessionID] = ss.[SessionID]
inner join [dbo].[Saloons] sl on th.[SaloonID] = sl.[SaloonID]
inner join [dbo].[Weeks] wk on th.[WeekID] = wk.[WeekID]

