select*from Cars

--DBCC CHECKIDENT ('Cars', RESEED,0)

--delete from Cars where Id = 8

insert into Cars(ColorId,BrandId,ModelYear,DailyPrice,Descriptions) values (1,5,2018,90,'Dizel Manuel')