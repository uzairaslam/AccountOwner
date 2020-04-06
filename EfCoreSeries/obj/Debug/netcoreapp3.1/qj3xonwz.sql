IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Student] (
    [StudentId] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Age] int NULL,
    [IsRegularStudent] bit NOT NULL DEFAULT CAST(1 AS bit),
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200404065355_InitialMigration', N'3.1.3');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [Name])
VALUES (1, 30, N'John Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [Name])
VALUES (2, 25, N'Jane Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [Name])
VALUES (4, 28, N'Mike Miles');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200405210021_AdditionalRowInserted', N'3.1.3');

GO

