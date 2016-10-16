SELECT Employees.FirstName + ' ' + Employees.MiddleName + ' ' + Employees.LastName AS 'Full Name'
 FROM dbo.Employees
  WHERE Salary = 25000 
  OR Salary = 14000 
  OR Salary = 12500 
  OR Salary = 23600