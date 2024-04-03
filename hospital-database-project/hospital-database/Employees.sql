CREATE TABLE [dbo].[Employees]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [type] CHAR(64) NOT NULL,
	[shift_id] INT NOT NULL,
    CONSTRAINT FK_employee_shift
    FOREIGN KEY (shift_id) REFERENCES Shifts (id)
);
