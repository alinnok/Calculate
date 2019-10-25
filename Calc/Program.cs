using System;
using System.Collections.Generic;

namespace calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = "";
            string oper = "";
            List<string> history = new List<string>();
            Console.WriteLine("Для выхода наберите exit");
            Console.WriteLine("Для просмотра истории операций наберите history");
            while (a != "exit")
            {
                Console.WriteLine("Введите первое число");
                a = Console.ReadLine();
                if (a == "exit")

                    return;
                else
                {
                    if (a == "history")
                    { for (var i = 0; i < history.Count; i++)
                            Console.WriteLine(history[i]);
                    }
                    else
                    {
                        Console.WriteLine("Введите операцию (+,-,*,/)");                        
                        oper = Console.ReadLine();
                    }
                
                    if (oper == "exit")
                        return;
                    else
                    {
                        if (oper == "history")
                        {
                            for (var i = 0; i < history.Count; i++)
                                Console.WriteLine(history[i]);
                        }
                         else
                        {
                        Console.WriteLine("Введите второе число");
                        b = Console.ReadLine();
                            if (b == "exit")

                                return;
                            else
                            {

                                if (b == "history")
                                {
                                    for (var i = 0; i < history.Count; i++)
                                        Console.WriteLine(history[i]);
                                }
                                else
                                {

                                    switch (oper)
                                    {

                                        case "+":
                                            {
                                                var result = Convert.ToDouble(a) + Convert.ToDouble(b);
                                                Console.WriteLine($"{a} + {b} = {result}");
                                                history.Add(string.Format("{0} + {1} = {2}", a, b, result));
                                                break;

                                            }
                                        case "-":
                                            {
                                                var result = Convert.ToDouble(a) - Convert.ToDouble(b);
                                                Console.WriteLine($"{a} - {b} = {result}");
                                                history.Add(string.Format("{0} - {1} = {2}", a, b, result));
                                                break;
                                            }
                                        case "*":
                                            {
                                                var result = Convert.ToDouble(a) * Convert.ToDouble(b);
                                                Console.WriteLine($"{a} * {b} = {result}");
                                                history.Add(string.Format("{0} * {1} = {2}", a, b, result));
                                                break;
                                            }
                                        case "/":
                                            {

                                                if (Convert.ToDouble(b) != 0)
                                                {
                                                    var result = Convert.ToDouble(a) / Convert.ToDouble(b);
                                                    Console.WriteLine($"{a} / {b} = {result}");
                                                    history.Add(string.Format("{0} / {1} = {2}", a, b, result));
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
    }
}
