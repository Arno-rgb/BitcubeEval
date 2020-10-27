CREATE TABLE [dbo].[Lecturer]
(
[Lecturer_ID] [int] NOT NULL IDENTITY(1, 1000),
[FirstName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MiddleName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Forename] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Surname] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[FullName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[DOB] [date] NOT NULL,
[Email] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Degree] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[User Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Password] [nchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lecturer] ADD CONSTRAINT [PK__tmp_ms_x__088FAAAC4B1C3F07] PRIMARY KEY CLUSTERED  ([Lecturer_ID]) ON [PRIMARY]
GO
