select l.LeagueName as [League Name], count(distinct lt.TeamId) as Teams,
 count(distinct tm.Id) as Matches, isnull(avg(tm.HomeGoals + tm.AwayGoals), 0) as [Average Goals]
from Leagues l
left join Leagues_Teams lt
	on l.Id = lt.LeagueId
left join TeamMatches tm
	on l.Id = tm.LeagueId
group by l.LeagueName
order by Teams desc, Matches desc