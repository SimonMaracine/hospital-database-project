CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [first_name] VARCHAR(50) NOT NULL, 
    [last_name] VARCHAR(50) NOT NULL, 
    [age] INT NOT NULL, 
    [weight] INT NOT NULL, 
    [gender] INT NOT NULL, 
    [occupation] VARCHAR(50) NOT NULL, 
    [doctor_id] INT NOT NULL, 
    [treatment_id] INT NOT NULL, 
    [room_id] INT NOT NULL
)