USE [hospital-database-project-db]
GO

INSERT INTO dbo.Rooms
           (id
           ,type)
     VALUES
           ('1'
		   ,'A'),
		   ('2'
		   ,'A'),
           ('3'
		   ,'B'),
           ('4'
		   ,'B'),
           ('5'
		   ,'B'),
           ('6'
		   ,'A'),
           ('7'
		   ,'B'),
           ('8'
		   ,'A'),
           ('9'
		   ,'A'),
           ('10'
		   ,'A')
GO

INSERT INTO dbo.Medicines
           (id
           ,name
           ,expiration_date
           ,provider)
     VALUES
           ('1'
		   ,'Halotan'
           ,'2024-11-21'
           ,'Amgen'),
		   ('2'
		   ,'Atropina'
           ,'2025-10-11'
           ,'UCB'),
           ('3'
		   ,'Ibuprofen'
           ,'2027-03-08'
           ,'AstraZeneca'),
           ('4'
		   ,'Morfina'
           ,'2025-12-01'
           ,'Roche'),
           ('5'
		   ,'Penicilamina'
           ,'2025-10-11'
           ,'Labormed'),
           ('6'
		   ,'Diazepam'
           ,'2028-03-16'
           ,'Stada'),
           ('7'
		   ,'Dapsona'
           ,'2028-03-10'
           ,'Pharco'),
           ('8'
		   ,'Paracetamol'
           ,'2026-10-01'
           ,'Krka'),
           ('9'
		   ,'Citarabina'
           ,'2025-07-04'
           ,'Genzyme'),
           ('10'
		   ,'Etanol'
           ,'2027-04-22'
           ,'Pfizer')
GO

INSERT INTO dbo.Shifts
           (id
           ,begin_time
           ,end_time
           ,description)
     VALUES
           ('1'
		   ,'2024-03-28 10:00:00'
           ,'2024-03-28 18:00:00'
           ,'General 8 hour shift'),
		   ('2'
		   ,'2024-03-28 08:00:00'
           ,'2024-03-28 18:00:00'
           ,'General 10 hour shift'),
           ('3'
		   ,'2024-03-28 08:00:00'
           ,'2024-03-28 12:00:00'
           ,'Doctor group 1 shift'),
           ('4'
		   ,'2024-03-28 12:00:00'
           ,'2024-03-28 16:00:00'
           ,'Doctor group 2 shift'),
           ('5'
		   ,'2024-03-28 16:00:00'
           ,'2024-03-28 20:00:00'
           ,'Doctor group 3 shift'),
           ('6'
		   ,'2024-03-28 08:00:00'
           ,'2024-03-28 14:00:00'
           ,'Nurses group 1 shift'),
           ('7'
		   ,'2024-03-28 14:00:00'
           ,'2024-03-28 20:00:00'
           ,'Nurses group 2 shift'),
           ('8'
		   ,'2024-03-28 08:00:00'
           ,'2024-03-28 16:00:00'
           ,'Watchmen group 1 shift'),
           ('9'
		   ,'2024-03-28 16:00:00'
           ,'2024-03-28 00:00:00'
           ,'Watchmen group 2 shift'),
           ('10'
		   ,'2024-03-28 00:00:00'
           ,'2024-03-28 08:00:00'
           ,'Watchmen group 3 shift')
GO

INSERT INTO dbo.Employees
           (id
           ,type
           ,shift_id)
     VALUES
           ('1'
		   ,'Doctor'
           ,'3'),
           ('2'
		   ,'Doctor'
           ,'4'),
           ('3'
		   ,'Nurse'
           ,'6'),
           ('4'
		   ,'Nurse'
           ,'7'),
           ('5'
		   ,'Doctor'
           ,'5'),
           ('6'
		   ,'Watchman'
           ,'8'),
           ('7'
		   ,'Doctor'
           ,'3'),
           ('8'
		   ,'Nurse'
           ,'7'),
           ('9'
		   ,'Nurse'
           ,'6'),
           ('10'
		   ,'Watchman'
           ,'10')
GO

