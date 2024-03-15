CREATE TABLE [dbo].[Treatments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NOT NULL, 
    [duration] INT NOT NULL, 
    [medicine_id] INT NOT NULL
)
