CREATE TABLE [dbo].[Watchmen]
(
    [id] INT NOT NULL PRIMARY KEY, 
    [first_name] CHAR(32) NOT NULL, 
    [last_name] CHAR(32) NOT NULL, 
    [age] INT NOT NULL, 
    [gender] CHAR(1) NOT NULL, 
    [assigned_zone] CHAR(16) NOT NULL 
)