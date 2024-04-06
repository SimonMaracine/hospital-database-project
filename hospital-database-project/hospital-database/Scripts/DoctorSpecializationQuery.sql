USE [hospital-database-project-db]
GO
SELECT * FROM [dbo].[Doctors] 
WHERE specialization IN ('Surgery','Plastic Surgery');