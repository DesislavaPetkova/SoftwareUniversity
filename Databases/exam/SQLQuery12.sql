select t.TeamName as [Team Name], l.LeagueName as League, ISNULL(c.CountryName, 'International') as [League Country]
from teams t
left join Leagues_Teams lt
	on t.Id = lt.TeamId
left join Leagues l
	on lt.LeagueId = l.Id
left join Countries c
	on l.CountryCode = c.CountryCode
order by t.TeamName, l.LeagueName