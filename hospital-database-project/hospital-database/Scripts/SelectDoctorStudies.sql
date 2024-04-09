USE [hospital-database]
GO

SELECT * FROM [dbo].[Doctors] 
WHERE studies IN ('College','Master Degree');
