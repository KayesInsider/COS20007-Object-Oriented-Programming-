using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public class DataAnalyser
    {
        private SummaryStrategy _strategy;
        private List<int> Numbers;

        public DataAnalyser()
        {
            _strategy = new AverageSummary();
            Numbers = new List<int>();
        }
        public SummaryStrategy Strategy
        {
            get {return _strategy;}
            set{_strategy = value;}
        }

        public DataAnalyser(SummaryStrategy strategy) : this()
        {
            _strategy = strategy;
        }

        public void AddNumber(int number)
        {
            Numbers.Add(number);
        }

        public void Summarise()
        {
            _strategy.PrintSummary(Numbers);
        }
    }

}
