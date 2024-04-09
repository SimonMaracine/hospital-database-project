USE [hospital-database]
GO

SELECT * FROM [dbo].[Bills] 
WHERE sum > 200;
