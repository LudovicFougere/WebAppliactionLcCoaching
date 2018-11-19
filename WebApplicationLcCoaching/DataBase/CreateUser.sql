USE [Lc_coatching]
GO

/****** Objet : Table [dbo].[Users] Date du script : 19/11/2018 22:49:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]     INT           NOT NULL,
    [Nom]    NVARCHAR (50) NOT NULL,
    [Prenom] NVARCHAR (50) NOT NULL,
    [Age]    INT           NULL
);


