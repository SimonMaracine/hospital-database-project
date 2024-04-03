
USE [hospital-database]
GO

INSERT INTO dbo.Rooms
        (type)
    VALUES
        ('A'),
        ('A'),
        ('B'),
        ('B'),
        ('B'),
        ('A'),
        ('B'),
        ('A'),
        ('A'),
        ('A')
GO

INSERT INTO dbo.Medicines
        (
            name,
            expiration_date,
            provider
        )
    VALUES
        (
            'Halotan',
            '2024-11-21',
            'Amgen'
        ),
        (
            'Atropina',
            '2025-10-11',
            'UCB'
        ),
        (
            'Ibuprofen',
            '2027-03-08',
            'AstraZeneca'
        ),
        (
            'Morfina',
            '2025-12-01',
            'Roche'
        ),
        (
            'Penicilamina',
            '2025-10-11',
            'Labormed'
        ),
        (
            'Diazepam',
            '2028-03-16',
            'Stada'
        ),
        (
            'Dapsona',
            '2028-03-10',
            'Pharco'
        ),
        (
            'Paracetamol',
            '2026-10-01',
            'Krka'
        ),
        (
            'Citarabina',
            '2025-07-04',
            'Genzyme'
        ),
        (
            'Etanol',
            '2027-04-22',
            'Pfizer'
        )
GO

INSERT INTO dbo.Shifts
        (
            begin_time,
            end_time,
            description
        )
    VALUES
        (
            '2024-03-28 10:00:00',
            '2024-03-28 18:00:00',
            'General 8 hour shift'
        ),
        (
            '2024-03-28 08:00:00',
            '2024-03-28 18:00:00',
            'General 10 hour shift'
        ),
        (
            '2024-03-28 08:00:00',
            '2024-03-28 12:00:00',
            'Doctor group 1 shift'
        ),
        (
            '2024-03-28 12:00:00',
            '2024-03-28 16:00:00',
            'Doctor group 2 shift'
        ),
        (
            '2024-03-28 16:00:00',
            '2024-03-28 20:00:00',
            'Doctor group 3 shift'
        ),
        (
            '2024-03-28 08:00:00',
            '2024-03-28 14:00:00',
            'Nurses group 1 shift'
        ),
        (
            '2024-03-28 14:00:00',
            '2024-03-28 20:00:00',
            'Nurses group 2 shift'
        ),
        (
            '2024-03-28 08:00:00',
            '2024-03-28 16:00:00',
            'Watchmen group 1 shift'
        ),
        (
            '2024-03-28 16:00:00',
            '2024-03-28 00:00:00',
            'Watchmen group 2 shift'
        ),
        (
            '2024-03-28 00:00:00',
            '2024-03-28 08:00:00',
            'Watchmen group 3 shift'
        )
GO

INSERT INTO dbo.Employees
        (
            type,
            shift_id
        )
    VALUES
        (
            'Doctor',
            '3'
        ),
        (
            'Doctor',
            '4'
        ),
        (
            'Nurse',
            '6'
        ),
        (
            'Nurse',
            '7'
        ),
        (
            'Doctor',
            '5'
        ),
        (
            'Watchman',
            '8'
        ),
        (
            'Doctor',
            '3'
        ),
        (
            'Nurse',
            '7'
        ),
        (
            'Nurse',
            '6'
        ),
        (
            'Watchman',
            '10'
        )
GO

INSERT INTO dbo.Doctors
        (
            first_name,
            last_name,
            age,
            gender,
            studies,
            specialization,
            partner_id,
            employee_id
        )
    VALUES
        (
            'Ryan',
            'Thompson',
            '29',
            'M',
            'College',
            'Plastic Surgery',
            '1',
            '1'
        ),
        (
            'Jasmine',
            'Patel',
            '35',
            'F',
            'PhD',
            'Surgery',
            '2',
            '2'
        ),
        (
            'Sophia',
            'Rodriguez',
            '30',
            'F',
            'College',
            'Cardiology',
            '3',
            '7'
        ),
        (
            'Caleb',
            'Campbell',
            '42',
            'M',
            'Master Degree',
            'Hematology',
            '4',
            '5'
        )
GO

INSERT INTO dbo.Treatments
        (
            name,
            duration,
            medicine_id
        )
    VALUES
        (
            'Basic 1',
            '24',
            '2'
        ),
        (
            'Basic 2',
            '48',
            '2'
        ),
        (
            'Basic 3',
            '64',
            '3'
        ),
        (
            'Advanced 1',
            '24',
            '4'
        ),
        (
            'Advanced 5',
            '48',
            '5'
        ),
        (
            'Advanced 6',
            '64',
            '6'
        )
GO

INSERT INTO dbo.ICUs
        (
            number,
            floor,
            type,
            room_id
        )
    VALUES
        (
            '1',
            '1',
            'Neonatology',
            '3'
        ),
        (
            '2',
            '1',
            'Cardiac',
            '4'
        ),
        (
            '3',
            '2',
            'Neurology',
            '5'
        ),
        (
            '4',
            '2',
            'Surgery',
            '7'
        )
