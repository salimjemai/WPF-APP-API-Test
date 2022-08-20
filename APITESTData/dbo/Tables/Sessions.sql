CREATE TABLE [dbo].[Sessions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SessionToken] NVARCHAR(128) NOT NULL, 
    [DateCreated] DATETIME2 NOT NULL, 
    [IsTokenValid] INT NOT NULL DEFAULT 0, 
    [CreatedBy] NVARCHAR(128) NOT NULL, 
    [CwsUrl] NVARCHAR(512) NOT NULL DEFAULT getutcdate(), 
    [SchemaAlias] NVARCHAR(50) NOT NULL
)
