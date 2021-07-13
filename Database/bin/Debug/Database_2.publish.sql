﻿/*
Script de déploiement pour Projet

Ce code a été généré par un outil.
La modification de ce fichier peut provoquer un comportement incorrect et sera perdue si
le code est régénéré.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Projet"
:setvar DefaultFilePrefix "Projet"
:setvar DefaultDataPath "D:\Program Files\MSSQL15.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "D:\Program Files\MSSQL15.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Détectez le mode SQLCMD et désactivez l'exécution du script si le mode SQLCMD n'est pas pris en charge.
Pour réactiver le script une fois le mode SQLCMD activé, exécutez ce qui suit :
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Le mode SQLCMD doit être activé de manière à pouvoir exécuter ce script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Création de [dbo].[CreationUtilisateur]...';


GO
CREATE PROCEDURE [dbo].[CreationUtilisateur]
@Nom varchar(50),
@Prenom varchar(50),
@Telephone varchar(50),
@AdresseMail varchar(50),
@MotDePasse float,
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
VALUES (@CP, @Num, @Rue, @Ville, @Pays, @CGLatitude, @CGLongitude)    
SELECT @AdresseId =  IDENT_CURRENT('Adresse')    
INSERT INTO Utilisateur(Nom, Prenom, AdresseMail, Telephone, MotDePasse, Roles, AdresseId) 
VALUES (@Nom, @Prenom, @AdresseMail, @Telephone, @MotDePasse, @Roles, @AdresseId)

 

END
GO
PRINT N'Mise à jour terminée.';


GO
