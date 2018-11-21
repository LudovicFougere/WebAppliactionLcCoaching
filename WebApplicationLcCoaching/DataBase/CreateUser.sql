USE [Lc_coatching]
GO

/****** Objet : Table [dbo].[Users] Date du script : 21/11/2018 07:46:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]          INT           NOT NULL,
    [Nom]         NVARCHAR (50) NOT NULL,
    [Prenom]      NVARCHAR (50) NOT NULL,
    [Age]         INT           NOT NULL,
    [Sexe]        NVARCHAR (10) NOT NULL,
    [Date_limite] DATETIME      NULL
);


