CREATE TRIGGER [TriggerPartnersDate]
	ON [dbo].[Partners]
	AFTER INSERT
	AS
	BEGIN
		SET NOCOUNT ON

		IF EXISTS (
			SELECT id
			FROM [dbo].[Partners]
			WHERE id IN (SELECT id FROM INSERTED)
				AND begin_date > end_date
		)
		BEGIN
			RAISERROR ('Invalid partnership dates inserted; TODO transaction must be rolled back', 16, 1);
			RETURN;
		END
	END
