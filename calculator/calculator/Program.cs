using System;

class MainClass
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter fisrt number: ");
        double num1 = double.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("Enter an operation you want to do <+, -, /, *, ^>: ");
            char operand = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (operand)
            {
                case '+':
                    num1 = num1+num2;
                    Console.WriteLine(+num1);
                    break;
                case '-':
                    num1 = num1-num2;
                    Console.WriteLine(+num1);
                    break;
                case '*':
                    num1 = num1*num2;
                    Console.WriteLine(+num1);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot be devide by zero");
                        Console.WriteLine(+num1);
                    }
                    else
                    {
                        num1 = num1/num2;
                        Console.WriteLine(num1);
                    }
                    break;
                case '^':
                    num1 = Math.Pow(num1, num2);
                    Console.WriteLine(num1);
                    break;
                default:
                    Console.WriteLine("Invalied operand");
                    break;
            }
        }
    }
}