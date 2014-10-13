﻿
namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longtitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longtitude = longitude;
            this.Planet = planet;
        }

        public double Latitude{get; set;}

        public double Longtitude { get; set; }

        public Planet Planet { get; set; }
        
        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet);
        }
    }
}
