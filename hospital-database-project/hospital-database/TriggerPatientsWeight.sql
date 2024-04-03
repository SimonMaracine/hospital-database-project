CREATE TRIGGER [TriggerPatientsWeight]
	ON [dbo].[Patients]
	AFTER INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON

		IF EXISTS (
			SELECT id
			FROM [dbo].[Patients]
			WHERE id IN (SELECT id FROM INSERTED)
				AND weight <= 0
		)
		BEGIN
			RAISERROR ('Invalid weight inserted; TODO transaction must be rolled back', 16, 1);
			RETURN;
		END
	END
