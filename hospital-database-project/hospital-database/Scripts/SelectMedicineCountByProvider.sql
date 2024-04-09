USE [hospital-database]
GO

SELECT 
    M.provider AS Provider,
    COUNT(*) AS MedicineCount
FROM 
    [dbo].[Medicines] M
GROUP BY 
    M.provider;
