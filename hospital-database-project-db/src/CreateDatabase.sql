CREATE TABLE [dbo].[Shifts]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [begin_time] DATETIME NOT NULL,
    [end_time] DATETIME NOT NULL,
    [description] CHAR(128)
);

CREATE TABLE [dbo].[Employees]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [type] CHAR(64) NOT NULL,
	[shift_id] INT NOT NULL,
    CONSTRAINT FK_employee_shift
    FOREIGN KEY (shift_id) REFERENCES Shifts (id)
);

CREATE TABLE [dbo].[Doctors]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [studies] CHAR(64) NOT NULL,
    [specialization] CHAR(64) NOT NULL,
    [partner_id] int NOT NULL,
    [employee_id] INT NOT NULL,
    CONSTRAINT FK_doctor_employee
    FOREIGN KEY (employee_id) REFERENCES Employees (id)
);

CREATE TABLE [dbo].[Treatments]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [name] CHAR(64) NOT NULL,
    [duration] INT NOT NULL,
    [medicine_id] INT NOT NULL
);

CREATE TABLE [dbo].[Medicines]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [name] CHAR(64) NOT NULL,
    [expiration_date] DATE NOT NULL,
    [provider] CHAR(64) NOT NULL
);

CREATE TABLE [dbo].[Rooms]
(
    [id] INT NOT NULL PRIMARY KEY,
    [type] CHAR(64) NOT NULL
);


CREATE TABLE [dbo].[ICUs]
(
    [number] INT NOT NULL PRIMARY KEY,
    [floor] INT NOT NULL,
    [type] CHAR(64) NOT NULL,
    [room_id] INT NOT NULL,
    CONSTRAINT FK_ICU_room
    FOREIGN KEY (room_id) REFERENCES Rooms (id)
);

CREATE TABLE [dbo].[OperationTheaters]
(
    [number] INT NOT NULL PRIMARY KEY,
    [floor] INT NOT NULL,
    [specialization] CHAR(64) NOT NULL,
    [room_id] INT NOT NULL,
    CONSTRAINT FK_operation_theater_room
    FOREIGN KEY (room_id) REFERENCES Rooms (id)
);

CREATE TABLE [dbo].[Nurses]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [studies] CHAR(64) NOT NULL,
    [floor] INT,
    [employee_id] INT NOT NULL,
    CONSTRAINT FK_nurse_employee
    FOREIGN KEY (employee_id) REFERENCES Employees (id)
);

CREATE TABLE [dbo].[Watchmen]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [first_name] CHAR(32) NOT NULL,
    [last_name] CHAR(32) NOT NULL,
    [age] INT NOT NULL,
    [gender] CHAR(1) NOT NULL,
    [assigned_zone] CHAR(16) NOT NULL,
    [employee_id] INT NOT NULL,
    CONSTRAINT FK_watchman_employee
    FOREIGN KEY (employee_id) REFERENCES Employees (id)
);

CREATE TABLE [dbo].[Patients]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
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

CREATE TABLE [dbo].[Bills]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [name] CHAR(64) NOT NULL,
    [sum] DECIMAL NOT NULL,
    [state] CHAR(8) NOT NULL,
    [patient_id] INT NOT NULL,
    CONSTRAINT FK_bill_patient
    FOREIGN KEY (patient_id) REFERENCES Patients (id)
);

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

CREATE TABLE [dbo].[Partners]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [name] CHAR(64) NOT NULL,
    [partnership_type] CHAR(32) NOT NULL,
    [begin_date] DATE NOT NULL,
    [end_date] DATE,
    [doctor_id] INT NOT NULL
);

CREATE TABLE [dbo].[TreatmentsMedicines]
(
	[treatment_id] INT NOT NULL,
    [medicine_id] INT NOT NULL,
    [medicine_dosage] CHAR(64) NOT NULL,
    [description] CHAR(128) NOT NULL,
    CONSTRAINT PK_treatment_medicine PRIMARY KEY (treatment_id, medicine_id),
    CONSTRAINT FK_medicine_treatment
    FOREIGN KEY (treatment_id) REFERENCES Treatments (id),
    CONSTRAINT FK_treatment_medicine
    FOREIGN KEY (medicine_id) REFERENCES Medicines (id)
);

CREATE TABLE [dbo].[DoctorsPartners]
(
	[doctor_id] INT NOT NULL,
    [partner_id] INT NOT NULL,
    CONSTRAINT PK_doctor_partner PRIMARY KEY (doctor_id, partner_id),
    CONSTRAINT FK_partner_doctor
    FOREIGN KEY (doctor_id) REFERENCES Doctors (id),
    CONSTRAINT FK_doctor_partner
    FOREIGN KEY (partner_id) REFERENCES Partners (id)
);
