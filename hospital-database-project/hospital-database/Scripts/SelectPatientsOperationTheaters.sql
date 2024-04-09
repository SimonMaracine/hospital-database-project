USE [hospital-database]
GO

SELECT 
    CONCAT(P.first_name, ' ', P.last_name) AS PatientFullName,
    OT.number AS RoomNumber,
    OT.floor AS RoomFloor,
    OT.specialization AS OTSpecialization,
    R.type AS RoomType,
    R.id AS RoomID
FROM 
    Patients AS P
JOIN 
    OperationTheaters AS OT ON P.room_id = OT.number
JOIN 
    Rooms AS R ON OT.number = R.id;
