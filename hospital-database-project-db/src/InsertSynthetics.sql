USE [hospital-database-project-db]
GO

INSERT INTO dbo.Watchmen
           (id
           ,first_name
           ,last_name
           ,age
           ,gender
           ,assigned_zone)
     VALUES
           ('1'
		   ,'rick'
		   ,'grimes'
		   ,'42'
		   ,'M'
		   ,'A Block'),
		   ('2'
		   ,'shane'
		   ,'walsh'
		   ,'44'
		   ,'M'
		   ,'A Block')
GO


