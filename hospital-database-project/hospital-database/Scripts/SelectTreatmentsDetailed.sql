USE [hospital-database]
GO

SELECT 
    T.name as TreatmentName,
    T.duration TreatmentDuration,
    M.name AS UtilizedMedicine,
    M.expiration_date AS UtilizedMedicineExpirationDate,
    M.provider AS Provider,
    TM.medicine_dosage AS MedicineDosage,
    TM.description AS Description
FROM 
    [dbo].[Treatments] T
INNER JOIN 
    [dbo].[TreatmentsMedicines] TM ON T.id = TM.treatment_id
INNER JOIN 
    [dbo].[Medicines] M ON TM.medicine_id = M.id
