CREATE TABLE [dbo].[Utilisateur] (
    [Id]          INT           NOT NULL,
    [Nom]         VARCHAR (255) NOT NULL,
    [Prenom]      VARCHAR (255) NOT NULL,
    [AdresseMail] VARCHAR (255) NOT NULL,
    [Pays]        VARCHAR (255) NOT NULL,
    [Telephone]   INT           NOT NULL,
    [ModeDePasse] VARCHAR (255) NOT NULL,
    [RoleId]      INT           NOT NULL,
    [AdresseId]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AdresseId]) REFERENCES [dbo].[Adresse] ([Id]),
    FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([Id])
);

