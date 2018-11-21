CREATE TABLE [dbo].[Users] (
    [Id]     INT           NOT NULL,
    [Nom]    NVARCHAR (50) NOT NULL,
    [Prenom] NVARCHAR (50) NOT NULL,
    [Age]    INT           NOT NULL,
	[Sexe]	 NVARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
    
);

