select c.CountryName as [Home Team], cc.CountryName as [Away Team], im.MatchDate as [Match Date]
from InternationalMatches im
left join Countries c
	on im.HomeCountryCode = c.CountryCode
left join Countries cc 
	on im.AwayCountryCode = cc.CountryCode
order by  MatchDate desc