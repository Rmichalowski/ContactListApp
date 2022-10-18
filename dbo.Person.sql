CREATE TABLE [dbo].[Person] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [name]     NVARCHAR (MAX) NOT NULL,
    [surname]  NVARCHAR (MAX) NOT NULL,
    [email]    NVARCHAR (MAX) NOT NULL,
    [password] NVARCHAR (MAX) NOT NULL,
    [category] INT            NOT NULL,
    [phone]    INT            NOT NULL,
    [dob]      DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
);

