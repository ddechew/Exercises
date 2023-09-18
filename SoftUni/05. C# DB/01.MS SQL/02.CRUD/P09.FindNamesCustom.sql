SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name] 
	FROM Employees
	WHERE Salary IN (25000, 14000, 12500, 23600);
  --WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500;