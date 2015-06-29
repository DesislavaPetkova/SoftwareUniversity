select *
from TeamMatches tm
join Teams homes
	 on tm.HomeTeamId = homes.Id
join Teams away
	on tm.AwayTeamId = away.Id