USE [hospital-database]
GO

SELECT 
    M.id AS MedicineID,
    M.name AS MedicineName,
    M.expiration_date AS ExpirationDate,
    M.provider AS Provider
FROM 
    [dbo].[Medicines] M
WHERE 
    M.expiration_date < GETDATE();