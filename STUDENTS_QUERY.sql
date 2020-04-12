USE [Faridun]
GO

INSERT INTO [dbo].[Students]
           ([ID]
           ,[Name]
           ,[Surname]
           ,[PhoneNumber]
           ,[HomeAdress])
     VALUES
           ('1'
           ,'Фаридун'
           ,'Бердиев'
           ,'+992901915905'
           ,'Сино 12/2')
GO


SELECT * FROM dbo.Students