CREATE TABLE [dbo].[Patients]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [weight] INT,
    [occupation] CHAR(64),
    [doctor_id] INT NOT NULL,
    [treatment_id] INT NOT NULL,
    [room_id] INT NOT NULL,
    CONSTRAINT FK_room
    FOREIGN KEY (room_id) REFERENCES Rooms (id),
    CONSTRAINT FK_patient_treatment
    FOREIGN KEY (treatment_id) REFERENCES Treatments (id),
    CONSTRAINT FK_patient_doctor
    FOREIGN KEY (doctor_id) REFERENCES Doctors (id)
);
