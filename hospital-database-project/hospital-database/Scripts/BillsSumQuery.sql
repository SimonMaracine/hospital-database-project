USE [hospital-database-project-db]
GO
SELECT * FROM [dbo].[Bills] 
WHERE sum > 200;