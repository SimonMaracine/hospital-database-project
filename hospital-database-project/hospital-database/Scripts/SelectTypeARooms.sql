USE [hospital-database]
GO

DECLARE @FloorNumber INT = 2

SELECT
    R.id as RoomID,
    R.type as RoomType,
    OT.floor as RoomFloor,
    OT.number as OTRoomNumber,
    OT.specialization as OTSpecialization
FROM
    [dbo].[Rooms] R
JOIN
    [dbo].[OperationTheaters] OT ON R.id = OT.room_id
WHERE
    OT.floor = @FloorNumber;
