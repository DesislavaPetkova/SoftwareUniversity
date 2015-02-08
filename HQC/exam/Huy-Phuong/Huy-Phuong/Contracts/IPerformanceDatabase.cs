namespace Huy_Phuong.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IPerformanceDatabase
    {
        /// <summary>
        /// Adding and instance of class Theatre in sorted set.
        /// </summary>
        /// <param name="theaterName"></param>
        /// Exceptions: throw Exception if there is a duplicated theatres
        void AddTheatre(string theaterName);

        /// <summary>
        /// Containing list of theatres
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> ListTheatres();

        /// <summary>
        /// Adding a instance of class performance in sorted set.
        /// </summary>
        /// <param name="theaterName"></param>
        /// <param name="performanceTitle"></param>
        /// <param name="startDateTime"></param>
        /// <param name="duration"></param>
        /// <param name="price"></param>
        /// Exceptions: Throwing exception if there is no instance of threater equal of param name="theaterName"
        void AddPerformance(string theaterName, string performanceTitle, DateTime startDateTime, TimeSpan duration, decimal price);

        /// <summary>
        /// List all of performances 
        /// </summary>
        /// <returns></returns>
        IEnumerable<Performance> ListAllPerformances();

        /// <summary>
        /// List performances according <param name="theaterName"></param>
        /// </summary>
        /// <param name="theaterName"></param>
        /// <returns></returns>
        /// Exceptions: Throwing exception if the parameter doesnt exist.
        IEnumerable<Performance> ListPerformances(string theaterName);
    }
}
