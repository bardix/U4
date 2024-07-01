CREATE TABLE [dbo].Cantiere
(
	[IdCantiere] INT NOT NULL PRIMARY KEY, 
    [DenominazioneCantiere] NCHAR(10) NULL, 
    [Indirizzo] NCHAR(10) NULL, 
    [Città] NCHAR(10) NULL, 
    [CAP] NCHAR(10) NULL, 
    [PersonaRiferimento] NCHAR(10) NULL, 
    [DataInizioLavori] NCHAR(10) NULL, 
    [DataFineLavori] NCHAR(10) NULL, 
    [LavoriTerminatiSI_NO] NCHAR(10) NULL
)
