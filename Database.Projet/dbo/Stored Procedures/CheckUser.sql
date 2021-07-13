CREATE PROCEDURE [dbo].[CheckUser]
	@AdresseMail nvarchar(320),
	@MotDePasse varchar(20)
AS
Begin
	SELECT * --Id, Nom, Prenom, AdresseMail, RoleId
	from [Utilisateur] 
	where AdresseMail = @AdresseMail and MotDePasse = HASHBYTES('SHA2_512', dbo.GetPreSalt() + @MotDePasse + dbo.GetPostSalt());
End