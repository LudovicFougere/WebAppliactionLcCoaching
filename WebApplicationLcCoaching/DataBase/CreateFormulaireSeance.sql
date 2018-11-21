CREATE TABLE [dbo].[Formulaire_Seance]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_user] INT NOT NULL, 
    [Test_condition_physique] NVARCHAR(MAX) NULL, 
    [Niveau_technique_musculation] NVARCHAR(MAX) NULL, 
    [Gainage] NVARCHAR(MAX) NULL, 
    [Posture] NVARCHAR(MAX) NULL, 
    [Bilan_sanguin] NVARCHAR(50) NULL, 
    [Tour_taille] NVARCHAR(50) NULL, 
    [Contrat] NVARCHAR(MAX) NULL, 
    [Photos] IMAGE NULL,
	CONSTRAINT [FK_Users_Seance] FOREIGN KEY (Id_user) REFERENCES [Users]([Id])
)
