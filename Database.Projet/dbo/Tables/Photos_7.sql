CREATE TABLE [dbo].[Photos] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Photos]    VARBINARY (1) NOT NULL,
    [ChambreId] INT           NOT NULL,
    [HotelId]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ChambreId]) REFERENCES [dbo].[Chambre] ([Id]),
    FOREIGN KEY ([HotelId]) REFERENCES [dbo].[Hotel] ([Id])
);

