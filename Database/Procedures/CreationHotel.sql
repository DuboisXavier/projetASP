CREATE PROCEDURE [dbo].[CreationHotel]
@Nom varchar(50),
@NombreEtoile int,
@Telephone varchar(50),
@Email varchar(50),
@NombreChambre int,
@CP int,
@Num int,
@Rue varchar(50),
@Pays varchar(50),
@Ville varchar(50),
@CGLatitude float,
@CGLongitude float



 

AS
BEGIN    
DECLARE @AdresseId int  
INSERT INTO Adresse (CP, Num, Rue, Pays, Ville, CGLatitude, CGLongitude) 
VALUES (@CP, @Num, @Rue, @Pays, @Ville, @CGLatitude, @CGLongitude)    
SELECT @AdresseId =  IDENT_CURRENT('Adresse')    
INSERT INTO Hotel(Nom, NombreEtoile, Email, Telephone, NombreChambre, AdresseId) 
VALUES (@Nom, @NombreEtoile, @Email, @Telephone, @NombreChambre, @AdresseId)

 

END
GO