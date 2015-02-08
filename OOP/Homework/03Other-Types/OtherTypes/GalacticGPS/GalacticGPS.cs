using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    struct Location 
    {
        private double latitude;
        private double longtitude;
        private Planets planet;

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                this.latitude = value;
            }
        }
        public double Longitude 
        {
            get
            {
                return this.longtitude;
            }
            set
            {
                this.longtitude = value;
            }
        }
        public enum Planets
        {
            Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
        }
        public Planets Planet 
        {
            get
            {
                return this.planet;
            }
            set
            {
                this.planet = value;
            }
        }
        
        public Location(double latitude, double longitude, Planets planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            string result = string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
            return result.ToString();
        }
        static void Main()
        {
            Location firstTest = new Location(23.2323, 56.1232, Planets.Earth);
            Console.WriteLine(firstTest.ToString());
        }
    }
}
