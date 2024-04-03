CREATE TABLE [dbo].[OperationTheaters]
(
    [number] INT NOT NULL PRIMARY KEY,
    [floor] INT NOT NULL,
    [specialization] CHAR(64) NOT NULL,
    [room_id] INT NOT NULL,
    CONSTRAINT FK_operation_theater_room
    FOREIGN KEY (room_id) REFERENCES Rooms (id)
);
