namespace Huy_Phuong
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        public static string ExecuteAddTheatreCommand(string[] parameters)
        {
            string theaterName = parameters[0];
            Theater.Universal.AddTheatre(theaterName);
            return "Theatre added";
        }

        public static string ExecutePrintAllTheatresCommand()
        {
            var theatresCount = Theater.Universal.ListTheatres().Count();
            if (theatresCount > 0)
            {
                var resultTheatres = new LinkedList<string>();
                for (int i = 0; i < theatresCount; i++)
                {
                    Theater.Universal.ListTheatres().Skip(i).ToList().ForEach(
                        t => resultTheatres.AddLast(t));
                    foreach (var t in Theater.Universal.ListTheatres().Skip(i + 1))
                    {
                        resultTheatres.Remove(t);
                    }
                }
                return string.Join(", ", resultTheatres);
            }

            return "No theatres";
        }
    }
}
