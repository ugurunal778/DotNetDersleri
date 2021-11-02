---Isaretlemeler 
select * from  Customer 										  -- Customer tablosundan cek
select FirstName,LastName from  Customer 						  -- Customer tablosundan Firstname ve LastName sutununu sec
select * from  Customer where FirstName='Ercan'					  -- Customer tablosunda FirstName Ercan olanlari sec
select * from  Customer where LastName='Üstün' 					  -- Customer tablosunda LastName ustun olanlari sec
select * from  Customer where FirstName!='Ercan' 				  -- Customer tablosunda FirstName Ercan olmayanlari sec
select * from  Customer where FirstName<>'Ercan' 				  -- Customer tablosunda FirstName Ercan olmayanlari sec
select * from  Customer where BirthDate='1993-06-10 00:00:00.000' -- Tarih Eşittir
select * from  Customer where Id=5 								  -- Sayısal Değer Eşittir
select * from  Customer where BirthDate<'1989-04.09'			  -- Küçüktür 
select * from  Customer where BirthDate<='1989-04.09'			  -- Küçük Eşit
select * from  Customer where BirthDate>'1989-04.09' 			  -- Büyüktür
select * from  Customer where BirthDate>='1989-04.09' 			  -- Büyük Eşit

--Sıralama
select * from Customer order by FirstName						  --Customer tablosunda Firstname sutununu sirala
select * from Customer order by LastName desc ,FirstName desc	  --Customer tablosunda LastName ve FirstName sutununu azalana gore sirala
select * from Customer order by Id								  --id`ye gore sirala
select * from Customer order by Id desc							  --id`yi azalana gore sirala
select * from Customer order by CreatedOn desc					  --
select * from Customer order by CreatedOn						  --

--Update Ornekleri
update Customer							--Customer tablosunu update et
set BirthDate='1989-04-09 00:00:00.000'	--BirthDate sutununu '1989-04-09 00:00:00.000' olarak ayarla
where Id=1								--ID`si 1 olan satiri

--DoğumTarihi 1990-01-01 dan küçük olanların İsmi Kendi isminiz olsun.
update Customer					--Customer tablosunu update et
set FirstName='Ugur'			--FirstName ugur olarak degistir
where BirthDate<'1990-01-01'	--BirthDate '1990-01-01'`den kucuk olanlari

--İnsert Örnek
insert into Customer(FirstName,LastName,BirthDate,ModifiedOn,CreatedOn)	--Customer tablosunda su sutunlara ekleme yapilacak
values('Vincent','Aboubakar','1992-01-01',GETDATE(),GETDATE())			--`degerler` su sekilde olacak

insert into Customer(FirstName,LastName,BirthDate,ModifiedOn,CreatedOn)	--Customer tablosunda su sutunlara ekleme yapilacak
values('Cyle','Larin','1997-01-01',GETDATE(),GETDATE())					--`degerler` su sekilde olacak

--Delete Örnek
delete Customer	--Customer tablosunda sil
where Id >10	--Id`si 10`dan buyuk olani

--Eşleşen kayıtları getir
select * from Sales s							--Sales tablosunu s olarak al
inner join Customer fCust on s.FromId=fCust.Id	--Customer tablosunu al ve fcust olarak adlandir ardindan s`deki FromID ile fcust`daki Id`yi birlestir ve ortak paydayi al

-- Sol taraftaki tabloyu baz alara kbağla, Sales
select * from Sales s							--Sales tablosunu s olarak al
left join Customer fCust on s.FromId=fCust.Id	--Customer tablosunu al ve fcust olarak adlandir ardindan s`deki FromID ile fcust`daki ID`yi birlestir ve esitligin sol tarafini al

-- Sağ taraftaki tabloyu baz alarak bağla, Customer
select  * from Sales s							--Sales tablosunu s olarak al
right join Customer fCust on s.FromId=fCust.Id	--Customer tablosunu al ve fcust olarak adlandir ardindan s`deki FromID ile fcust`daki ID`yi birlestir ve esitligin sag tarafini al

-- tüm kesisim kümesini al
select  * from Sales s									--Sales tablosunu s olarak al
full outer join Customer fCust on s.FromId=fCust.Id		--Customer tablosunu al ve fcust olarak adlandir ardindan s`deki FromID ile fcust`daki ID`yi birlestir ve ortak paydada olmayan kismi al

--The Shawshank Redemption Filmi kaç kere yayınlanmıştır ?
select COUNT(*) CountOfTheaters from [dbo].[Theaters] th 	--Theaters tablosunu th olarak al, CountOfTheaters olarak say [where komutu ile baglaniyor]
inner join  [dbo].[Movies] mv  on th.MovieID= mv.MovieID   	--Movies tablosunu mv olarak al ardindan th`deki MovieID ile mv`deki MovieID`yi birlestir
where mv.Movie ='The Shawshank Redemption'					--mv`deki Movie sutunundaki 'The Shawshank Redemption' 

--Toplamda kaçtane film yayınlanmıştır ? 
select distinct Movie from [dbo].[Theaters] th 				--Theaters tablosunu th olarak al, farki Movie olarak ver
inner join  [dbo].[Movies] mv  on th.MovieID= mv.MovieID	--Movie tablosunu mv olarak al ve th`deki MovieID ile mv`deki MovieID`yi birlestir

-- Hangi Film Hangi Session da hangi salonda ve hangi haftada yayınlanmıştır?_
select mv.[Movie],sl.[Saloons],ss.[Sessions],wk.[Week] from [dbo].[Theaters] th	--Theaters tablosunu th olarak al, (mv`deki Movie, sl`deki Saloons, ss`deki Sessions, wk`deki Week)i sec
inner join [dbo].[Movies] mv on th.[MovieID] = mv.[MovieID] 					--Movies tablosunu mv olarak al ve th`deki MovieID ile mv`deki MovieID`yi birlestir
inner join [dbo].[Sessions] ss on th.[SessionID] = ss.[SessionID]				--Sessions tablosunu ss olarak al ve th`deki SessionsID ile ss`deki SessionsID`yi birlestir
inner join [dbo].[Saloons] sl on th.[SaloonID] = sl.[SaloonID]					--Saloons tablosunu sl olarak al ve th`deki SaloonID ile sl`deki SaloonID`yi birlestir
inner join [dbo].[Weeks] wk on th.[WeekID] = wk.[WeekID]						--Weeks tablosunu wk olarak al ve th`deki WeekID ile wk`deki WeekID`yi birlestir

