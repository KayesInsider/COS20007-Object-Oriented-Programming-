using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
   public class AverageSummary : SummaryStrategy
{

        private float Average(List<int> numbers)
        {
            float sum;
            sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            float avgerage;
            avgerage = sum / numbers.Count;
            return avgerage;
        }

        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine(" Average : " + Average(numbers));
        }

     
    }
}
