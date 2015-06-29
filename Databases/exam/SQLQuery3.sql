select c.CountryName, c.CountryCode, (CASE when c.CurrencyCode = 'EUR' then 'Inside' ELSE 'Outside' end) as Eurozone
from Countries c
order by c.CountryName