﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DataUsage
    {
        DateTime date;
        double usage;
        public DataUsage()
        {

        }
        public DataUsage(DateTime date,double usage)
        {
            this.date = date;   
            this.usage = usage;
        }
        public DateTime Date { get { return date; } }
        public double Usage { get { return usage; } }
    }
    public static class DataUsageExtensions
    {
        public static double CalculateTotalUsage(this IEnumerable<DataUsage> dataUsage,DateTime startDate,DateTime endDate)
        {
            double total = 0;
            foreach (DataUsage temp in dataUsage)
            {
                if (temp.Date >= startDate && temp.Date <= endDate)
                    total += temp.Usage;
            }
            return total;
            //ChatGpt.....Lyambda funckiayi het kapvac harc.....
            /*return dataUsage
            .Where(d => d.Date >= startDate && d.Date <= endDate)
            .Sum(d => d.Usage);*/
        }
    }
}
