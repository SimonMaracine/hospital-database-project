# Hospital Database

Tema pe care ne-am propus sa o alegem este “Hospital Database”. Ca alta optiune ar fi fost “International Space
Station Administration Database”, insa tema ar fi fost prea complexa si prin urmare am ales aceasta tema cu
impresia ca ar fimai simplu de implementat.

Suntem 3 in echipa, si am considerat ca structura bazei de date sa fie compusa din 15 tabele:

- Patients: descrie pacientii spitalului.
- Doctors: descrie staff-ul medical care sunt experti in anumite arii ale medicinei
- Treatments: delibereaza tratamente de catre doctori pentru anumiti pacienti in urma unei consultatii/diagnostic
- Rooms: descrie starea camerei (daca este ocupata sau nu, si de ce pacienti sunt ocupate max 2)
- OperationTheaters: descrie starea salilor de operatii (ce pacient se afla in respectiva sala si ce doctori ii opereaza)
- ICUs: ...
- Nurses: lista de asistenti medicali
- Wardboys: lista de paznici
- Bills: facturarea pacientilor in urma unor operatii sau diagnosticari
- Medicines: lista de medicamente
- Apprentices: lista de studenti de la medicina care fac practica in cadrul spitatului
- Purchases: lista de achizitii (ex: dezinfectante, sapunuri, antivirale, mancare)
- Storage: lista de cu rol de organizare logistic, lucruri pe care le detine deja spitalul
- Shifts: lista turelor pentru angajatii spitalului, inclusiv practicantii
- Partners: lista de parteneriate intre diferite institutii (ex: alte spitale, universitati, centre de cercetare)

Ca lista de atribute pentru fiecare tabel avem:

- Patients: ID(PK), Nume, Prenume, Varsta, Greutate, Sex, Ocupatie, Doctor(FK), Tratament(FK), Sala asociata(FK)
- Doctors: ID(PK), Nume, Prenume, Studii(PHD, etc.), Specializare, Varsta, Sex, Pacienti(FK)
- Treatments: ID(PK), Denumire, Medicamente(FK), Patients(?), Durata
- Rooms: ID(PK), Numar, Etaj
- OperationsTheaters: ID(PK), Specializare(chirurgie, radiologie, etc.), Numar, Etaj
- ICUs: ID(PK), Numar, Etaj, +inca ceva(nu stim acum)
- Nurses: ID(PK), Nume, Prenume, Varsta, Studii, Sex, Pacienti(FK)
- Wardboys: ID(PK), Nume, Prenume, Varsta, Sex, Zona de responsabilitate
- Bills: ID(PK), Denumire, Suma, Pacient(FK)
- Medicines: ID(PK), Denumire, Data de expriare, Furnizor
- Apprentices: ID(PK), Nume, Prenume, Varsta, Sex, Universitate, An de studiu, Specializare, Doctor/Mentor(FK)
- Purchases: ID(PK), Denumire, Suma, Cantitate
- Shift: ID(PK), Begin, Ends
- Partners: ID(pk), Denumire_institutie, tip_parteneriat, begin_partnership, end_partnership
