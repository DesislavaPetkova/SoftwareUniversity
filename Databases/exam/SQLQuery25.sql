select homes.TeamName as [Home Team], tm.HomeGoals as [Home Goals], away.TeamName as [Away Team], tm.AwayGoals as [Away Goals], l.LeagueName as [League Name]
from TeamMatches tm
join Leagues l
	on tm.LeagueId = l.Id
join Teams homes
	on tm.HomeTeamId = homes.Id
join Teams away
	on tm.AwayTeamId = away.Id
where tm.MatchDate > '2015-04-10 00:00:00.000' and l.isSeasonal > 0
order by l.LeagueName, tm.HomeGoals desc


