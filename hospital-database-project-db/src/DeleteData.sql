USE [hospital-database-project-db]
GO

DELETE FROM dbo.DoctorsPartners;
GO

DELETE FROM dbo.TreatmentsMedicines;
GO

DELETE FROM dbo.Partners;
GO

DBCC CHECKIDENT ('dbo.Partners', RESEED, 0);
GO

DELETE FROM dbo.Apprentices;
GO

DBCC CHECKIDENT ('dbo.Apprentices', RESEED, 0);
GO

DELETE FROM dbo.Bills;
GO

DBCC CHECKIDENT ('dbo.Bills', RESEED, 0);
GO

DELETE FROM dbo.Patients;
GO

DBCC CHECKIDENT ('dbo.Patients', RESEED, 0);
GO

DELETE FROM dbo.Watchmen;
GO

DBCC CHECKIDENT ('dbo.Watchmen', RESEED, 0);
GO

DELETE FROM dbo.Nurses;
GO

DBCC CHECKIDENT ('dbo.Nurses', RESEED, 0);
GO

DELETE FROM dbo.OperationTheaters;
GO

DELETE FROM dbo.ICUs;
GO

DELETE FROM dbo.Treatments;
GO

DBCC CHECKIDENT ('dbo.Treatments', RESEED, 0);
GO

DELETE FROM dbo.Doctors;
GO

DBCC CHECKIDENT ('dbo.Doctors', RESEED, 0);
GO

DELETE FROM dbo.Employees;
GO

DBCC CHECKIDENT ('dbo.Employees', RESEED, 0);
GO

DELETE FROM dbo.Shifts;
GO

DBCC CHECKIDENT ('dbo.Shifts', RESEED, 0);
GO

DELETE FROM dbo.Medicines;
GO

DBCC CHECKIDENT ('dbo.Medicines', RESEED, 0);
GO

DELETE FROM dbo.Rooms;
GO

DBCC CHECKIDENT ('dbo.Rooms', RESEED, 0);
GO
