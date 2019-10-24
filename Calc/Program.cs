using System;

namespace calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = "";
            string oper = "";
            //string exit = "exit";
            Console.WriteLine("Для выхода наберите exit");
            while (a != "exit")
            {
                Console.WriteLine("Введите первое число");
                a = Console.ReadLine();
                if (a == "exit")  return; 
                else
                {
                    Console.WriteLine("Введите операцию (+,-,*,/)");
                    oper = Console.ReadLine();
                    if (oper == "exit") return;
                    else
                    {
                        Console.WriteLine("Введите второе число");
                        b = Console.ReadLine();
                        if (b == "exit") return;
                        else
                        {

                            switch (oper)
                            {

                                case "+":
                                    {
                                        var result = Convert.ToDouble(a) + Convert.ToDouble(b);
                                        Console.WriteLine($"{a} + {b} = {result}");
                                        break;

                                    }
                                case "-":
                                    {
                                        var result = Convert.ToDouble(a) - Convert.ToDouble(b);
                                        Console.WriteLine($"{a} - {b} = {result}");
                                        break;
                                    }
                                case "*":
                                    {
                                        var result = Convert.ToDouble(a) * Convert.ToDouble(b);
                                        Console.WriteLine($"{a} * {b} = {result}");
                                        break;
                                    }
                                case "/":
                                    {

                                        if (Convert.ToDouble(b) != 0)
                                        {
                                            var result = Convert.ToDouble(a) / Convert.ToDouble(b);
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
            }
            
        }
    }
}
