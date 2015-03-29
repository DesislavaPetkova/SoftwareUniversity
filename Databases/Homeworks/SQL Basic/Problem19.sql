SELECT FirstName, LastName, t.Name as Town, a.AddressText
FROM Employees e, Addresses a, Towns t
WHERE e.AddressID = a.AddressID AND a.TownID = t.TownID