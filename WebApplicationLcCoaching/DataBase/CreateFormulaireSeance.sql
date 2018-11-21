USE [Lc_coatching]
GO

/****** Objet : Table [dbo].[Formulaire_Seance] Date du script : 21/11/2018 07:47:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Formulaire_Seance] (
    [Id]                           INT            NOT NULL,
    [Id_user]                      INT            NOT NULL,
    [Test_condition_physique]      NVARCHAR (MAX) NULL,
    [Niveau_technique_musculation] NVARCHAR (MAX) NULL,
    [Gainage]                      NVARCHAR (MAX) NULL,
    [Posture]                      NVARCHAR (MAX) NULL,
    [Bilan_sanguin]                NVARCHAR (50)  NULL,
    [Tour_taille]                  NVARCHAR (50)  NULL,
    [Contrat]                      NVARCHAR (MAX) NULL,
    [Photos]                       IMAGE          NULL
);


