CREATE TABLE [dbo].[Shifts]
(
	[id] INT NOT NULL PRIMARY KEY,
    [begin_time] DATETIME NOT NULL,
    [end_time] DATETIME NOT NULL,
    [description] CHAR(128)
)
