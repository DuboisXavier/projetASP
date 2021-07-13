CREATE TABLE [dbo].[Reservation] (
    [Id]                INT  NOT NULL,
    [DateDebut]         DATE NOT NULL,
    [DateFin]           DATE NOT NULL,
    [NombreDePersonnes] INT  NOT NULL,
    [UtilisateurId]     INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UtilisateurId]) REFERENCES [dbo].[Utilisateur] ([Id])
);

