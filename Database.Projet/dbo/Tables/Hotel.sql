CREATE TABLE [dbo].[Hotel] (
    [Id]               INT           NOT NULL,
    [Nom]              VARCHAR (255) NOT NULL,
    [Nombre d'etoile]  INT           NOT NULL,
    [Telephone]        INT           NOT NULL,
    [Email]            VARCHAR (255) NOT NULL,
    [NombreDeChambres] INT           NOT NULL,
    [AdresseId]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AdresseId]) REFERENCES [dbo].[Adresse] ([Id])
);

