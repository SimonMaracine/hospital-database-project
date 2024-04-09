USE [hospital-database]
GO

SELECT 
    M.id AS MedicineID,
    M.name AS MedicineName,
    M.provider AS Provider
FROM 
    [dbo].[Medicines] M
WHERE 
    M.provider IN (SELECT provider FROM [dbo].[Medicines] WHERE provider LIKE 'A%');
