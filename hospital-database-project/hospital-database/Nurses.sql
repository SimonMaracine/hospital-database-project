CREATE TABLE [dbo].[Nurses]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [studies] CHAR(64) NOT NULL,
    [floor] INT,
    [employee_id] INT UNIQUE NOT NULL,
    CONSTRAINT FK_nurse_employee
    FOREIGN KEY (employee_id) REFERENCES Employees (id)
);
