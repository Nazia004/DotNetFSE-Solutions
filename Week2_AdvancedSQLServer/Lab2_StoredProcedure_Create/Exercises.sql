USE CompanyDB;
GO

-- Create Stored Procedure
CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT *
    FROM Employees;
END;
GO

-- Execute Stored Procedure
EXEC GetAllEmployees;
GO