GO

INSERT INTO dbo.OperationTheaters
        (
            number,
            floor,
            specialization,
            room_id
        )
    VALUES
        (
            '1',
            '1',
            'Surgery',
            '1'
        ),
        (
            '2',
            '1',
            'Surgery',
            '2'
        ),
        (
            '3',
            '2',
            'Neurology',
            '6'
        ),
        (
            '4',
            '2',
            'Neurology',
            '8'
        ),
        (
            '5',
            '3',
            'Cardiac',
            '9'
        ),
        (
            '6',
            '3',
            'Cardiac',
            '10'
        )
GO

INSERT INTO dbo.Nurses
        (
            first_name,
            last_name,
            age,
            gender,
            studies,
            floor,
            employee_id
        )
     VALUES
        (
            'Amelia',
            'Bennett',
            '37',
            'F',
            'College',
            '1',
            '3'
        ),
        (
            'Lucas',
            'Nguyen',
            '28',
            'M',
            'College',
            '1',
            '4'
        ),
        (
            'Harper',
            'Patel',
            '31',
            'M',
            'College',
            '2',
            '8'
        ),
        (
            'Ethan',
            'Khan',
            '33',
            'M',
            'College',
            '2',
            '9'
        )
GO

INSERT INTO dbo.Watchmen
        (
            first_name,
            last_name,
            age,
            gender,
            assigned_zone,
            employee_id
        )
    VALUES
        (
            'Emily',
            'Johnson',
            '32',
            'F',
            '1C',
            '6'
        ),
        (
            'Lucas',
            'Nguyen',
            '45',
            'M',
            '2B',
            '10'
        )
GO

INSERT INTO dbo.Patients
        (
            first_name,
            last_name,
            age,
            gender,
            weight,
            occupation,
            doctor_id,
            treatment_id,
            room_id
        )
    VALUES
        (
            'Benjamin',
            'Clarke',
            '35',
            'M',
            '98',
            'Store Clerk',
            '1',
            '3',
            '2'
        ),
        (
            'Olivia',
            'Nguyen',
            '24',
            'F',
            '71',
            'Student',
            '2',
            '2',
            '1'
        ),
        (
            'Mason',
            'Patel',
            '40',
            'M',
            '110',
            'Lbrarian',
            '3',
            '5',
            '7'
        ),
        (
            'Harper',
            'Williams',
            '40',
            'M',
            '87',
            'Banker',
            '4',
            '5',
            '8'
        ),
        (
            'Elizabeth',
            'Khan',
            '35',
            'F',
            '98',
            'Store Clerk',
            '3',
            '4',
            '10'
        )
GO

INSERT INTO dbo.Bills
        (
            name,
            sum,
            state,
            patient_id
        )
    VALUES
        (
            'Medical Consultation',
            '200',
            'unpaid',
            '1'
        ),
        (
            'Surgery',
            '1000',
            'paid',
            '2'
        ),
        (
            'Medical Consultation',
            '100',
            'paid',
            '4'
        ),
        (
            'Physiotherapy',
            '400',
            'paid',
            '5'
        ),
        (
            'Medical Consultation',
            '200',
            'unpaid',
            '3'
        )
GO

INSERT INTO dbo.Apprentices
        (
            first_name,
            last_name,
            age,
            gender,
            university,
            study_year,
            specialization,
            doctor_id
        )
    VALUES
        (
            'Sophia',
            'Campbell',
            '22',
            'F',
            'UMF',
            '5',
            'Surgery',
            '1'
        ),
        (
            'Noah',
            'Campbell',
            '23',
            'M',
            'UMF',
            '5',
            'Surgery',
            '2'
        ),
        (
            'Emily',
            'Chen',
            '21',
            'F',
            'UMF',
            '5',
            'Surgery',
            '3'
        )
GO

INSERT INTO dbo.Partners
        (
            name,
            partnership_type,
            begin_date,
            end_date,
            doctor_id
        )
    VALUES
        (
            'Centrofarm',
            'Promotional',
            '2024-03-20',
            '2025-03-20',
            '1'
        ),
        (
            'Catena',
            'Promotional',
            '2024-01-23',
            '2025-01-23',
            '2'
        ),
        (
            'UMF',
            'Apprenticeship program',
            '2022-11-22',
            '2026-11-22',
            '3'
        )
GO

INSERT INTO dbo.TreatmentsMedicines
        (
            treatment_id,
            medicine_id,
            medicine_dosage,
            description
        )
    VALUES
        (
            '1',
            '1',
            '1 per day',
            'should only be administred if patient is feeling serious pain'
        ),
        (
            '2',
            '3',
            '1 in the morning, 1 in the evening',
            'administer consistently for it to take effect properly'
        ),
        (
            '5',
            '9',
            '1 every other day',
            'if pain gets worse, dosage can be increased to 1 per day'
        )
GO

INSERT INTO dbo.DoctorsPartners
        (
            doctor_id,
            partner_id
        )
    VALUES
        (
            '1',
            '2'
        ),
        (
            '2',
            '3'
        ),
        (
            '4',
            '1'
        )
GO
