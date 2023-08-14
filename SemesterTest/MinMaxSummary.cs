using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{

    public class MinMaxSummary : SummaryStrategy
    {

        private int Minimum(List<int> numbers)
        {
            int minnum;
            minnum = numbers[0];
            foreach (int num in numbers)
            {
                if (num < minnum)
                {
                    minnum = num;
                }
            }

            return minnum;
        }



        private int Maximum(List<int> numbers)
        {
            int maximum;
            maximum = numbers[0];
            foreach (int num in numbers)
            {
                if (num > maximum)
                {
                    maximum = num;
                }
            }
            return maximum;
        }

        public override void PrintSummary(List<int> numbers)
        {

            Console.WriteLine(" The Minimum value is : " + Minimum(numbers));
            Console.WriteLine(" The Maximum value is : " + Maximum(numbers));
        }
    }
}

