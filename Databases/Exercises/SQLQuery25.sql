SELECT top 30 CountryName, Population
from Countries c
join Continents con
	on c.ContinentCode = con.ContinentCode
WHERE con.ContinentName = 'Europe' 
order by Population DESC, CountryName ASC
