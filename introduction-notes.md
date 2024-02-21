# Hospital Database Tables

- Patients
  - ID(PK)
  - First_name
  - Last_name
  - Age
  - Weight
  - Gender
  - Occupation
  - Doctor_ID(FK)(one-to-many)(a patient is treated by one doctor, a doctor has many patients)
  - Treatment_ID(FK)(one-to-many)(a patient is undergoing one treatment, a treatment may be applied to many patients)
  - Room_ID(FK)(one-to-many)(a patient is assigned a single room to stay in, a room may have multiple patients assigned to it)

- Doctors
  - ID(PK)
  - First_name
  - Last_name
  - Studies
  - Specialization
  - Age
  - Gender

- Treatments
  - ID(PK)
  - Name
  - Duration
  - Medicines(FK)(many-to-many, table at the end)(a treatment may have many medicines included, a medicine may be included in many treatments)

- Rooms
  - ID(PK)
  - Number
  - Floor

- ICUs
  - ID(PK)
  - Number
  - Floor
  - Type

- OperationTheaters
  - ID(PK)
  - Specialization
  - Number
  - Floor

- Nurses
  - ID(PK)
  - First_name
  - Last_name
  - Age
  - Studies
  - Gender

- Watchmen
  - ID(PK)
  - First_name
  - Last_name
  - Age
  - Gender
  - Assigned_zone

- Bills
  - Name
  - ID(PK)
  - Sum
  - State(payed/not payed)
  - Patient(FK)(one-to-many)(a bill can only be applied to one patient, a patient can have many bills)

- Medicines
  - ID(PK)
  - Name
  - Expiration_date
  - Provider

- Apprentices
  - ID(PK)
  - First_name
  - Last_name
  - Age
  - Gender
  - University
  - Study_year
  - Specialization
  - Guide(Doctor)(FK)(one-to-many)(a apprentice can have only one guide doctor, a doctor can be guiding multiple apprentices)

- Purchases
  - ID(PK)
  - Name
  - Sum
  - Quantity

- Shifts
  - ID(PK)
  - Begin_time
  - End_time

- Partners
  - ID(PK)
  - Name
  - Partnership_type
  - Begin_date
  - End_date

- Treatment_details
  - Treatment_ID(PK)
  - Medicine_ID(PK)
  - Medicine_dosage
