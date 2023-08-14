using System;
using System.Collections.Generic;

namespace SemesterTest
{
    public class Program
    {

        public static void Main(string[] args)
        {
            DataAnalyser dataAnalyser = new DataAnalyser(new MinMaxSummary());
            List<int> initialNumbers = new List<int> { 1,0,3,8,3,2,2,9,3 };
            foreach (int number in initialNumbers)
            {
                dataAnalyser.AddNumber(number);
            }
            Console.WriteLine("Using MinMaxSummary strategy:");
            dataAnalyser.Summarise();
            dataAnalyser.AddNumber(6);
            dataAnalyser.AddNumber(7);
            dataAnalyser.AddNumber(8);
            dataAnalyser.Strategy = new AverageSummary();
            Console.WriteLine("Using AverageSummary strategy:");
            dataAnalyser.Summarise();


        }
    }
}