USE [hospital-database]
GO

SELECT * FROM [dbo].[Doctors] 
WHERE specialization IN ('Surgery','Plastic Surgery');
