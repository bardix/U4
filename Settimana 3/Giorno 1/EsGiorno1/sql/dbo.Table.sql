CREATE TABLE [dbo].Cliente
(
	[IdCliente] INT NOT NULL PRIMARY KEY, 
    [Nome] NCHAR(10) NULL, 
    [Cognome] NCHAR(10) NULL, 
    [DataNascita] DATETIME NULL, 
    [Sesso] CHAR(10) NULL, 
    [CF] NCHAR(10) NULL, 
    [P.IVA] NVARCHAR(MAX) NULL, 
    [Attivo] NCHAR(10) NULL, 
    [Saldo] NCHAR(10) NULL
)
