CREATE TABLE [dbo].[Medicines]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [name] CHAR(64) NOT NULL,
    [expiration_date] DATE NOT NULL,
    [provider] CHAR(64) NOT NULL
);