INSERT INTO dbo.Doctors
           (id
           ,first_name
           ,last_name
           ,age
           ,gender
           ,studies
           ,specialization
           ,partner_id
           ,employee_id)
     VALUES
           ('1'
		   ,'Ryan'
           ,'Thompson'
           ,'29'
           ,'M'
           ,'College'
           ,'Plastic Surgery'
           ,'1'
           ,'1'),
           ('2'
		   ,'Jasmine'
           ,'Patel'
           ,'35'
           ,'F'
           ,'PhD'
           ,'Surgery'
           ,'2'
           ,'2'),
           ('3'
		   ,'Sophia'
           ,'Rodriguez'
           ,'30'
           ,'F'
           ,'College'
           ,'Cardiology'
           ,'3'
           ,'7'),
           ('4'
		   ,'Caleb'
           ,'Campbell'
           ,'42'
           ,'M'
           ,'Master Degree'
           ,'Hematology'
           ,'4'
           ,'5')
GO

INSERT INTO dbo.Treatments
           (id
           ,name
           ,duration
           ,medicine_id)
     VALUES
           ('1'
		   ,'Basic 1'
           ,'24'
           ,'2'),
		   ('2'
		   ,'Basic 2'
           ,'48'
           ,'2'),
		   ('3'
		   ,'Basic 3'
           ,'64'
           ,'3'),
		   ('4'
		   ,'Advanced 1'
           ,'24'
           ,'4'),
		   ('5'
		   ,'Advanced 5'
           ,'48'
           ,'5'),
		   ('6'
		   ,'Advanced 6'
           ,'64'
           ,'6')
GO

INSERT INTO dbo.ICUs
           (number
           ,floor
           ,type
           ,room_id)
     VALUES
           ('1'
		   ,'1'
           ,'Neonatology'
           ,'3'),
		   ('2'
		   ,'1'
           ,'Cardiac'
           ,'4'),
		   ('3'
		   ,'2'
           ,'Neurology'
           ,'5'),
		   ('4'
		   ,'2'
           ,'Surgery'
           ,'7')
GO

INSERT INTO dbo.OperationTheaters
           (number
           ,floor
           ,specialization
           ,room_id)
     VALUES
           ('1'
		   ,'1'
           ,'Surgery'
           ,'1'),
		   ('2'
		   ,'1'
           ,'Surgery'
           ,'2'),
		   ('3'
		   ,'2'
           ,'Neurology'
           ,'6'),
		   ('4'
		   ,'2'
           ,'Neurology'
           ,'8'),
           ('5'
		   ,'3'
           ,'Cardiac'
           ,'9'),
           ('6'
		   ,'3'
           ,'Cardiac'
           ,'10')
GO

INSERT INTO dbo.Nurses
           (id
           ,first_name
           ,last_name
           ,age
           ,gender
           ,studies
           ,floor
           ,employee_id)
     VALUES
           ('1'
		   ,'Amelia'
           ,'Bennett'
           ,'37'
           ,'F'
           ,'College'
           ,'1'
           ,'3'),
		   ('2'
		   ,'Lucas'
           ,'Nguyen'
           ,'28'
           ,'M'
           ,'College'
           ,'1'
           ,'4'),
           ('3'
		   ,'Harper'
           ,'Patel'
           ,'31'
           ,'M'
           ,'College'
           ,'2'
           ,'8'),
           ('4'
		   ,'Ethan'
           ,'Khan'
           ,'33'
           ,'M'
           ,'College'
           ,'2'
           ,'9')
GO

INSERT INTO dbo.Watchmen
           (id
           ,first_name
           ,last_name
           ,age
           ,gender
           ,assigned_zone
           ,employee_id)
     VALUES
           ('1'
		   ,'Emily'
           ,'Johnson'
           ,'32'
           ,'F'
           ,'1C'
           ,'6'),
		   ('2'
		   ,'Lucas'
           ,'Nguyen'
           ,'45'
           ,'M'
           ,'2B'
           ,'10')
GO

