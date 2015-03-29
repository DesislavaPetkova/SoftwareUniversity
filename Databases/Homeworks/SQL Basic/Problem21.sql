SELECT e.FirstName, e.LastName, m.FirstName +' '+ m.LastName AS [Manager Name], a.AddressText
FROM Employees e
JOIN Employees m 
	ON e.EmployeeID = m.ManagerID
JOIN Addresses a
	ON m.AddressID = a.AddressID