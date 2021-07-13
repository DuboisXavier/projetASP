CREATE TABLE [dbo].[Supprime] (
    [Id]             INT  IDENTITY (1, 1) NOT NULL,
    [DateSuppresion] DATE NOT NULL,
    [UtilisateurId]  INT  NOT NULL,
    [ChambreId]      INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