INSERT INTO dbo.Patients
           (id
           ,first_name
           ,last_name
           ,age
           ,gender
           ,weight
           ,occupation
           ,doctor_id
           ,treatment_id
           ,room_id)
     VALUES
           ('1'
		   ,'Benjamin'
           ,'Clarke'
           ,'35'
           ,'M'
           ,'98'
           ,'Store Clerk'
           ,'1'
           ,'3'
           ,'2'),
           ('2'
		   ,'Olivia'
           ,'Nguyen'
           ,'24'
           ,'F'
           ,'71'
           ,'Student'
           ,'2'
           ,'2'
           ,'1'),
           ('3'
		   ,'Mason'
           ,'Patel'
           ,'40'
           ,'M'
           ,'110'
           ,'Lbrarian'
           ,'3'
           ,'5'
           ,'7'),
           ('4'
		   ,'Harper'
           ,'Williams'
           ,'40'
           ,'M'
           ,'87'
           ,'Banker'
           ,'4'
           ,'5'
           ,'8'),
           ('5'
		   ,'Elizabeth'
           ,'Khan'
           ,'35'
           ,'F'
           ,'98'
           ,'Store Clerk'
           ,'3'
           ,'4'
           ,'10')
GO

INSERT INTO dbo.Bills
           (id
           ,name
           ,sum
           ,state
           ,patient_id)
     VALUES
           ('1'
		   ,'Medical Consultation'
           ,'200'
           ,'unpaid'
           ,'1'),
           ('2'
		   ,'Surgery'
           ,'1000'
           ,'paid'
           ,'2'),
           ('3'
		   ,'Medical Consultation'
           ,'100'
           ,'paid'
           ,'4'),
           ('4'
		   ,'Physiotherapy'
           ,'400'
           ,'paid'
           ,'5'),
           ('5'
		   ,'Medical Consultation'
           ,'200'
           ,'unpaid'
           ,'3')
GO

INSERT INTO dbo.Apprentices
           (id
           ,first_name
           ,last_name
           ,age
           ,gender
           ,university
           ,study_year
           ,specialization
           ,doctor_id)
     VALUES
           ('1'
		   ,'Sophia'
           ,'Campbell'
           ,'22'
           ,'F'
           ,'UMF'
           ,'5'
           ,'Surgery'
           ,'1'),
           ('2'
		   ,'Noah'
           ,'Campbell'
           ,'23'
           ,'M'
           ,'UMF'
           ,'5'
           ,'Surgery'
           ,'2'),
           ('3'
		   ,'Emily'
           ,'Chen'
           ,'21'
           ,'F'
           ,'UMF'
           ,'5'
           ,'Surgery'
           ,'3')
GO

INSERT INTO dbo.Partners
           (id
           ,name
           ,partnership_type
           ,begin_date
           ,end_date
           ,doctor_id)
     VALUES
           ('1'
		   ,'Centrofarm'
           ,'Promotional'
           ,'2024-03-20'
           ,'2025-03-20'
           ,'1'),
           ('2'
		   ,'Catena'
           ,'Promotional'
           ,'2024-01-23'
           ,'2025-01-23'
           ,'2'),
           ('3'
		   ,'UMF'
           ,'Apprenticeship program'
           ,'2022-11-22'
           ,'2026-11-22'
           ,'3')
GO

INSERT INTO dbo.TreatmentsMedicines
           (treatment_id
           ,medicine_id
           ,medicine_dosage
           ,description)
     VALUES
           ('1'
           ,'1'
           ,'1 per day'
           ,'should only be administred if patient is feeling serious pain'),
           ('2'
           ,'3'
           ,'1 in the morning, 1 in the evening'
           ,'administer consistently for it to take effect properly'),
           ('5'
           ,'9'
           ,'1 every other day'
           ,'if pain gets worse, dosage can be increased to 1 per day')
GO

INSERT INTO dbo.DoctorsPartners
           (doctor_id
           ,partner_id)
     VALUES
           ('1'
           ,'2'),
           ('2'
           ,'3'),
           ('4'
           ,'1')
           
GO
