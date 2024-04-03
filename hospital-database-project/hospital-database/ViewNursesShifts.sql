CREATE VIEW ViewNursesShifts AS
SELECT 
    n.id AS NurseID,
    CONCAT(n.first_name, ' ', n.last_name) AS NurseName,
    s.description AS ShiftDescription
FROM Nurses n
INNER JOIN Employees e ON n.id = e.id
INNER JOIN Shifts s ON e.shift_id = s.id;
GO
