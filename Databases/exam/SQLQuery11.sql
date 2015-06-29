select LOWER(t1.TeamName + substring(Reverse(t2.TeamName), 2,LEN(Reverse(t2.TeamName)))) as Mix
from Teams t1, Teams t2
where (right(t1.TeamName, 1)) = (left(Reverse(t2.TeamName), 1))
order by Mix

