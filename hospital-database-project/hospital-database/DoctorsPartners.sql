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
