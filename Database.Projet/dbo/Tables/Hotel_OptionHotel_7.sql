CREATE TABLE [dbo].[Hotel_OptionHotel] (
    [HotelId]       INT NOT NULL,
    [OptionHotelId] INT NOT NULL,
    FOREIGN KEY ([HotelId]) REFERENCES [dbo].[Hotel] ([Id]),
    FOREIGN KEY ([OptionHotelId]) REFERENCES [dbo].[OptionHotel] ([Id])
);

