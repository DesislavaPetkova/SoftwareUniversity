select distinct l.LeagueName
from Leagues l
left join TeamMatches tm
	on l.Id = tm.LeagueId
where tm.LeagueId > 0

UPDATE Leagues
set isSeasonal = 1
WHEre LeagueName in (select distinct l.LeagueName
from Leagues l
left join TeamMatches tm
	on l.Id = tm.LeagueId
where tm.LeagueId > 0)