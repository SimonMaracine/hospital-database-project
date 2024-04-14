CREATE TRIGGER [TriggerShiftsTime]
	ON [dbo].[Shifts]
	AFTER INSERT
	AS
	BEGIN
		SET NOCOUNT ON

		IF EXISTS (
			SELECT id
			FROM [dbo].[Shifts]
			WHERE id IN (SELECT id FROM INSERTED)
				AND begin_time > end_time
		)
		BEGIN
			RAISERROR ('Invalid shift time inserted; TODO transaction must be rolled back', 16, 1);
			RETURN;
		END
	END
