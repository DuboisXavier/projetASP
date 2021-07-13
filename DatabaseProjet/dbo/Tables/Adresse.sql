CREATE TABLE [dbo].[Adresse] (
    [Id]           INT           NOT NULL,
    [CP]           INT           NOT NULL,
    [Num]          INT           NOT NULL,
    [Rue]          VARCHAR (255) NOT NULL,
    [Pays]         VARCHAR (255) NOT NULL,
    [CG Latitude]  FLOAT (53)    NOT NULL,
    [CG Longitude] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

