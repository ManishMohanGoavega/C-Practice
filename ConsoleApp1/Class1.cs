using System;

namespace ConsoleApp1
{
    internal class Class1
    {
        string color, pluralNoun, celebrity;

        public void displayText()
        {
            Console.Write("Enter color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }

        
    }
}