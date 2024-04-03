CREATE VIEW ViewWatchmenShifts AS
SELECT 
    w.id AS WatchmanID,
    CONCAT(w.first_name, ' ', w.last_name) AS WatchmanName,
    s.description AS ShiftDescription
FROM Watchmen w
INNER JOIN Employees e ON w.id = e.id
INNER JOIN Shifts s ON e.shift_id = s.id;
GO
