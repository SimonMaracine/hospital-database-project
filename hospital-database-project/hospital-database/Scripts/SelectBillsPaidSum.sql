USE [hospital-database-project-db]
GO
SELECT * FROM [dbo].[Doctors] 
WHERE sum > 100
    AND state = 'paid'
ORDER BY name ASC;
