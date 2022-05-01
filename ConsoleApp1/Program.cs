using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine(AttributeCalculator.Add(10 , 5));
            //int num1 = 9865669;
            //int digits = num1.GetDigits();
            //Console.WriteLine(digits);
            Console.WriteLine(AttributeCalculator.Add(new List<int>() { 10, 20, 40}));
            Console.ReadLine();
        }
    }
}
