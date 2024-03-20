CREATE TABLE [dbo].[Treatments]
(
    [id] INT NOT NULL PRIMARY KEY,
    [name] CHAR(64) NOT NULL,
    [duration] INT NOT NULL,
    [medicine_id] INT NOT NULL
)
