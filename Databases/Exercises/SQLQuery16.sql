SELECT FirstName, LastName, JobTitle, AddressText 
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID
