CREATE TABLE [dbo].[Chambre_OptionChambre] (
    [ChambreId]       INT NOT NULL,
    [OptionChambreId] INT NOT NULL,
    FOREIGN KEY ([ChambreId]) REFERENCES [dbo].[Chambre] ([Id]),
    FOREIGN KEY ([OptionChambreId]) REFERENCES [dbo].[OptionChambre] ([Id])
);

