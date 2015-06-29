select p.PeakName, r.RiverName, LOWER(p.PeakName + SUBSTRING(r.RiverName, 2, LEN(r.RiverName))) as Mix

from Peaks p, Rivers r 
Where right(p.PeakName, 1) = left(r.RiverName, 1)
order by Mix