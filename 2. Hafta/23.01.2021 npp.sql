-- Id Update
update Movies			--Movies tablosunu update et
set MovieID=12			--MovieID`yi 12 olarak ayarla
where MovieID is null	--MovieID null olani belirle


-- Game of Thrones ekleme
-- Black Mirror Ekleme
insert into Movies(Movie,Description,Duration)values('Game Of Thrones','About Game Of Thrones',1000)	--Movies tablosuna ekle
insert into Movies(Movie,Description,Duration)values('Black Mirror','Black Mirror',1000)				--Movies tablosuna ekle
--12  Black Mirror 8 - Action, 7 Fantacy, 5 Sci-Fi,   4 Comedy,3 Adventure
--13  Game Of Thrones 8 Action, 7 Fantacy, 6 Animation, 5 Sci-Fi, 3 Adventure, 2 Drama


-- Balck Mirror Categories
insert into [dbo].[MoviesCategories]	--MoviesCategories tablosuna ekle
select 12,8								--Id`si 12 olan filme 8 nolu kategoriyi ekle
union all								--tablolardaki verileri birlestir
select 12,7								--Id`si 12 olan filme 7 nolu kategoriyi ekle
union all								--tablolardaki verileri birlestir
select 12,5								--Id`si 12 olan filme 5 nolu kategoriyi ekle
union all								--tablolardaki verileri birlestir
select 12,4								--Id`si 12 olan filme 4 nolu kategoriyi ekle
union all								--tablolardaki verileri birlestir
select 12,3								--Id`si 12 olan filme 3 nolu kategoriyi ekle
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


--bir film ekle kategorisi olmasin
insert into movies (movie, description, duration) values('inception', 'about inception', 145) --film kismina ekle(adi, aciklamasi, suresi)
select * from movies as m  																	  --movies tablosunu sec 'm' diye kisalt
left join MoviesCategories as mc on m.MovieID=mc.CategoryID									  --MoviesCategories tablosuna 'mc' de ve m`deki MovieID ile mc`deki CategoryID ekle
where mc.CategoryID	is null																	  --kategorisi olmasin


--kategorisi olmayan filmleri listele
select * from [dbo].[Movies] m										  --movies tablosunu sec
left join [dbo].[MoviesCategories] as mc on m.MovieID = mc.CategoryID --m`deki MovieID ile mc`deki CategoryID karsilastir esitligin solundaki kismi al
where mc.CategoryID is null 										  --mc`deki CategoryID bos olanlari al


--kac adet salon var
select count(0) from [dbo].[Saloons] --0`dan baslayarak Saloons tablosundaki tum satirlari say


--hangi film kac kere oynatilmistir
select Movie from Movies m 							--Movies tablosuna m adini ver ve Movie sutununu sec
left join [dbo].[Theaters] t on m.MovieID=t.MovieID --Theaters tablosuna t adini ver ve m`deki MovieID ile t`deki MovieID`yi karsilastir soldakini sec
order by Movie										--filmleri sirala


--2`den fazla olan filmleri getir
select * from (
				select Movie, count(0) NumberofTheatre from Movies m	--Movies tablosuna m adini ver ardindan Movie sutununu sec ve tara
				left join [dbo].[Theaters] t on m.MovieID=t.MovieID		--Theaters tablosuna t adini ver ve m`deki MovieID ile t`deki MovieID`yi karsilastir soldakini al
				group by movie											--Movie`ye gore grup yap
	
				union all												--iki tablodaki verileri de al
	
				select Movie, 0 from Movies m							--Movies tablosuna m adini ver, ardindan Movie sutununu sec 
				left join [dbo].[Theaters] t. on m.MovieID=t.MovieID	--Theaters tablosuna t adini ver ve m`deki MovieID ile t`deki MovieID`yi karsilastir soldakini al
				where t.MovieID is null									--t`deki MovieID null olanlari bul
				group by Movie											--Movie`ye gore grup yap
				)
as t 																	--bu kismi t olarak adlandir
where t.NumberofTheatre>2												--t islemindeki 2`den buyuk olan NumberofTheatre`lari yazdir


--3"den fazla gosterımı olan fılm
select Movie, count(0) NumberofTheatre from Movies m		--Movies tablosun m adini ver ardindan Movie sutununu sec ve tara 
left join [dbo].[Theaters] t on m.MovieID=t.MovieID			--Theaters tablosuna t adini ver ve m`deki MovieID ile t`deki MovieID`yi karsilastir ve soldakini al
group by Movie												--Movie sutununu grupla
having count(0)>3											--3`den buyuk olanlari listele


-- Ortalama Filmmler Kaç Dakikadır ? 
select AVG(Duration) from Movies							--movies tablosunu sec, Duration sutununun ortalamasini al


--5 kere gosterilmis filmler ortalama kac dk
select avg(Duration) from Movies where MovieID in (	--Movies tablosunda MovieID`yi al, kosulu gerceklestiren filmlerin ortalama Duration`larini al

	select m.MovieID from Movies m					--Movies tablosunu m olarak al ardindan MovieID sutununu sec
	inner join Theaters t on m.MovieID=t.MovieID	--Theaters tablosunu t olarak al ve m`deki MovieID ile t`deki MovieID`yi birlestir
	group by m.MovieID								--m`deki MovieID`yi grupla
	having count(0)=5								--5 olanlari al
)


--5 kere gosterilmis filmlerin en kisasi kac dk
select min(Duration) from Movies where MovieID in (	--Movies tablosunda MovieID`yi al, kosulu gerceklestiren filmlerin en kisa Duration olanini al

	select m.MovieID from Movies m					--Movies tablosunu m olarak al ardindan MovieID sutununu sec
	inner join Theaters t on m.MovieID=t.MovieID	--Theaters tablosunu t olarak al ve m`deki MovieID ile t`deki MovieID`yi birlestir
	group by m.MovieID								--m`deki MovieID`yi grupla
	having count (0)=5								--5 olanlari al
)


