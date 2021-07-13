CREATE PROCEDURE [dbo].[CreationUtilisateur]
@Nom varchar(50),
@Prenom varchar(50),
@Telephone varchar(50),
@AdresseMail varchar(50),
@MotDePasse nvarchar(50),
@Roles varchar(50),
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
INSERT INTO Utilisateur(Nom, Prenom, AdresseMail, Telephone, MotDePasse, Roles, AdresseId) 
VALUES (@Nom, @Prenom, @AdresseMail, @Telephone, HASHBYTES('SHA2_512', dbo.GetPreSalt() + @MotDePasse + dbo.GetPostSalt()), @Roles, @AdresseId)

 

END
GO