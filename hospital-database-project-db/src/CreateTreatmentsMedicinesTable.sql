CREATE TABLE [dbo].[TreatmentsMedicines]
(
	[treatment_id] INT NOT NULL PRIMARY KEY,
    [medicine_id] INT NOT NULL PRIMARY KEY,
    [medicine_dosage] CHAR(64) NOT NULL,
    [description] CHAR(128) NOT NULL
)
