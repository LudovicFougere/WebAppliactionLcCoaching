USE [Lc_coatching]
GO

/****** Objet : Table [dbo].[Formulaire_Init] Date du script : 20/11/2018 21:19:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Formulaire_Init] (
    [Id]                          INT        NOT NULL,
    [Id_user]                     INT        NOT NULL,
    [Poids]                       FLOAT (53) NULL,
    [Pourcent_graisse_corporelle] FLOAT (53) NULL,
    [Masse_musculaire]            FLOAT (53) NULL,
    [Dej]                         FLOAT (53) NULL,
    [Age_metabolique]             INT        NULL,
    [Pourcent_hydratation]        FLOAT (53) NULL,
    [Masse_osseuse]               FLOAT (53) NULL,
    [Imc]                         FLOAT (53) NULL,
    [Graisse_visterale]           FLOAT (53) NULL
);


