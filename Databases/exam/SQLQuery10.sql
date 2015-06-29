select t1.MatchDate as [First Date], t2.MatchDate as [Second Date]
from TeamMatches t1, TeamMatches t2
where day(t1.MatchDate) = day(t2.MatchDate) and DATEPART(HOUR, t1.MatchDate) < DATEPART(HOUR, t2.MatchDate)
order by t1.MatchDate desc, t2.MatchDate desc