--5 kere gosterilmis filmlerin en kisasi kac dk
select STDEV (Duration) from Movies					--ustteki sorunu standart sapma ile cozumu


--hangi salonda kac tane film gosterilmistir
select s.Saloons, count(0) filmSayi from Saloons as s		--Saloons tablosuna s adini ver ardindan s`teki Sloons sutununu say ve filmSayi`ya ata
inner join [dbo].[Theaters] as t on s.SaloonsID=t.SaloonID	--Theaters tablosuna t adini ver ardindan s`teki SaloonID ve t`deki SaloonID`yi karsilastir soldakini al
group by s.Saloons											--s`deki Saloons sutununu grupla


--hangi salonda hangi haftada kac adet film gosterilmistir
select * from Saloons as s	--
select * from Weeks as w	--
select * from Theaters as t	--

[dbo].[Saloons]
[dbo].[Weeks]
[dbo].[Theaters]

select s.Saloons, w.Week, m.Movie, Count(0) GosterimSayi from Theaters as th
inner join [dbo].[saloons] s on s.SaloonId=th.SaloonId
inner join [dbo].[Weeks] w on w.WeekId=th.WeekId
inner join [dbo].[Movies] m on m.MovieId=th.movieId
group by s.Saloons, w.Week, m.Movie


--Hangi Haftada Hangi Film En fazla Oynamıştır.
select * from (															--

			select ROW_NUMBER() OVER (									--
				  PARTITION BY Week order by sayi desc					--
			   ) row_num,												--
			t.Movie,t.Week,sayi from (									--
			
					select Week,m.Movie,COUNT(0) sayi from Weeks as w	--Weeks tablosunu w olarak al,
					 inner join Theaters as t  on  w.WeekID=t.WeekID	--Theater tablosunu t olarak al ve w`deki WeekID ile t`deki WeekID`yi birlestir
					 inner join Movies as m  on  t.MovieID=m.MovieID	--Movies tablosunu m olarak al ve t`deki MovieID ile m`deki MovieID`yi birlestir
					 group by Week,m.Movie								--m`deki Movie sutununu week`e(haftaya) gore sirala

			 ) as t														--bu blogu t olarak al
 ) as t2																--bu blogu t2 olarak al
 where t2.row_num=1														--t2 blogundaki 1 numarali satira git
 
 
 --case / else kullanimi
select *,																					--
	case																					--
		when Duration<=50 then '50dkdan az gosterimi mevcut'								--suresi 50 ve alti ise '50dkdan az gosterimi mevcut'	ciktisini ver
		when Duration>50 and Duration<100 then '50 ile 100 dk arasi gosterimi mevcut'		--suresi 50 ile 100 arasinda ise '50 ile 100 dk arasi gosterimi mevcut' ciktisini ver
		when Duration>=100 and Duration<150 then '100 ile 150 dk arasi gosterimi mevcut'	--suresi 99 ile 150 arasinda ise '100 ile 150 dk arasi gosterimi mevcut' ciktisini ver
	else '150 dkdan daha yuksek gosterimi mevcut' 											--case fonksityonlarigerceklesmezse '150 dkdan daha yuksek gosterimi mevcut' ciktisini ver
	end DurationDescription,																--DurationDescription islemini sonlandir

	case 																					--
		when movie='The Shawshank Redemption' then 'guzel film'								--Movie 'the whawshank redemption' oldugunda guzel film yazdir
		when Movie like '%Back To The Future%' then 'seri filmidir'							--Movie 'back to the future' oldugunda seri filmidir yazdir
	else 'bilinmiyor' 																		--Case fonksityonlari gerceklesmezse 'bilinmiyor' ciktisini ver 
	end FilmYorumu,																			--Filmyorumunu sonlandir
	
	case 																					--
		when MovieID>5 then Duration*2														--MovieID 5`den buyuk ose sureyi 2 ile carp
		when MovieID<6 Duration/2															--MovieId 6`dan kucuk ise sureyi 2`ye bol
	end CalculatedDuration																	--CalculatedDuration islemini sonlandir
from Movies																					-- Movies tablosunu sec


-- Toplamda 10 dan fazla gösterime girmiş filmler için yoğun gösterim
-- Toplamda 5 ile 10 arasında gösterime girmiş filmler için normal gösterim
-- Toplamda 5 ten küçük gösterime girmiş filmler için düşük gösterim
select m.Movie,														--m`deki Movie sutununu sec
	count(0) NumberOfTheatres,										--NumberOfTheaters ile gosterim sayisini say
		case 														--
			when count(0)>=10 then 'Yogun Film'						--10 ve fazla gosterimdeki filmlere 'yogun gosterim' ciktisini ver
			when count(0)>=5 and count (0)<10 then'Normal Gosterim'	--10`dan az 4`den cok olan gosterimlere 'normal gosterim' ciktisini ver
			when count(0)<5 then 'Dusuk Gosterim'					--4 ve alti gosterimdeki filmmlere 'dusuk gosterim' ciktisini ver
		else ''														--case fonksiyonlari gerceklesmezse bos birak
		end DurationDescription										--DurationDescription islemini sonlandir
from Movies m														--Movies tablosunu m olarak al
inner join Theaters t on m.MovieID=t.MovieID						--Theaters tablosunu t olarak al ve m`deki MovieID ile t`deki MovieId birlestir
group by m.movie													--m`deki Movie`yi grupla