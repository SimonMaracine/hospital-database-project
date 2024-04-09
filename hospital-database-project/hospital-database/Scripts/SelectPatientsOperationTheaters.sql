USE [hospital-database]
GO

SELECT 
    CONCAT(Patients.first_name, ' ', Patients.last_name) AS PatientFullName,
    OperationTheaters.number AS RoomNumber,
    OperationTheaters.floor AS RoomFloor,
    OperationTheaters.specialization AS OTSpecialization,
    Rooms.type AS RoomType,
    Rooms.id AS RoomID
FROM 
    Patients
JOIN 
    OperationTheaters ON Patients.room_id = OperationTheaters.room_id
JOIN 
    Rooms ON OperationTheaters.room_id = Rooms.id;
