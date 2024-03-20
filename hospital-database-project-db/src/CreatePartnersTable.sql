CREATE TABLE [dbo].[Partners]
(
	[id] INT NOT NULL PRIMARY KEY,
    [name] CHAR(64) NOT NULL,
    [partnership_type] CHAR(32) NOT NULL,
    [begin_time] DATE NOT NULL,
    [end_time] DATE,
    [doctor_id] INT NOT NULL
)
