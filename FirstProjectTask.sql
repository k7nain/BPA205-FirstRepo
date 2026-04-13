CREATE DATABASE CompanyDB
USE CompanyDB

CREATE TABLE Employees
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	FullName NVARCHAR(50),
	Salary DECIMAL(10,2)
);

CREATE TABLE Departments
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	DeparmentName NVARCHAR(50)
);

ALTER TABLE Employees
ADD DepartmentID INT;


INSERT INTO Employees(FullName, Salary, DepartmentID) VALUES
('Kanan Mursalizada', 5500, 1),
('Omar Mirzayev', 3500, 2),
('Rovshan Ibrahimov', 4500, 3),
('Emin Sadigov', 2500, 3),
('Mehdi Shazbazli', 1500, 2),
('Memmed Chiragzde', 500, 1);

INSERT INTO Departments(DeparmentName) VALUES
('SOCAR'),
('BP'),
('Code Academy');

SELECT * FROM Employees


SELECT * FROM Employees
WHERE Salary > 1000;


SELECT * FROM Employees
WHERE Salary BETWEEN 500 AND 2000;


SELECT * FROM Employees
WHERE FullName LIKE '%m%';


SELECT * FROM Employees
WHERE DepartmentID = null;


SELECT FullName, Salary
FROM Employees;


SELECT * FROM Employees
WHERE Salary = (SELECT MAX(Salary) FROM Employees);

