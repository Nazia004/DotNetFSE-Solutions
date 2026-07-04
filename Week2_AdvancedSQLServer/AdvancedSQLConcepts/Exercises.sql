CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO

CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    HireDate DATE
);

INSERT INTO Employees VALUES
(1,'John','Smith','HR',45000,'2020-01-15'),
(2,'Alice','Johnson','IT',65000,'2019-05-20'),
(3,'Robert','Brown','Finance',70000,'2018-03-10'),
(4,'Emma','Wilson','IT',72000,'2021-07-18'),
(5,'David','Taylor','Sales',50000,'2022-02-25');

-- SELECT
SELECT * FROM Employees;

-- WHERE
SELECT *
FROM Employees
WHERE Salary > 60000;

-- ORDER BY
SELECT *
FROM Employees
ORDER BY Salary DESC;

-- DISTINCT
SELECT DISTINCT Department
FROM Employees;

-- Aggregate Functions
SELECT
COUNT(*) AS TotalEmployees,
AVG(Salary) AS AverageSalary,
MAX(Salary) AS HighestSalary,
MIN(Salary) AS LowestSalary
FROM Employees;

-- GROUP BY
SELECT Department,
COUNT(*) AS EmployeeCount,
AVG(Salary) AS AverageSalary
FROM Employees
GROUP BY Department;

-- HAVING
SELECT Department,
AVG(Salary) AS AverageSalary
FROM Employees
GROUP BY Department
HAVING AVG(Salary) > 60000;

-- LIKE
SELECT *
FROM Employees
WHERE FirstName LIKE 'A%';

-- BETWEEN
SELECT *
FROM Employees
WHERE Salary BETWEEN 45000 AND 65000;

-- IN
SELECT *
FROM Employees
WHERE Department IN ('IT','HR');