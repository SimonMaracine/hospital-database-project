CREATE TABLE [dbo].[Doctors]
(
    [id] INT NOT NULL PRIMARY KEY,
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [studies] CHAR(64) NOT NULL,
    [specialization] CHAR(64) NOT NULL,
    [partner_id] int NOT NULL
)
