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
    Salary DECIMAL(10,2)
);

INSERT INTO Employees VALUES
(1,'John','Smith','HR',45000),
(2,'Alice','Johnson','IT',65000),
(3,'Robert','Brown','Finance',70000),
(4,'Emma','Wilson','IT',72000),
(5,'David','Lee','HR',50000),
(6,'Sophia','Taylor','Finance',68000);

----------------------------------------------------------
-- Exercise 1 : Ranking and Window Functions
----------------------------------------------------------

-- ROW_NUMBER()
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Department,
    Salary,
    ROW_NUMBER() OVER(ORDER BY Salary DESC) AS RowNumber
FROM Employees;

----------------------------------------------------------

-- RANK()
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Department,
    Salary,
    RANK() OVER(ORDER BY Salary DESC) AS RankNumber
FROM Employees;

----------------------------------------------------------

-- DENSE_RANK()
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Department,
    Salary,
    DENSE_RANK() OVER(ORDER BY Salary DESC) AS DenseRank
FROM Employees;

----------------------------------------------------------

-- NTILE(2)
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Department,
    Salary,
    NTILE(2) OVER(ORDER BY Salary DESC) AS GroupNumber
FROM Employees;