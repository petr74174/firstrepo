using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meller_UNIT
{
    public class Calculator
    {
        public double Plus(double a, double b)
        {
            double result = a + b;
            return result;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double Minus(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double AreaOfATriangle(double a, double h)
        {
            return (a * h)/2;
        }
        public double SquareAre(double a)
        {
            return Math.Pow(a, 2);
        }
        public double Average(double[] array)
        {
            double summ = 0;
            for (int i = 0; i < array.Length; i++)
                summ += array[i];

            return summ / array.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Calculator calc = new Calculator();
            while (true)
            {
                Console.WriteLine("выбирите дейчствие");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "*":
                        Console.WriteLine($"результат:{calc.Multiply(a, b)}");
                        break;
                    case "/":
                        Console.WriteLine($"результат:{calc.Multiply(a, b)}");
                        break;
                    case "-":
                        Console.WriteLine($"результат:{calc.Multiply(a, b)}");
                        break;
                    case "+":
                        Console.WriteLine($"результат:{calc.Multiply(a, b)}");
                        break;
                    case "TR":
                        Console.WriteLine($"результат:{calc.AreaOfATriangle(a,b)}");
                        break;
                    default:
                        Console.WriteLine("выбирите дейчствие. Только /,*,-,+");
                        break;
                }
            }

        }
    }
}
