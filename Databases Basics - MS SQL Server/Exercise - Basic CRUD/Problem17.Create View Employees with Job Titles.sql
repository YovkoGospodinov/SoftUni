CREATE VIEW V_EmployeeNameJobTitle AS
 SELECT 
	CASE
		WHEN Employees.MiddleName IS NOT NULL THEN Employees.FirstName + ' ' + Employees.MiddleName + ' ' + Employees.LastName
		WHEN Employees.MiddleName IS NULL THEN Employees.FirstName + ' ' + '' + ' ' + Employees.LastName
	END
	AS 'Full Name'
	,JobTitle
  FROM dbo.Employees

--SELECT * FROM V_EmployeeNameJobTitle