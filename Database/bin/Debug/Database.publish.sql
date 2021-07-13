/*
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
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET PAGE_VERIFY NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Création de [dbo].[GetPostSalt]...';


GO
CREATE FUNCTION [dbo].[GetPostSalt]
(
)
RETURNS NCHAR(2048)
AS
BEGIN
	RETURN N'%QAV8&w*ep6SC=9LXY$qc!rREjk?Q8m!?hWbfW#*VF!Yq&mqC$+@+49v%%ySXSQ7DQ9JqEudpqB_r7*ma@4G-RZ=@tVUEjKNg2t+y8&_^4WmEN3Vg7HEv%BxR=K-3ubU2CEQ5-wDYn8WJY=?gKFW^RungZUZZ-zuNaYnqzWE-yQs2MMPq_6^dm7WkAxgGdeFFnr=SLD9VhM7u88gV6hp99EMJ&%gEvnJL^WfAhQndbzD&3X3Hhsx$QMMvMwRZ$Q&B7Qu7V8bQncxC=6RP^#epKA%VQYZp&2n7pNSp2pDVRFyewNGHx+59z+wDxWD9QRnxG%t^?!pak^5d9&8vRCntTJP%xuTfzZGxxT!&^4bCgjd^^pYXX33J@mw7REN#nBbPcDtn3EyRwh8SdQ-GK2BW$?_+ddp^k*=nwEa974mH&k*nygbEX4&Z4&QT+?_WS=+dK7tdK=#7^qmTRxjKNY=*+r9%8gcxMnr-rB4mFm2DwESmw!^Q7ufzVzaCjb-kw8!QV+SKWn&jt?-4nQLqhQQC@QP5%veaeHV$^-K$@9f6@=qyw!$JxPjmCs#_xb7a2xUjzWE_?N!A9ypBXQbq^ud+$Nz5Zh=fChhGHUPCHZQvu7sVBwg8Y-$6?u6JW#wFDFMH33wEa3LEELttbU?dx7sHCnSBx9smra5c5PByYDzvAS+tr_aejrN=NxMxf+2+m9x-x3Y*?ZQf&XS83B=mD2n2yx8qZMCRQrSGyEE@9Pqr-wYrGtLBD__p34@N#$B3nH&QPuMW8Vqz7w5Lxa?H9D7C3g^C3YXbbZTgxFCF+?kq@%X^GA8Mq#2^Nk9+#!w6YU4$5npYy3#?A&Kpv4YjYs?Kj&HH#+DVfU^gxxckmSu+jTkh5Fzb8v8xNyGs6Va$T6s7TPggKgcLKM!qp6VqXuLnLhY=&*qkjCTk$2w+nmB9C*GN2!JAA@7QgcR$AbB@jV6__Rwb%JQ?s7EHZ?XJW@s&ht$!qm3B$Y$fVCgFWPuCpT5^ra$JKJ!3$k^+9JSM&deMD@rdaP3!^FQWQ=D$&AaCT$*$Dvcv=A%?pz-cdqyf8tqJmCsF?JuFKc_-qAztc-eWVFtJRfbYd^e+UPRwaP7V9+W%$Jf!P3XRYzZLpCDHR#u!gjhV*_KE$pBKgYJa@a6^-c&pE=$4MKK8RxBNHGg&@EkbzW?BhWRzgB8=mqCN&YpMMxP4GgXj4gT!yGz^C*+_e=@wj8^tfLCyfzXLF*vWvkGg35S2k669B9h=6g?+bqu!5!Qry5e!BPVnZ%JPzws5aZcPPDhHvwJ?u+h?3%_7&_Ek=XPHWQ39MjR-M66LNFGEck#+tczcEws=fLz#qH2jMx3hpkeG%?A5&aCC@$#yQtxCQnX&VQV#ubqFv4?QPCUuWHb?dj?3fEk!h+U$v?F$4JMufC=WB4sL#GJ9TvBht3p=aN?C=+GpE*fxYe%g=7bh%Fc3sVJAGyRPV8ZH!Bt-vy7jxh#$C=vAdastKXJ8mSmY&pJsD2TK39jZLL=n5=nqWMUj-2dvP+8s-8Pmvm%N7&ZW*-s@$kZ2_5f7tw3DF%SV?hHcvSSKNfr8Rty8q$VxtPaZY@q_pRagGcKfbhnTW6ju-BELj&vGxxNZYyzxKpYGScsEB_37$Bnt!p@NdC@7VfmsCxN8_V_tKMj&9nt29fsGAUtr9X+S^q95XuE-CC@!dnhcKS-FBss-DRw-YHye*5*uwEG$@LAqdHrY*MS%Kf*qkr84xvzEgrcHU*B*8jVk=SdpRfRb%z4GK*!n?#Z=p#Bq@bN^nXMy$?V6wzgwu?QjLLXHP*d4bF*Ur2B?jF^npu4*bu$hHJU6fkdvGq&qfMC+*^Vgm$nkwQjHzxXT^pGEW$@#exT8RhL+f%kX%RZ$Rbter4BMp?*7rPzf4#xYky3UznUq37xwpuK+A#SE9e8AkKs%w=^+F?9m4hPRmyW%j%pqFYSRG8q7b*xEJuBFHxu8F2Nbayj#UAj_A_PCYGFG3sJ-gMB8X%*GDstbn4FnVCgN6EE38t4wtDPpxuS=$47$e+!v$JvZvBKMzRB';
END
GO
PRINT N'Création de [dbo].[GetPreSalt]...';


GO
CREATE FUNCTION [dbo].[GetPreSalt]
(
)
RETURNS NCHAR(2048)
AS
BEGIN
	RETURN N'MC+bqB3akr^JP$as!7z+Zq3$ZU7hxpvVTn5YpuB2+f4AUg@VcZUTX&ws@E6wz8qDW^ZkQQTY#N&@gs2ufZH-NK54qnYaB9VrW^c@TZmLAVb8a*JqPrHCz?kE-ZV?2yuZW-WN+K#cd@cfW?2CyWa-&d@RzA+ytPba?UZcuSxDu%Bj_JbXDktBk5hfyKTj@7uq%_*fenXCN396!7sHVxwZFKSRAPNMt*s3a@eqAhmxD@6?@B8kEGyWxwH+MX_8VXajUZHdZxTcjpCg@Xy2dsfC$sw#YwPGwKRyNp2#AFrT7pDJWSDx4XWvz2*9dRA7MPpqb5=kA@bre-jg2R%P2H7zmg9LpH%99Mg$?9$Hk?XPN@D6B%9Sp*q_2mjY8FdDKr!GTatNG_ucyz^4BczUZG*hKp$Kf$tPH@r_=BvjXvVRs856nUdM-?Va5Swu=LaETFHqfs?Xkx7HAqX=sqQdX%-L8+qpw&%UB+4rcte&$Y%B@A8H_F5mn_5qU=EHeHS--AZ3nWeY5SdWfhE#bxfYD#sLLZm#Nsm2Ke5GFARbWMUTNK8Qd@usAcAEpwp^-gc53m_pBDj6V+tm9e52BG7ehPnut?mj*6^wSh3R+FtRkKWvkdjVxL_zpAaTMNS$BMh-xfQh-^U6zuYtFULaUqhQu4PjR5Yp^WeUARNjh7Y%&Rej&XLzx5_nCB%48zutjRgLgdG4UZ&g!Sdcq2@y^FW9V+S&7wL_Ee-f3?vgeuT6CAKq?D8BFj5-c3YFqjrYmvu95uFEH@q+drjCrd%!6uZa!8MUnPpDxGBX$+K?rbWUYgxk6b=X^PB^Vnh#J2Dg&mGWWNs%d_s2+qguCmVEL6T!2=kP8qj5Ts8*BZW=V4j?38uqFmJKadd+=jz-+Jex3bQFp#w+GYdP#q^yfMcrLHV_RMa^qH#Zsu@E_+rwj@UYv$H=tCTSzcjW*-rH4VdsSB_wPG3PcF7NbCFeebrCTLbcAfV!YVzw?+BdABXbVk3W5QgHz2reyHQHFeDk32@MvMNecKNhLYtKW=G!jE65A6PhAeM$cbaJLjj6J25Z*yq%$G4?kV-AszPC?SnCfQ6CpYeqf7%?hu4G9uqZj8#@XB-v2S#*qufj7skwHCg9XdmUN33x%sY2hMb*#Y6+SAA$yGYbvXc2x%HFeAkE%+EddBHkYQ5^!f!&Y_=8k45bC8S*Z6NQZnZ?Ju#Cbyhf?+MTcvNWMfb%LRsZ=hge4ZH@K$z^bB=8bUQM+p?@-9QFPXWS#HT3N+cy?h-hsVR&B^8kXzecWwk?H#+6buh_meaEj8K7NtC#TGZ8w__M_v2vK?=p@Bg-Ww&R2tJX&^ENzqM^dTSQVdQ4zdJ*H+G3CPcxjnX_=zxDS&Zjs?dRuMX$86RFkz?^BVbUk-h3S7Dd-*TV8W4yyr9hg6A?UTer-*VDuEJMD!6bJs!!zAraz3y=UC%pyA8Y2Rwgu9K6$@KT8YN+hpE^S=as3R^K+JD5R-eXmW_8s5+ngvc*DHw&a9!pz8t!HZ7s^7Gs+YYvb6NJJnXP*8KtR^C?Bq87*EL#?Ktm&%h6Jn3VLu3uZk#@Fy_6atKtQH9pU?G&5z8RmKKx@ttrThYm8dcw2yM&gUXzkc=4JN?pwD9Nxd^&zV6s4Cqpw$#&Q4JJHyh$5mcbAMNSk*SybkXaJPyt33@T_!6bv4BL4zM@HfaewC*8#@Bt^8Pf3Cs+P$hk-EfRVRWrs+W$Ly?nnBk7qJk=*K5dkh%hrwGjSJmzcTb!pAzC@8&tLPFXv8Dvjr2wfB^CWLmSjnLDBpA5A7?89Gk&!vYUezhxJEcbXL28f!UAeum424*#Qj$xeWfRWMaam6-jR5R^jL4f_g8GN=YBp@mZB6!E&6ajbm_5sEm53e9khZ7PxwF^#&!k@&6TkuVYHETrN+Mu$J2XkqEEzC-75bU=*rML=A#sTJcXL+AMS@WFxR6X365GB$-Xp#kF%zLqp9!ZC3Z!Wtu5+2HxeUpEg7kxYcLP4PA97k7?SKu_SYZk_VVV582#HVN$wF3e%hM!eEE_Dggfx_aqf%kxegz=*5&4';
END
GO
PRINT N'Création de [dbo].[CheckUser]...';


GO
CREATE PROCEDURE [dbo].[CheckUser]
	@AdresseMail nvarchar(320),
	@MotDePasse varchar(20)
AS
Begin
	SELECT * --Id, Nom, Prenom, AdresseMail, RoleId
	from [Utilisateur] 
	where AdresseMail = @AdresseMail and MotDePasse = HASHBYTES('SHA2_512', dbo.GetPreSalt() + @MotDePasse + dbo.GetPostSalt());
End
GO
PRINT N'Création de [dbo].[RegisterUser]...';


GO
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
GO
PRINT N'Mise à jour terminée.';


GO
