CREATE VIEW [dbo].[ViewMedicinesSimplified] AS
SELECT
	M.name AS UtilizedMedicine,
    M.expiration_date AS UtilizedMedicineExpirationDate
FROM
	[dbo].[Medicines] M;
