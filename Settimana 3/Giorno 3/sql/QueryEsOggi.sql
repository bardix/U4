--1. Numero totale degli ordini

SELECT COUNT(*) AS NumeroTotaleOrdini
FROM Orders;

--2. Numero totale di clienti

SELECT COUNT(*) AS NumeroTotaleClienti
FROM Customers;

--3. Numero totale di clienti che abitano a Londra

SELECT COUNT(*) AS NumeroClientiLondra
FROM Customers
WHERE City = 'London';

--4. La media aritmetica del costo del trasporto di tutti gli ordini effettuati

SELECT AVG(Freight) AS MediaCostoTrasporto
FROM Orders;

--5. La media aritmetica del costo del trasporto dei soli ordini effettuati dal cliente "BOTTM"

SELECT AVG(Freight) AS MediaCostoTrasportoBOTTM
FROM Orders
WHERE CustomerID = 'BOTTM';

--6. Totale delle spese di trasporto effettuate raggruppate per ID cliente

SELECT CustomerID, SUM(Freight) AS TotaleSpeseTrasporto
FROM Orders
GROUP BY CustomerID;

--7. Numero totale di clienti raggruppati per città di appartenenza

SELECT City, COUNT(*) AS NumeroClienti
FROM Customers
GROUP BY City;

--8. Totale di UnitPrice * Quantity raggruppato per ogni ordine

SELECT OrderID, SUM(UnitPrice * Quantity) AS TotaleOrdine
FROM [Order Details]
GROUP BY OrderID;

--9. Totale di UnitPrice * Quantity solo dell'ordine con ID = 10248

SELECT OrderID, SUM(UnitPrice * Quantity) AS TotaleOrdine
FROM [Order Details]
WHERE OrderID = 10248
GROUP BY OrderID;

--10. Numero di prodotti censiti per ogni categoria

SELECT CategoryID, COUNT(*) AS NumeroProdotti
FROM Products
GROUP BY CategoryID;

--11. Numero totale di ordini raggruppati per paese di spedizione (ShipCountry)

SELECT ShipCountry, COUNT(*) AS NumeroOrdini
FROM Orders
GROUP BY ShipCountry;

--12. La media del costo del trasporto raggruppati per paese di spedizione (ShipCountry)

SELECT ShipCountry, AVG(Freight) AS MediaCostoTrasporto
FROM Orders
GROUP BY ShipCountry;