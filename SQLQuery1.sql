drop table [dbo].[SpartanDatabase];
CREATE TABLE [dbo].[SpartanDatabase] (
	[CourseId] INT IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (3) NULL,        
    [FirstName] NVARCHAR (20) NULL,
    [LastName] NVARCHAR (15) NULL,
	[University] NVARCHAR (20) NULL,
	[Course] NVARCHAR(25) NULL);
SET IDENTITY_INSERT SpartanDatabase ON
INSERT INTO [dbo].[SpartanDatabase] ([CourseId],[Title], [FirstName], [LastName], [University], [Course]) VALUES (1,'Mr', 'Li','Dinh','Kingston','Nutrition')
INSERT INTO [dbo].[SpartanDatabase] ([CourseId],[Title], [FirstName], [LastName], [University], [Course]) VALUES (2,'Ms', 'JASPREET', 'Notsure', 'GREENWICH', 'SOFTWARE')
INSERT INTO [dbo].[SpartanDatabase] ([CourseId],[Title], [FirstName], [LastName], [University], [Course]) VALUES (3,'MR', 'SEB', 'DAVIS', 'BRISTOL', 'PHYSICS')
INSERT INTO [dbo].[SpartanDatabase] ([CourseId],[Title], [FirstName], [LastName], [University], [Course]) VALUES (4,'MR', 'LUTON', 'NOLU', 'TWELVE', 'ENGINERRING')
INSERT INTO [dbo].[SpartanDatabase] ([CourseId],[Title], [FirstName], [LastName], [University], [Course]) VALUES (5,'MR', 'EMAN', 'NOT HERE', 'BEDFORDSHIRE', 'BYE')
SET IDENTITY_INSERT SpartanDatabase OFF

select * from SpartanDatabase