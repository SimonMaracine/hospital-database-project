CREATE TABLE [dbo].[Bills]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [name] CHAR(64) NOT NULL,
    [sum] DECIMAL NOT NULL,
    [state] CHAR(8) NOT NULL,
    [patient_id] INT NOT NULL,
    CONSTRAINT FK_bill_patient
    FOREIGN KEY (patient_id) REFERENCES Patients (id)
);
