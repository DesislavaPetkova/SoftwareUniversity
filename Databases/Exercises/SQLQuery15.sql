SELECT FirstName, LastName, JobTitle, AddressText 
FROM Employees e
JOIN Addresses a	
	ON e.AddressID = a.AddressID