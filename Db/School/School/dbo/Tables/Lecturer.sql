CREATE TABLE [dbo].[Lecturer] (
    [Id]          INT           NOT NULL,
    [Lecturer_ID] INT           IDENTITY (10000, 1) NOT NULL,
    [Forename]    NVARCHAR (50) NULL,
    [Surname]     NVARCHAR (50) NOT NULL,
    [DOB]         DATE          NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [FirstName]   NVARCHAR (50) NULL,
    [FullName]    NVARCHAR (50) NULL,
    [MiddleName]  NVARCHAR (50) NULL,
    [Degree]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Lecturer_ID] ASC)
);

