SELECT homes.TeamName as [Home Team], away.TeamName as [Away Team], tm.MatchDate as [Match Date]
from TeamMatches tm
left join Teams homes
	on tm.HomeTeamId = homes.Id
left join Teams away 
	on tm.AwayTeamId = away.Id
--order by tm.MatchDate desc
union 
select homes.TeamName, away.TeamName, fm.MatchDate
from FriendlyMatches fm
left join Teams homes
	on fm.HomeTeamId = homes.Id
left join Teams away 
	on fm.AwayTeamId = away.Id
order by tm.MatchDate desc

