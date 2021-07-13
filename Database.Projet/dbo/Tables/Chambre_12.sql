CREATE TABLE [dbo].[Chambre] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Numero]        INT           NOT NULL,
    [DescriptionC]  VARCHAR (255) NOT NULL,
    [DescriptionL]  VARCHAR (255) NOT NULL,
    [TypeDeChambre] VARCHAR (255) NOT NULL,
    [Capacite]      INT           NOT NULL,
    [NombreDeSDB]   INT           NOT NULL,
    [NombreDeWC]    INT           NOT NULL,
    [Prix]          FLOAT (53)    NOT NULL,
    [HotelId]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([HotelId]) REFERENCES [dbo].[Hotel] ([Id])
);

