select * from  Customer 
select FirstName,LastName from  Customer 
select * from  Customer where FirstName='Ercan' -- E�ittir
select * from  Customer where LastName='�st�n' --E�ittir
select * from  Customer where FirstName!='Ercan' -- E�it De�ildir
select * from  Customer where FirstName<>'Ercan' -- E�it De�ildir
select * from  Customer where BirthDate='1993-06-10 00:00:00.000' -- Tarih E�ittir
select * from  Customer where Id=5 -- Say�sal De�er E�ittir
select * from  Customer where BirthDate<'1989-04.09' -- K���kt�r 
select * from  Customer where BirthDate<='1989-04.09'-- K���k E�it
select * from  Customer where BirthDate>'1989-04.09' -- B�y�kt�r
select * from  Customer where BirthDate>='1989-04.09' -- B�y�k E�it
--S�ralama
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

-- Do�umTarihi 1990-01-01 dan k���k olanlar�n �smi Kendi isminiz olsun.
update Customer
set FirstName='Tolga'
where BirthDate<'1990-01-01'

--�nsert �rnek
insert into Customer(FirstName,LastName,BirthDate,ModifiedOn,CreatedOn)
values('Vincent','Aboubakar','1992-01-01',GETDATE(),GETDATE())

insert into Customer(FirstName,LastName,BirthDate,ModifiedOn,CreatedOn)
values('Cyle','Larin','1997-01-01',GETDATE(),GETDATE())

--Delete �rnek
delete Customer
where Id >10

--inner join
--left join
--right join

--E�le�en kay�tlar� getir
select * from Sales s
inner join Customer fCust on s.FromId=fCust.Id

-- Sol taraftaki tabloyu baz alara kba�la, Sales
select * from Sales s
left join Customer fCust on s.FromId=fCust.Id

-- Sa� taraftaki tabloyu baz alarak ba�la, Customer
select  * from Sales s
right join Customer fCust on s.FromId=fCust.Id

-- t�m kesisim k�mesini al
select  * from Sales s
full outer join Customer fCust on s.FromId=fCust.Id


--The Shawshank Redemption Filmi ka� kere yay�nlanm��t�r ?
select COUNT(*) CountOfTheaters from [dbo].[Theaters] th 
inner join  [dbo].[Movies] mv  on th.MovieID= mv.MovieID   
where mv.Movie ='The Shawshank Redemption'

--Toplamda ka�tane film yay�nlanm��t�r ? 
select distinct Movie from [dbo].[Theaters] th 
inner join  [dbo].[Movies] mv  on th.MovieID= mv.MovieID   

-- Hangi Film Hangi Session da hangi salonda ve hangi haftada yay�nlanm��t�r?_
select mv.[Movie],sl.[Saloons],ss.[Sessions],wk.[Week] from [dbo].[Theaters] th 
inner join [dbo].[Movies] mv on th.[MovieID] = mv.[MovieID] 
inner join [dbo].[Sessions] ss on th.[SessionID] = ss.[SessionID]
inner join [dbo].[Saloons] sl on th.[SaloonID] = sl.[SaloonID]
inner join [dbo].[Weeks] wk on th.[WeekID] = wk.[WeekID]

