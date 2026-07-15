USE CompanyDB;
GO

-- Drop procedure if it already exists
DROP PROCEDURE IF EXISTS GetEmployeesByDepartment;
GO

-- Create Stored Procedure
CREATE PROCEDURE GetEmployeesByDepartment
    @Department VARCHAR(50)
AS
BEGIN
    SELECT EmployeeID,
           FirstName,
           LastName,
           Department,
           Salary
    FROM Employees
    WHERE Department = @Department;
END;
GO

-- Execute the Stored Procedure
EXEC GetEmployeesByDepartment 'IT';
GO

EXEC GetEmployeesByDepartment 'HR';
GO

EXEC GetEmployeesByDepartment 'Finance';
GO