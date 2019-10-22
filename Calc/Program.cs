using System;

namespace calculation
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine($"Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите операцию (+,-,*,/)");
            string oper = Console.ReadLine();
            Console.WriteLine($"Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            //int result;


            switch (oper)
            {
                case "+":
                    {
                        var result = a + b;
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;

                    }
                case "-":
                    {
                        var result = a - b;
                        Console.WriteLine($"{a} - {b} = {result}");
                        break;
                    }
                case "*":
                    {
                        var result = a * b;
                        Console.WriteLine($"{a} * {b} = {result}");
                        break;
                    }
                case "/":
                    {
                        var result = a / b;
                        {
                            if (b != 0)
                                Console.WriteLine($"{a} / {b} = {result}");
                                break;
                        }
                        else
                        {
                            Console.WriteLine($"Делить на 0 нельзя!");
                            break;
                        }

                    }
                default:
                    {
                        Console.WriteLine($"Набрана неизвестная операция");
                        break;
                    }

            }

        }
    }
}
