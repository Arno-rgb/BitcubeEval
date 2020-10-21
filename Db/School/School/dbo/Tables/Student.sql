CREATE TABLE [dbo].[Student] (
    [Id]         INT           NOT NULL,
    [Student_ID] INT           IDENTITY (10000, 1) NOT NULL,
    [Forename]   NVARCHAR (50) NULL,
    [Surname]    NVARCHAR (50) NOT NULL,
    [DOB]        DATE          NOT NULL,
    [Email]      NVARCHAR (50) NOT NULL,
    [Degree]     NVARCHAR (50) NULL,
    [FirstName]  NVARCHAR (50) NULL,
    [FullName]   NVARCHAR (50) NULL,
    [MiddleName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

