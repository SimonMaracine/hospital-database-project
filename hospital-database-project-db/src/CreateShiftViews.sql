/* Doctors */
CREATE VIEW DoctorsShiftsView AS
SELECT 
    d.id AS DoctorID,
    CONCAT(d.first_name, ' ', d.last_name) AS DoctorName,
    s.description AS ShiftDescription
FROM Doctors d
INNER JOIN Employees e ON d.id = e.id
INNER JOIN Shifts s ON e.shift_id = s.id;
GO

SELECT * from DoctorsShiftViews ORDER BY DoctorName ASC
GO

/* Watchmen */
CREATE VIEW WatchmenShiftsView AS
SELECT 
    w.id AS WatchmanID,
    CONCAT(w.first_name, ' ', w.last_name) AS WatchmanName,
    s.description AS ShiftDescription
FROM Watchmen w
INNER JOIN Employees e ON w.id = e.id
INNER JOIN Shifts s ON e.shift_id = s.id;
GO

SELECT * from WatchmenShiftViews ORDER BY WatchmanName ASC
GO

/* Nurses */
CREATE VIEW NursesShiftsView AS
SELECT 
    n.id AS NurseID,
    CONCAT(n.first_name, ' ', n.last_name) AS NurseName,
    s.description AS ShiftDescription
FROM Nurses n
INNER JOIN Employees e ON n.id = e.id
INNER JOIN Shifts s ON e.shift_id = s.id;
GO

SELECT * FROM NursesShiftsView ORDER BY NurseName ASC
GO