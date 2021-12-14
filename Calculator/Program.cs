using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = null;
            List<string> result = new List<string>();

            Calculate calculate = new Calculate(result);

            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    path = args[i].Trim('"');
                    if (File.Exists(path.ToString()))
                    {
                        Reading reading = new Reading(path);
                        string[] strArray = reading.Read();
                        for (int y = 0; y < strArray.Length; y++)
                        {
                            RPNString RPN = new RPNString(strArray[y]);
                            Console.Write(strArray[y]);
                            result.AddRange(RPN.ToRPN());
                            calculate.CalcRPN();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Некоректный путь к файлу");
                    }

                }
            }
            else
            {
                Console.Write("Напишите выражение (Каждый символ через пробел) - ");
                string userInput = Console.ReadLine();
                Console.Clear();
                Console.Write(userInput);
                RPNString RPN = new RPNString(userInput);
                result.AddRange(RPN.ToRPN());
                calculate.CalcRPN();
            }
        }
    }
}