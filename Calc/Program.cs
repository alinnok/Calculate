using System;

namespace calculation
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию (+,-,*,/)");
            string oper = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            


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
                        
                            if (b != 0)
                            {   
                                var result = a / b;
                                Console.WriteLine($"{a} / {b} = {result}");
                                break;
                            }
                            else
                            {
                            Console.WriteLine("Делить на 0 нельзя!");
                            break;
                            }

                    }
                default:
                    {
                        Console.WriteLine("Набрана неизвестная операция");
                        break;
                    }

            }

        }
    }
}
