CREATE TABLE [dbo].[Degree] (
    [Id]     INT           IDENTITY (1, 100) NOT NULL,
    [Degree] NVARCHAR (50) NOT NULL,
    [Years]  INT           DEFAULT ((3)) NOT NULL,
    CONSTRAINT [PK_Degree] PRIMARY KEY CLUSTERED ([Id] ASC)
);

