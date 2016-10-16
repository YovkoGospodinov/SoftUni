UPDATE [dbo].[Employees]
SET Salary = Salary + 0.1 * Salary

SELECT [Salary]
 FROM [dbo].[Employees]