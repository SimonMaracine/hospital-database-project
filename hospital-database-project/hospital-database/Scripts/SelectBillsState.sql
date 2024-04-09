USE [hospital-database]
GO

SELECT * FROM [dbo].[Bills] 
WHERE state = 'unpaid';
