CREATE TABLE [dbo].[Utilisateur] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Nom]         VARCHAR (255) NOT NULL,
    [Prenom]      VARCHAR (255) NOT NULL,
    [AdresseMail] VARCHAR (255) NOT NULL,
    [Telephone]   VARCHAR (255) NOT NULL,
    [MotDePasse]  VARCHAR (255) NOT NULL,
    [RoleId]      INT           NOT NULL,
    [AdresseId]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AdresseId]) REFERENCES [dbo].[Adresse] ([Id]),
    FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([Id])
);

