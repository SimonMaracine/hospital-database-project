USE [hospital-database]
GO

SELECT 
    CONCAT(Patients.first_name, ' ', Patients.last_name) AS PatientFullName,
    ICUs.number AS RoomNumber,
    ICUs.type AS ICUType,
    Rooms.type AS RoomType,
    Rooms.id AS RoomID
FROM 
    Patients
JOIN 
    ICUs ON Patients.room_id = ICUs.room_id
JOIN
    Rooms ON ICUs.room_id = Rooms.id
