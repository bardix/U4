CREATE TABLE [dbo].Operaio
(
	[IdDipendente] INT NOT NULL PRIMARY KEY, 
    [Nome] NCHAR(10) NULL, 
    [Cognome] NCHAR(10) NULL, 
    [CF] NCHAR(10) NULL, 
    [FigliACarico] NCHAR(10) NULL, 
    [Sposato] NCHAR(10) NULL, 
    [LivelloLavorativo] NCHAR(10) NULL, 
    [DescrizioneMansione] NCHAR(10) NULL, 
    [Salario] NCHAR(10) NULL
)
