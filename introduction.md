# Hospital Database Introduction

The project we have decided to work on is the database for a hospital. This is a topic of dire importance in our
times, because as the recent pandemic has proven, hospitals need a very well made and clear structure to be able to
withstand the amount of patients they are receiving.

This is where a database comes in, such as the one we have decided to make. Databases are of crucial importance for
the infrastructure of a big institution, such as a hospital, as they first and foremost allow easier management for
various information that is required for the people working in it to do their jobs. For example, having a database
for a hospital allows us to store information about the patients, which can then easily be accessed by a doctor
through an interface in order to make quicker and better assesments of patients.

Another domain related to the operation of a hospital, that is paramount to have a well-organised database, is that
of medicine management, since various medicines are used in various treatments in differing dosages, which would
be extremely inefficient with the sheer amount of medicines hospitals are working with nowadays.

With these things in mind, it’s no doubt that most of modern hospitals would employ some kind of a database or other
digital information storage solution for proper management of their necessary information. It should be mentioned
that among these modern hospitals that do use such systems for information management, in a lot of cases their
security is not really up to today’s standards, which is definetly something to keep in mind as it can lead to
some serious problems, if, for example, a data breach was to happen and all the personal information of the patients
in the hospital would be leaked out.

Below is a short explanation of what each table’s information is about:

- Patients: information about the patients of the hospital, including information regarding their
  undergoing treatment, which doctor and room they are assigned to
- Doctors: information about the doctors working in the hospital, including their specialization and studies
- Nurses: basic information about the nurses of the hospital
- Watchmen: information about the watchmen of the hopsital, including what zone they are assigned to
- Employees: general information of all employees, with more information for their specific jobs and such being found in their specific tables
- Apprentices: information about the current apprentices at the hospital, including which university they’re from,
  their specialization and which doctor is their mentor
- Treatments: information about all the treatments that are provided in the hospital, including what medicines
  are included in it
- Medicines: information about the medicines that the hospital has available to use in its treatments,
  including the provider it comes from
- Rooms: information about the rooms in which the patients are staying
- ICUs: information about the ICUs (Intensive Care Units) that are present in the hospital, including their type
- OperationTheaters: information about the operation theaters present in the hospital, including their
  specialization
- Bills: information about the bills that the patients of the hospital need to pay, including whether they have been paid up or not yet and which patient it belongs to
- Shifts: information about the various shifts that the employees of the hospital are working in
- Partners: information about the various partners the hospital might have, including the type of the partnership and
  the period of time
- TreatmentsMedicines: an auxiliary table for facilitating the many-to-many relation between medicines and
  treatments; it also includes a few other details such as the medicine's dosage in a specific treatment
- DoctorsPartners: auxiliary table for the many-to-many relation between doctors and partners
