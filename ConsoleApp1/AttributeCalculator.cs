using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AttributeCalculator
    {
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach (int num in Numbers)
            {
                Sum = Sum + num;
            }
            return Sum;
        }
    }
}
