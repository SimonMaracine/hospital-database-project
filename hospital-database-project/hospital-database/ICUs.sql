CREATE TABLE [dbo].[ICUs]
(
    [number] INT NOT NULL PRIMARY KEY,
    [floor] INT NOT NULL,
    [type] CHAR(64) NOT NULL,
    [room_id] INT UNIQUE NOT NULL,
    CONSTRAINT FK_ICU_room
    FOREIGN KEY (room_id) REFERENCES Rooms (id)
);
