select * from [dbo].[Movies]
-- Black Mirror Ekleme
insert into Movies(Movie,Description,Duration)values('Black Mirror','About Black Mirror',120)

-- Id Update
update Movies
set MovieID=12
where MovieID is null

-- Black Mirror Ekleme
insert into Movies(Movie,Description,Duration)values('Game Of Thrones','About Game Of Thrones',1000)
insert into Movies(Movie,Description,Duration)values('Black Mirror','Black Mirror',1000)
--12  Black Mirror 8 - Action, 7 Fantacy, 5 Sci-Fi,   4 Comedy,3 Adventure
--13  Game Of Thrones 8 Action, 7 Fantacy, 6 Animation, 5 Sci-Fi, 3 Adventure, 2 Drama

-- Balck Mirror Categories
insert into [dbo].[MoviesCategories]
select 12,8
union all
select 12,7
union all
select 12,5
union all
select 12,4
union all
select 12,3
-- Game Of Thrones Categories
insert into [dbo].[MoviesCategories]
select 13,8
union all
select 13,7
union all
select 13,6
union all
select 13,5
union all
select 13,3
union all
select 13,2

-- Game Of Thrones Filminin Kategorileri nelerdir ?
select mv.Movie,ct.Categories from [dbo].[Movies] mv 
left join  [dbo].[MoviesCategories] mct on mv.MovieID = mct.MovieID
left join [dbo].[Categories] ct on mct.CategoryID = ct.CategoryID
where mct.MovieID=12

-- Bir film ekleyelim, 
-- filmin kategorisi olmasýn 
-- Kategorisi olmayan filmleri listeleyen query'i yazalým

--insert into Movies(Movie,Description,Duration)values('Titanic','About Titanic',1000)

--select * from [dbo].[Movies] m
--left join [dbo].[MoviesCategories] mc on m.MovieID=mc.MovieID
--where mc.MovieID is null

-- Kaç adet salonumuz mevcut
select COUNT(*) from [dbo].[Saloons]

-- Filmler kaç kere oynatýlmýþtýr ? 

select  Movie from Movies m
inner join  [dbo].[Theaters] t on m.MovieID=t.MovieID 
order by m.Movie

-- 2 den fazla gösterimi olan filmleri getir
select * from (

select  Movie,COUNT(0) NumberOfTheatre from Movies m
inner join  [dbo].[Theaters] t on m.MovieID=t.MovieID 
group by Movie

union all

select  Movie,0 from Movies m
left join  [dbo].[Theaters] t on m.MovieID=t.MovieID 
where t.MovieID is null
group by Movie

) as t
where t.NumberOfTheatre>2

-- 8 den fazla gösterimi olan filmleri getir
select  Movie,COUNT(0) NumberOfTheatre from Movies m
inner join  [dbo].[Theaters] t on m.MovieID=t.MovieID 
group by Movie
having COUNT(0)>8

-- Hangi Salonda kaçtane film gösterilmiþtir ?
-- Ortalama Filmmler Kaç Dakikadýr ? 
select AVG(Duration) from Movies

-- 5 kere gösterilmiþ filmlerin ortalama kaç dakika
select AVG(Duration) from Movies where MovieID in(
select m.MovieID from Movies m
inner join Theaters t on m.MovieID=t.MovieID
group by m.MovieID
having COUNT(0)=5)

-- 5 kere gösterilmiþ filmlerin en az kaç dakika
select min(Duration) from Movies where MovieID in(

select m.MovieID from Movies m
inner join Theaters t on m.MovieID=t.MovieID
group by m.MovieID
having COUNT(0)=5

)


select STDEV (Duration) from Movies




--Hangi Haftada Hangi Film En fazla Oynamýþtýr.

select * from (

			select ROW_NUMBER() OVER (
				  PARTITION BY Week     order by sayi desc
			   ) row_num,
			t.Movie,t.Week,sayi from (

					select Week,m.Movie,COUNT(0) sayi
					 from Weeks as w 
					  inner join Theaters as t  on  w.WeekID=t.WeekID
					 inner join Movies as m  on  t.MovieID=m.MovieID
					 group by Week,m.Movie

			 ) as t
 ) as t2
 where t2.row_num=1

 select *, 
case 
when Duration<=50 then '50 dk dan az gösterimi mevcuttur.' 
when Duration>50 and Duration<100 then '50 ile 100 dk arasý gösterimi mevcuttur.' 
when Duration>=100 and Duration<150 then '100 ile 150 dk arasý gösterimi mevcuttur.'  
else '150 dk dan daha yüksek gösterimi var' end DurationDescription,

case 
when Movie='The Shawshank Redemption' then 'Çok Kötü Film'
when Movie like '%Back to the Future%' then 'Seri Filmidir'
else 'Bilinmiyor' end FilmYorumu,

case 
when MovieID>5 then Duration*2
when MovieID<6 then Duration/2
end CalculatedDuration
from Movies

-- Toplamda 10 dan fazla gösterime girmiþ filmler için yoðun gösterim
-- Toplamda 5 ile 10 arasýnda gösterime girmiþ filmler için normal gösterim
-- Toplamda 5 ten küçük gösterime girmiþ filmler için düþük gösterim


select m.Movie,
COUNT(0) NumberOfTheaters,
case 
when COUNT(0)>=10 then 'Yoðun Flim' 
when count(0)>=5 and COUNT(0)<10 then 'Normal' 
when count(0)<5  then 'Düþük' 

else '' end DurationDescripon

from Movies m
inner join Theaters t on m.MovieID=t.MovieID

group by m.Movie

