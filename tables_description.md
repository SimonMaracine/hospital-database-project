# Hospital Database Tables

- Patients
  - id (PK)
  - first_name
  - last_name
  - age
  - weight
  - gender
  - occupation
  - doctor_id (FK) (one-to-many) (a patient is treated by one doctor, a doctor has many patients)
  - treatment_id (FK) (one-to-many) (a patient is undergoing one treatment, a treatment may be applied to many patients)
  - room_id (FK) (one-to-many) (a patient is assigned a single room to stay in, a room may have multiple patients assigned to it)

- Doctors
  - id (PK)
  - first_name
  - last_name
  - age
  - gender
  - studies
  - specialization
  - partner_id (FK) (many-to-many) (a doctor can have many partners, a partner is an affiliate for many doctors)

- Treatments
  - id (PK)
  - name
  - duration
  - medicine_id (FK) (many-to-many, table at the end) (a treatment may have many medicines included, a medicine may be included in many treatments)

- Rooms
  - id (PK)
  - type
  - specific_room_number (FK)

- ICUs
  - number (PK)
  - floor
  - type

- OperationTheaters
  - number (PK)
  - floor
  - specialization

- Nurses
  - id (PK)
  - first_name
  - last_name
  - age
  - gender
  - studies
  - floor

- Watchmen
  - id (PK)
  - first_name
  - last_name
  - age
  - gender
  - assigned_zone

- Bills
  - id (PK)
  - name
  - sum
  - state (paid/not paid)
  - patient_id (FK) (one-to-many) (a bill can only be applied to one patient, a patient can have many bills)

- Medicines
  - id (PK)
  - name
  - expiration_date
  - provider
  - treatment_id (FK) (many-to-many)

- Apprentices
  - id (PK)
  - first_name
  - last_name
  - age
  - gender
  - university
  - study_year
  - specialization
  - doctor_id (FK) (one-to-many) (an apprentice can have only one mentor doctor, a doctor can be mentoring multiple apprentices)

- Shifts
  - id (PK)
  - begin_time
  - end_time
  - description

- Partners
  - id (PK)
  - name
  - partnership_type
  - begin_date
  - end_date
  - doctor_id (FK) (many-to-many)

- TreatmentsMedicines
  - treatment_id (PK)
  - medicine_id (PK)
  - medicine_dosage
  - description

- DoctorsPartners
  - doctor_id (PK)
  - partner_id (PK)

- Employees
  - id (PK)
  - type
  - specific_employee_id (FK) (one-to-one) (an employee has a one specific id)
  - shift_id (FK) (one-to-many) (an employees can have many shifts, a shift is tied to only one employee)
