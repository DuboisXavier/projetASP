CREATE TABLE [dbo].[Reservation] (
    [Id]                INT  IDENTITY (1, 1) NOT NULL,
    [DateDebut]         DATE NOT NULL,
    [DateFin]           DATE NOT NULL,
    [NombreDePersonnes] INT  NOT NULL,
    [UtilisateurId]     INT  NOT NULL,
    [ChambreId]         INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

