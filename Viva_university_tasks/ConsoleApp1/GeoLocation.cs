using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class GeoLocationExtenions
    {
        public static GeoLocation FindNearestTower(this GeoLocation userGeoLocation, IEnumerable<GeoLocation> cellTowers)
        {
            GeoLocation retMin = cellTowers.FirstOrDefault();
            double distance = double.MaxValue;
            foreach (var cell in cellTowers)
            {
                double minDistance = Math.Sqrt(Math.Pow((userGeoLocation.Latitude - cell.Latitude),2) + Math.Pow((userGeoLocation.Longitude - cell.Longitude),2));
                if(minDistance < distance)
                {
                    distance = minDistance;
                    retMin = cell;
                }
            }
            return retMin;
        }
    }
    public class GeoLocation
    {
        public double Latitude { get; set;}
        public double Longitude { get; set;}
        public GeoLocation()
        {

        }
        public GeoLocation(double latitude,double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
