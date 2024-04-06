USE [hospital-database-project-db]
GO
SELECT * FROM [dbo].[Doctors] 
WHERE studies IN ('College','Master Degree');