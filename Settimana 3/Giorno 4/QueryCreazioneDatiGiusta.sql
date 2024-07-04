INSERT INTO IMPIEGATO (Cognome, Nome, CodiceFiscale, Eta, RedditoMensile, DetrazioneFiscale) VALUES
('Rossi', 'Mario', 'RSSMRA85M01H501Z', 38, 2500.00, 1),
('Bianchi', 'Luca', 'BNCLCU80A01H501Y', 44, 2800.00, 0),
('Verdi', 'Giulia', 'VRDGLI90C50H501X', 33, 3100.00, 1),
('Neri', 'Francesca', 'NRIFNC78D60H501W', 46, 2700.00, 0),
('Gialli', 'Alessandro', 'GLLLSN85E01H501V', 39, 2900.00, 1),
('Blu', 'Simona', 'BLUSMN92F70H501U', 32, 2600.00, 1),
('Marroni', 'Stefano', 'MRRSTF75G80H501T', 48, 3500.00, 0),
('Rossi', 'Luisa', 'RSSLSI87H90H501S', 36, 2400.00, 1),
('Bianchi', 'Anna', 'BNCNNA95I80H501R', 29, 2200.00, 0),
('Verdi', 'Marco', 'VRDMRC82L10H501Q', 41, 3300.00, 1);


INSERT INTO IMPIEGO (TipoImpiego, Assunzione) VALUES
('Full-time', '2007-01-15 09:00:00'),
('Part-time', '2010-03-22 10:00:00'),
('Contratto a progetto', '2007-06-30 08:30:00'),
('Apprendistato', '2008-09-01 09:30:00'),
('Tempo determinato', '2007-01-10 11:00:00'),
('Part-time', '2008-05-14 14:00:00'),
('Full-time', '2007-07-01 09:00:00'),
('Contratto a progetto', '2010-10-25 15:00:00'),
('Full-time', '2015-02-10 09:30:00'),
('Tempo determinato', '2010-08-20 10:30:00');

-- a. Visualizzare tutti gli impiegati oltre i 29 anni

SELECT * FROM IMPIEGATO WHERE Eta > 29;

-- b. Visualizzare tutti gli impiegati con un reddito di almeno 800 euro mensili

SELECT * FROM IMPIEGATO WHERE RedditoMensile >= 800;

-- c. Visualizzare tutti gli impiegati che posseggono la detrazione fiscale

SELECT * FROM IMPIEGATO WHERE DetrazioneFiscale = 1;

-- d. Visualizzare tutti gli impiegati che non posseggono la detrazione fiscale

SELECT * FROM IMPIEGATO WHERE DetrazioneFiscale = 0;

-- e. Visualizzare tutti gli impiegati cui il cognome cominci con una lettera G e li visualizzi in ordine alfabetico

SELECT * FROM IMPIEGATO WHERE Cognome LIKE 'G%' ORDER BY Cognome;

-- f. Visualizzare il numero totale degli impiegati registrati nella base dati

SELECT COUNT(*) AS NumeroImpiegati FROM IMPIEGATO;

-- g. Visualizzare il totale dei redditi mensili di tutti gli impiegati

SELECT SUM(RedditoMensile) AS TotaleRedditiMensili FROM IMPIEGATO;

-- h. Visualizzare la media dei redditi mensili di tutti gli impiegati

SELECT AVG(RedditoMensile) AS MediaRedditiMensili FROM IMPIEGATO;

-- i. Visualizzare l’importo del reddito mensile maggiore

SELECT MAX(RedditoMensile) AS RedditoMassimo FROM IMPIEGATO;

-- j. Visualizzare l’importo del reddito mensile minore

SELECT MIN(RedditoMensile) AS RedditoMinimo FROM IMPIEGATO;

-- k. Visualizzare gli impiegati assunti dall’01/01/2007 all’01/01/2008

SELECT * FROM IMPIEGATO AS e JOIN IMPIEGO AS i ON e.IDImpiegato = i.IDImpiegato
WHERE i.Assunzione BETWEEN '2007-01-01' AND '2008-01-01';

-- l. Tramite una query parametrica che identifichi il tipo di impiego, visualizzare tutti gli impiegati che corrispondono a quel tipo di impiego
-- Ad esempio, per il tipo di impiego 'Full-time'

SELECT * FROM IMPIEGATO AS e JOIN IMPIEGO AS i ON e.IDImpiegato = i.IDImpiegato
WHERE i.TipoImpiego = 'Full-time';

-- m. Visualizzare l’età media dei lavoratori all’interno dell’azienda

SELECT AVG(Eta) AS EtaMedia FROM IMPIEGATO;