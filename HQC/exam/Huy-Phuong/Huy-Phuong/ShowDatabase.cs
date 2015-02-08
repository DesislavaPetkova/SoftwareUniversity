namespace Huy_Phuong
{
    using System;
    using System.Collections.Generic;

    using Huy_Phuong.Contracts;

    public class ShowDatabase : IPerformanceDatabase
    {
        private readonly SortedDictionary<string, SortedSet<Performance>> sorderPerformances =
        new SortedDictionary<string, SortedSet<Performance>>();

        public void AddTheatre(string theater)
        {
            if (this.sorderPerformances.ContainsKey(theater))
            {
                throw new DuplicateTheatreException("Duplicate theatre");
            }

            this.sorderPerformances[theater] = new SortedSet<Performance>();
        }

        public IEnumerable<string> ListTheatres()
        {

            var t2 = this.sorderPerformances.Keys;
            return t2;
        }

        public void AddPerformance(string theater, string performance, DateTime S2, TimeSpan duration, decimal ticketPrice)
        {
            if (!this.sorderPerformances.ContainsKey(theater))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            var ps = this.sorderPerformances[theater];



            var e2 = S2 + duration;
            if (Check(ps, S2, e2))
            {
                throw new TimeDurationOverlapException("Time/duration overlap");
            }

            var p = new Performance(theater, performance, S2, duration, ticketPrice);
            ps.Add(p);
        }

        public IEnumerable<Performance> ListAllPerformances()
        {
            var theatres = this.sorderPerformances.Keys;
            var result2 = new List<Performance>(); 
            foreach (var t in theatres)
            {
                var performances = this.sorderPerformances[t];
                result2.AddRange(performances);
            }

            return result2;
        }

        IEnumerable<Performance> IPerformanceDatabase.ListPerformances(string theatreName)
        {
            if (!this.sorderPerformances.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            var result = this.sorderPerformances[theatreName];
            return result;
        }



        private static bool Check(IEnumerable<Performance> performances, DateTime sS2, DateTime ee2)
        {
            foreach (var p in performances)
            {
                var ss = p.S2;

                var ee = p.S2 + p.ThoiGian;
                var check =
                    (ss <= sS2 && sS2 <= ee)
                    || (ss <= ee2 && ee2 <= ee)
                    || (sS2 <= ss && ss <= ee2)
                    || (sS2 <= ee && ee <= ee2);
                if (check)
                {
                    return true;
                }
            }

            return false;
        }

        public class DuplicateTheatreException : Exception
        {
            public DuplicateTheatreException(string msg)
                : base(msg)
            {
            }
        }

    }
}
