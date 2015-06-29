SELECT e.FirstName,  es.FirstName
FROM Employees ES
RIGHT OUTER JOIN Employees e
	ON es.EmployeeID = e.ManagerID