CREATE TABLE [dbo].[Adresse] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [CP]          INT           NOT NULL,
    [Num]         INT           NOT NULL,
    [Rue]         VARCHAR (255) NOT NULL,
    [Pays]        VARCHAR (255) NOT NULL,
    [CGLatitude]  FLOAT (53)    NOT NULL,
    [CGLongitude] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

