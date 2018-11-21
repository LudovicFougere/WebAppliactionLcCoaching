CREATE TABLE [dbo].[Formulaire_Init]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_user] INT NOT NULL, 
    [Poids] FLOAT NULL, 
    [Pourcent_graisse_corporelle] FLOAT NULL, 
    [Masse_musculaire] FLOAT NULL, 
    [Dej] FLOAT NULL, 
    [Age_metabolique] INT NULL, 
    [Pourcent_hydratation] FLOAT NULL, 
    [Masse_osseuse] FLOAT NULL, 
    [Imc] FLOAT NULL, 
    [Graisse_visterale] FLOAT NULL,
	CONSTRAINT [FK_Users_Init] FOREIGN KEY (Id_user) REFERENCES [Users]([Id])
)
