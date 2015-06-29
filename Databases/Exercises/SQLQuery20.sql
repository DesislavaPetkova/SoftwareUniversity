SELECT e.FirstName,  es.FirstName
FROM Employees e
LEFT OUTER JOIN Employees es
	ON e.ManagerID = es.EmployeeID