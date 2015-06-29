select t.TeamName as TeamName, isnull(tm.HomeGoals + tm.AwayGoals, 0) as [Total Goals]
from teams t
left join TeamMatches tm
	on t.Id = tm.HomeTeamId or t.Id = tm.AwayTeamId
group by t.TeamName, tm.HomeGoals, tm.AwayGoals
order by [Total Goals] desc

