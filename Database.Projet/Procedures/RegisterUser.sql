CREATE PROCEDURE [dbo].[RegisterUser]
	@Nom nvarchar(50),
	@Prenom nvarchar(50),
	@AdresseMail nvarchar(320),
	@Telephone varchar(20),
	@MotDePasse varchar(20),
	@Roles varchar(20),
	@AdresseId varchar(20)
AS
Begin
	Insert into [Utilisateur] ([Nom], [Prenom], [AdresseMail], [Telephone], [MotDePasse], [Roles], [AdresseId])
	Values (@Nom, @Prenom, @AdresseMail, @Telephone, HASHBYTES('SHA2_512', dbo.GetPreSalt() + @MotDePasse + dbo.GetPostSalt()), @Roles, @AdresseId);
End
