IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChecklistNorma]') AND type in (N'U'))
DROP TABLE [dbo].[ChecklistNorma]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Checklist]') AND type in (N'U'))
DROP TABLE [dbo].[Checklist]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Norma]') AND type in (N'U'))
DROP TABLE [dbo].[Norma]
GO

CREATE TABLE [dbo].[Checklist]
(
    [Id] INT NOT NULL IDENTITY(1,1), -- Primary Key column
    [Responsavel] VARCHAR(80) NOT NULL,
    [Area] TINYINT NOT NULL,
    RealizadoEm DATETIME NULL,
    Observacao VARCHAR(250) NULL
);
GO

CREATE TABLE [dbo].[Norma]
(
    Id INT NOT NULL IDENTITY(1,1),
    Codigo VARCHAR(6) NOT NULL, -- NR-99, NR-125
    Descricao VARCHAR(100),
    Area TINYINT NOT NULL,
    [Status] BIT NULL,
    IntegradoEm DATETIME NULL,
    Integracao VARCHAR(250) NULL
)
GO

CREATE TABLE [dbo].[ChecklistNorma]
(
    ChecklistId INT NOT NULL,
    NormaId INT NOT NULL,
    Atendido BIT NULL
)
GO

ALTER TABLE [dbo].[Checklist]
    ADD CONSTRAINT [PK_Checklist] PRIMARY KEY CLUSTERED ([Id])
GO

ALTER TABLE [dbo].[Norma]
    ADD CONSTRAINT [PK_Norma] PRIMARY KEY CLUSTERED ([Id])
GO

ALTER TABLE [dbo].[Norma]
    ADD CONSTRAINT AK_CodigoArea UNIQUE ([Codigo], [Area])
GO

ALTER TABLE [dbo].[ChecklistNorma]
    ADD CONSTRAINT [PK_ChecklistNorma] PRIMARY KEY CLUSTERED ([ChecklistId], [NormaId])
GO

ALTER TABLE [dbo].[ChecklistNorma]
    ADD CONSTRAINT [FK_Checklist] FOREIGN KEY (ChecklistId) REFERENCES [dbo].[Checklist]([Id])
GO

ALTER TABLE [dbo].[ChecklistNorma]
    ADD CONSTRAINT [FK_Norma] FOREIGN KEY (NormaId) REFERENCES [dbo].[Norma]([Id])
GO

