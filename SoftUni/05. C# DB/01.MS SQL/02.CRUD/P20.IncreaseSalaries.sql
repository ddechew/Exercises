UPDATE Employees 
	SET Employees.Salary *= 1.12
		FROM Employees AS E
	INNER JOIN Departments AS D ON D.DepartmentID = E.DepartmentID
		WHERE D.Name IN ('Engineering', 'Tool Design', 'Marketing', 'Information Services');

	SELECT Salary FROM Employees;
	
