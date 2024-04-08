USE [hospital-database-project-db]
GO
SELECT * FROM [dbo].[Doctors] 
WHERE Age >= 30
    AND Gender = 'F'
ORDER BY employee_id ASC;