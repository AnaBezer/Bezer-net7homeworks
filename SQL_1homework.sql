CREATE DATABASE MyHomeworkDataBase;

USE MyHomeworkDataBase;

CREATE TABLE Addresses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StreetName VARCHAR(100),
    StreetNumber INT,
    City VARCHAR(50),
);

CREATE TABLE Customers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150),
    Age INT,
    AddressId INT REFERENCES Addresses(Id)
);

CREATE TABLE Orders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Details VARCHAR(150),
    CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150)
);

CREATE TABLE Orders_Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT REFERENCES Orders(Id),
    ProductId INT REFERENCES Products(Id)
);

SELECT*
FROM Addresses;

SELECT*
FROM Customers;

SELECT*
FROM Orders;

SELECT*
FROM Products;

SELECT*
FROM Orders_Products;

-- Ex. 1 Insert at least 5 more records in each table. Pay attention to matching the data from one table to the data in another table.


INSERT INTO Addresses
VALUES ('Oxford', 10, 'London');
INSERT INTO Addresses
VALUES ('Victor Hugo', 11, 'Paris');
INSERT INTO Addresses
VALUES ('Harajuku', 18, 'Tokyo');
INSERT INTO Addresses 
VALUES ('Sukhumvit ', 15, 'Bangkok');
INSERT INTO Addresses 
VALUES ('Ostrogovitch', 17, 'Timisoara');

INSERT INTO Customers 
VALUES ('Mark', 30, 1);
INSERT INTO Customers 
VALUES ('Daniel', 35, 2);
INSERT INTO Customers 
VALUES ('Kenji', 40, 3);
INSERT INTO Customers 
VALUES ('Chen', 25, 4);
INSERT INTO Customers 
VALUES ('Ana', 20, 5);

-- DELETE FROM Customers;

INSERT INTO Orders  
VALUES ('1st order for Mark', 28);
INSERT INTO Orders 
VALUES ('2nd order for Mark', 28);
INSERT INTO Orders 
VALUES ('1st order for Daniel', 29);
INSERT INTO Orders 
VALUES ('1st order for Kenji', 30);
INSERT INTO Orders 
VALUES ('1st order for Chen', 31);
INSERT INTO Orders 
VALUES ('1st order for Ana', 32);

INSERT INTO Products 
VALUES ('brake pads');
INSERT INTO Products 
VALUES ('brake discs');
INSERT INTO Products 
VALUES ('wiper blades');
INSERT INTO Products 
VALUES ('wheel bearings');
INSERT INTO Products 
VALUES ('clutch kit');

INSERT INTO Orders_Products
VALUES (68, 1);
INSERT INTO Orders_Products
VALUES (68, 2);
INSERT INTO Orders_Products
VALUES (70, 3);
INSERT INTO Orders_Products
VALUES (71, 4);
INSERT INTO Orders_Products
VALUES (72, 5);
INSERT INTO Orders_Products
VALUES (73, 4);

SELECT*
FROM Addresses;

SELECT*
FROM Customers;

SELECT*
FROM Orders;

SELECT*
FROM Products;

SELECT*
FROM Orders_Products;

-- Ex. 2 Display all the Customers that are older than 15

SELECT Name, Age
FROM Customers
WHERE Age > 15 ;

-- Ex. 3 Display the total number of Addresses.

SELECT COUNT(*) AS TotalAddresses
FROM Addresses;

-- Ex. 4 Update the name of each Product to some other value.

UPDATE Products
SET Name = 
    CASE 
        WHEN Id = 1 THEN 'New Brake Pads'
        WHEN Id = 2 THEN 'Upgraded Brake Discs'
        WHEN Id = 3 THEN 'Advanced Wiper Blades'
        WHEN Id = 4 THEN 'Enhanced Wheel Bearings'
        WHEN Id = 5 THEN 'Improved Clutch Kit'  
    END
WHERE Id IN (1, 2, 3, 4, 5);

SELECT*
FROM Products;

-- Ex. 5 Alter the structure of one table by adding a new column.

ALTER TABLE Products 
ADD Price INT;

-- Ex. 6 Populate the value of the newly added column with relevant data.

UPDATE Products
SET Price = 
    CASE 
        WHEN Name = 'New Brake Pads' THEN 50
        WHEN Name = 'Upgraded Brake Discs' THEN 80
        WHEN Name = 'Advanced Wiper Blades' THEN 15
        WHEN Name = 'Enhanced Wheel Bearings' THEN 30
        WHEN Name = 'Improved Clutch Kit' THEN 120
    END;

SELECT*
FROM Products;

-- Ex. 7 Display all the customers' information together with their orders.

SELECT c.Name, c.Age, c.AddressId, o.Details
FROM Customers AS c
INNER JOIN Orders AS o ON c.Id = o.CustomerId;

SELECT*
FROM Customers;

SELECT*
FROM Orders;

-- Ex 8 Display all the customers' information together with their orders and their addresses.

SELECT c.Id, c.Name, c.Age, o.Details, a.StreetName, a.StreetNumber, a.City
FROM Customers AS c
INNER JOIN Orders AS o ON c.Id = o.CustomerId
LEFT JOIN Addresses AS a ON c.AddressId = a.Id
ORDER BY c.Id, o.Id;

SELECT*
FROM Customers;

SELECT*
FROM Orders;

SELECT*
FROM Addresses;

