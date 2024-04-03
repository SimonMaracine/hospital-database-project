﻿CREATE TRIGGER [TriggerDoctorsGender]
	ON [dbo].[Doctors]
	AFTER INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON  /* Don't return number of rows affected */

		IF EXISTS (
			SELECT id
			FROM [dbo].[Doctors]
			WHERE id IN (SELECT id FROM INSERTED)
				AND gender NOT LIKE 'M' AND gender NOT LIKE 'F'
		)
		BEGIN
			RAISERROR ('Invalid gender inserted; TODO transaction must be rolled back', 16, 1);
			RETURN;
		END
	END
