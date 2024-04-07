CREATE TABLE [dbo].[Watchmen]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [assigned_zone] CHAR(16) NOT NULL,
    [employee_id] INT NOT NULL,
    CONSTRAINT FK_watchman_employee
    FOREIGN KEY (employee_id) REFERENCES Employees (id)
);
