SELECT e.FirstName, e.LastName, e.JobTitle, e.ManagerID, es.FirstName as [Manager]
FROM Employees e
JOIN Employees es
 ON  e.ManagerID = es.EmployeeID


