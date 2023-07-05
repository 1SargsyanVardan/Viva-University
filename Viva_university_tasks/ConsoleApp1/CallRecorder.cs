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
                if (callRecorder.Date >= startDate && callRecorder.Date <= endDate)//programum grac error@ stex er qcum .
                {
                    Console.WriteLine(callRecorder.Date);
                    allDuration++;
                    allCost += callRecorder.Cost;
                }
            }
            Console.WriteLine($"{allDuration} calls were made during this period!");
            return allCost;
        }
    }
    public class CallRecorder
    {
        DateTime date;
        int duration;
        int cost;
        public CallRecorder()
        {

        }
        public CallRecorder(DateTime date, int duration, int cost)
        {
            this.date = date;
            this.duration = duration;
            this.cost = cost;
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
    }
}
