SELECT FirstName, LastName, d.Name as Departement
FROM Employees e
JOIN Departments D
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance')