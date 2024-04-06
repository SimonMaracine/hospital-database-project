USE [hospital-database-project-db]
GO
SELECT * FROM [dbo].[Bills] 
WHERE state = 'unpaid';