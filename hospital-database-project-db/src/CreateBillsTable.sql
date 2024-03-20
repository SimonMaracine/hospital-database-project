CREATE TABLE [dbo].[Bills]
(
    [id] INT NOT NULL PRIMARY KEY, 
    [name] CHAR(64) NOT NULL, 
    [sum] DECIMAL NOT NULL, 
    [state] CHAR(8) NOT NULL, 
    [patient_id] INT NOT NULL
)
