CREATE DATABASE ZooManagement;

USE ZooManagement;

CREATE TABLE Species
(
    Id INT IDENTITY (1, 1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);

CREATE TABLE Enclosures
(
    Id INT IDENTITY (1, 1) PRIMARY KEY,
    Name VARCHAR(50),
    Type VARCHAR(50),
    Capacity INT
);

CREATE TABLE Animals
(
    Id INT IDENTITY (1, 1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Gender VARCHAR(10),
    EnclosureId INT,
    SpeciesId INT REFERENCES Species(Id)
);

CREATE TABLE Employees
(
    Id INT IDENTITY (1, 1) PRIMARY KEY,
    FirstName VARCHAR(30),
    LastName VARCHAR(30),
    Role VARCHAR(30),
    EnclosureId INT REFERENCES Enclosures(Id)
);

CREATE TABLE Tickets
(
    Id INT IDENTITY (1, 1) PRIMARY KEY,
    Price DECIMAL(8, 2) NOT NULL,
    ValidityPeriod INT 
);

CREATE TABLE Visitors
(
    Id INT IDENTITY (1, 1) PRIMARY KEY,
    Name VARCHAR(60),
    VisitDate DATE,
    TicketId INT REFERENCES Tickets(Id)
);


INSERT INTO Species
VALUES ('Monkey'), ('Tiger'), ('Lion'), ('Bear'), ('Zebra');

INSERT INTO Enclosures
VALUES ('Monkey Habitat', 'Outdoor', 20), ('Big Cat Enclosure', 'Outdoor', 15), ('Bear Den', 'Indoor', 10);

INSERT INTO Animals 
VALUES ('Monkey1', 'Female', 1, 1);
INSERT INTO Animals 
VALUES ('Monkey2', 'Male', 1, 1);
INSERT INTO Animals 
VALUES ('Tiger1', 'Male', 2, 2);
INSERT INTO Animals 
VALUES ('Tiger2', 'Female', 2, 2);
INSERT INTO Animals 
VALUES ('Lion1', 'Male', 2, 3);
INSERT INTO Animals 
VALUES ('Bear1', 'Female', 3, 4);
INSERT INTO Animals 
VALUES ('Bear2', 'Male', 3, 4);
INSERT INTO Animals 
VALUES ('Zebra1', 'Female', 1, 5);
INSERT INTO Animals 
VALUES ('Zebra2', 'Male', 1, 5);
INSERT INTO Animals 
VALUES ('Monkey3', 'Female', 1, 1);

INSERT INTO Employees 
VALUES ('Andreea', 'Popescu', 'Zookeeper', 2), ('Bogdan', 'Mirciulescu', 'Zookeeper', 3);

INSERT INTO Tickets 
VALUES (15.00, 1), (50.00, 7), (150.00, 30);

INSERT INTO Visitors 
VALUES ('Ana Bezer', '2023-08-14', 1);
INSERT INTO Visitors 
VALUES ('Maria Duca', '2023-08-14', 2);
INSERT INTO Visitors 
VALUES ('Daniel Grosu', '2023-08-15', 1);

SELECT*
FROM Species;

SELECT*
FROM Enclosures;

SELECT*
FROM Animals;

SELECT*
FROM Tickets;

SELECT*
FROM Visitors;

SELECT COUNT(*) AS TotalAnimals FROM Animals;

SELECT Species.Name, COUNT(*) AS TotalSpecies FROM Animals
JOIN Species ON Animals.SpeciesId = Species.Id
GROUP BY Species.Name;

SELECT COUNT(*) AS TotalVisitors FROM Visitors WHERE VisitDate = '2023-08-14';

SELECT Enclosures.Name AS Enclosure, Employees.FirstName + ' ' + Employees.LastName AS Caretaker
FROM Employees
JOIN Enclosures ON Employees.EnclosureId = Enclosures.Id;