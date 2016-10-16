UPDATE dbo.Employees
 SET Salary = Salary + 0.12 * Salary
  WHERE DepartmentID = 1
  OR DepartmentID = 2
  OR DepartmentID = 4
  OR DepartmentID = 11

  SELECT Salary
   FROM dbo.Employees