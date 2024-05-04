using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_2_Refaktoriranje
{
    public class Location
    {
        public DateTime TimeStamp { get; private set; } 
        public double LatitudeCoordinate { get; private set; } 
        public double LongitudeCoordinate { get; private set; } 

        public Location(double Lat, double Long)
        {
            // Constructor implementation
        }
    }

    public class PathManager
    {
        private List<Location> locations; // the path location points

        public PathManager()
        {
            locations = new List<Location>();
        }

        public void Add(Location location)
        {
            locations.Add(location);
        }

        public void Remove(Location location)
        {
            locations.Remove(location);
        }
    }
}
