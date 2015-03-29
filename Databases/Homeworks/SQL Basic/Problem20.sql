SELECT e.FirstName, e.LastName, m.EmployeeID, m.FirstName +' '+ m.LastName AS [Manager Name]
FROM Employees e
JOIN Employees m 
	ON e.ManagerID = m.EmployeeID