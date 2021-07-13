CREATE TABLE [dbo].[Hotel] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Nom]           VARCHAR (255) NOT NULL,
    [NombreEtoile]  INT           NOT NULL,
    [Telephone]     VARCHAR (255) NOT NULL,
    [Email]         VARCHAR (255) NOT NULL,
    [NombreChambre] INT           NOT NULL,
    [AdresseId]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AdresseId]) REFERENCES [dbo].[Adresse] ([Id])
);

