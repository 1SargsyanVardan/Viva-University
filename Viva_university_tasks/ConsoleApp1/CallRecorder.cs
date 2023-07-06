using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class CallRecorderExtension
    {
        public static int RecorderDuration(this IEnumerable<CallRecorder> call, DateTime startDate, DateTime endDate)
        {
            int allDuration = 0;
            int allCost = 0;
            foreach (CallRecorder callRecorder in call)
            {
                if (callRecorder.Date >= startDate && callRecorder.Date <= endDate)
                {
                    Console.WriteLine(callRecorder.Date);
                    allDuration++;
                    allCost += callRecorder.Cost;
                }
            }
            Console.WriteLine($"{allDuration} calls were made during this period!");
            return allCost;
        }
        public static int RecorderCost(this IEnumerable<CallRecorder> call, DateTime startDate, DateTime endDate)
        {
            if (call == null)
                return 0;
            int allCost = 0;
            foreach (CallRecorder callRecorder in call)
            {
                if (callRecorder.Date >= startDate && callRecorder.Date <= endDate)
                    allCost += callRecorder.Cost;
                
            }
            return allCost;
        }
        public static IEnumerable<CallRecorder> DetectRoamingCalls(this IEnumerable<CallRecorder> callRecords, string roamingOperator)
        {
            string[] fromCountrys = new string[] { "Armenia", "Russia", "France", "Austria", "Brazil" };
            string[] toCountrys = new string[] { "Armenia", "Russia", "France", "Austria", "Brazil" };
            foreach (var item in callRecords)
            {
                if(fromCountrys.Contains(item.CallFrom) && toCountrys.Contains(item.CallTo) && roamingOperator==item.NetworkOperator)
                    yield return item;
            }
        }
    }
    public class CallRecorder
    {
        DateTime date;
        int duration;
        int cost;
        string calledFrom;
        string calledTo;
        string networkOperator;
        
        public CallRecorder()
        {

        }
        public CallRecorder(DateTime date, int duration, int cost,string calledFrom,string calledTo, string networkOperator)
        {
            this.date = date;
            this.duration = duration;
            this.cost = cost;
            this.calledFrom = calledFrom;
            this.calledTo = calledTo;
            this.networkOperator = networkOperator;
        }

        public DateTime Date
        {
            get { return date; }
        }
        public int Duration
        {
            get { return duration; }
        }
        public int Cost
        {
            get { return cost; }
        }
        public string CallFrom
        {
            get { return calledFrom; }
        }
        public string CallTo
        {
            get { return calledTo; }
        }
        public string NetworkOperator
        {
            get { return networkOperator; }
        }
    }
}
