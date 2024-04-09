USE [hospital-database]
GO

SELECT 
    CONCAT(P.first_name, ' ', P.last_name) AS PatientFullName,
    IC.number AS RoomNumber,
    IC.type AS ICUType,
    R.type AS RoomType,
    R.id AS RoomID
FROM 
    Patients AS P
JOIN 
    ICUs AS IC ON P.room_id = IC.number
JOIN 
    Rooms AS R ON IC.number = R.id;
