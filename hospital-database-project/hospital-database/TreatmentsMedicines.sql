CREATE TABLE [dbo].[TreatmentsMedicines]
(
	[treatment_id] INT NOT NULL,
    [medicine_id] INT NOT NULL,
    [medicine_dosage] CHAR(64) NOT NULL,
    [description] CHAR(128) NOT NULL,
    CONSTRAINT PK_treatment_medicine PRIMARY KEY (treatment_id, medicine_id),
    CONSTRAINT FK_medicine_treatment
    FOREIGN KEY (treatment_id) REFERENCES Treatments (id),
    CONSTRAINT FK_treatment_medicine
    FOREIGN KEY (medicine_id) REFERENCES Medicines (id)
);
