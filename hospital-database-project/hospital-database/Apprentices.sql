CREATE TABLE [dbo].[Apprentices]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR NOT NULL,
    [university] CHAR(64) NOT NULL,
    [study_year] CHAR(32) NOT NULL,
    [specialization] CHAR(64) NOT NULL,
    [doctor_id] INT NOT NULL,
    CONSTRAINT FK_apprentice_doctor
    FOREIGN KEY (doctor_id) REFERENCES Doctors (id)
);
