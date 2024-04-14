CREATE PROCEDURE [dbo].[ProceduresCheckRooms]
	@room_number int
AS
	IF EXISTS (
		SELECT number from ICUs
		WHERE number = @room_number
	)
	BEGIN
		RAISERROR ('Room number already exists', 16, 1);
		RETURN 1;
	END

	IF EXISTS (
		SELECT number from OperationTheaters
		WHERE number = @room_number
	)
	BEGIN
		RAISERROR ('Room number already exists', 16, 1);
		RETURN 1;
	END
RETURN 0
