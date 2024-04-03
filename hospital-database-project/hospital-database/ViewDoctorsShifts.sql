CREATE VIEW ViewDoctorsShifts AS
SELECT 
    d.id AS DoctorID,
    CONCAT(d.first_name, ' ', d.last_name) AS DoctorName,
    s.description AS ShiftDescription
FROM Doctors d
INNER JOIN Employees e ON d.id = e.id
INNER JOIN Shifts s ON e.shift_id = s.id;
GO
