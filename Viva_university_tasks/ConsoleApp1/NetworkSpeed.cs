using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NetworkSpeed
    {
        int speed;
        DateTime date;
        public NetworkSpeed()
        {

        }
        public NetworkSpeed(int speed, DateTime date)
        {
            this.speed = speed;
            this.date = date;
        }
        public int Speed  { get { return speed; } }
        public DateTime Date { get { return date; } }
    }
    public static class NetworkSpeedExtensions
    {
        public static double CalculateAverageSpeed(this IEnumerable<NetworkSpeed> networkSpeeds,DateTime startDate,DateTime endDate)
        {
            double averageSpeed = 0;
            int calculateSpeeds = 0;
            foreach (NetworkSpeed networkSpeed in networkSpeeds)
            {
                if(networkSpeed.Date >= startDate && networkSpeed.Date<=endDate)
                {
                    averageSpeed += networkSpeed.Speed;
                    calculateSpeeds++;
                }
            }
            return averageSpeed/calculateSpeeds;
        }
    }
}
