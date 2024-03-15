CREATE TABLE [dbo].[Doctors]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [first_name] VARCHAR(50) NOT NULL, 
    [last_name] VARCHAR(50) NOT NULL, 
    [age] INT NOT NULL, 
    [gender] INT NOT NULL, 
    [studies] VARCHAR(50) NOT NULL, 
    [specialization] VARCHAR(50) NOT NULL, 
    [partner_id] NCHAR(10) NOT NULL
)
