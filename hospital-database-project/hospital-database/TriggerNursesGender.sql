CREATE TRIGGER [TriggerNursesGender]
	ON [dbo].[Nurses]
	AFTER INSERT
	AS
	BEGIN
		SET NOCOUNT ON

		IF EXISTS (
			SELECT id
			FROM [dbo].[Nurses]
			WHERE id IN (SELECT id FROM INSERTED)
				AND gender NOT LIKE 'M' AND gender NOT LIKE 'F'
		)
		BEGIN
			RAISERROR ('Invalid gender inserted; TODO transaction must be rolled back', 16, 1);
			RETURN;
		END
	END
