CREATE TABLE [dbo].[Partners]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [name] CHAR(64) NOT NULL,
    [partnership_type] CHAR(32) NOT NULL,
    [begin_date] DATE NOT NULL,
    [end_date] DATE,
    [doctor_id] INT NOT NULL
);
