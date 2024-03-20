CREATE TABLE [dbo].[Patients]
(
    [id] INT NOT NULL PRIMARY KEY,
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [weight] INT,
    [occupation] CHAR(64),
    [doctor_id] INT NOT NULL,
    [treatment_id] INT NOT NULL,
    [room_id] INT NOT NULL
)
