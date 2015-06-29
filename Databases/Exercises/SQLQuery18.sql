SELECT e.FirstName, e.LastName, e.JobTitle, e.ManagerID, es.FirstName as [Manager], a.AddressText
FROM Employees e
JOIN Employees es
	ON  e.ManagerID = es.EmployeeID
JOIN Addresses a
	ON e.AddressID = a.AddressID
ORDER BY es.EmployeeID
