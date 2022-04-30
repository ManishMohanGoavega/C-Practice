namespace ConsoleApp1
{
    internal class Calculator
    {
        public void Calculate()
        {
            System.Console.WriteLine("Enter a number: ");
            double num1 = System.Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter an operator: ");
            System.String op = System.Console.ReadLine();

            System.Console.WriteLine("Enter a number: ");
            double num2 = System.Convert.ToDouble(System.Console.ReadLine());

            if (op == "+")
            {
                System.Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                System.Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                System.Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                System.Console.Write(num1 / num2);
            }
            else
            {
                System.Console.Write("Invalid operator");
            }


            System.Console.ReadLine();
        }
    }
}