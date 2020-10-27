CREATE TABLE [dbo].[Degree]
(
[Degree] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Years] [int] NOT NULL CONSTRAINT [DF__Degree__Years__25869641] DEFAULT ((3))
) ON [PRIMARY]
GO
