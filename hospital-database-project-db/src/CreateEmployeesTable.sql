CREATE TABLE [dbo].[Employees]
(
	[id] INT NOT NULL PRIMARY KEY,
    [type] CHAR(64) NOT NULL,
	[specific_employee_id] INT NOT NULL,
	[shift_id] INT NOT NULL
)
