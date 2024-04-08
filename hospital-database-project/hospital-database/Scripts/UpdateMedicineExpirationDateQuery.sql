USE [hospital-database]
GO

DECLARE @MedicineID INT = 1
DECLARE @NewExpirationDate DATE = '2023-01-01'

UPDATE [dbo].[Medicines]
SET expiration_date = @NewExpirationDate
WHERE id = @MedicineID;
