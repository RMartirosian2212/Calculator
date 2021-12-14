using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class RPNString
    {

        private string[] dataInput;

        public RPNString(string userInput)
        {
            dataInput = userInput.Split(" ");
        }

        private Operation operation;
        private string lastOperation;
        private Priority priority1 = new Priority();
        private Priority priority2 = new Priority();
        private Stack<string> operationsStack = new Stack<string>();
        private List<string> result = new List<string>();
        private int x;

        public List<string> ToRPN()
        {
            
            for (int i = 0; i < dataInput.Length; i++)
            {
                priority2.SetPriority(dataInput[i]);
                operation = new Operation(dataInput[i]);
                if (int.TryParse(dataInput[i], out x))
                {
                    result.Add(dataInput[i]);
                    continue;
                }
                else if (operation.IsOperation())
                {
                    if (!(operationsStack.Count == 0))
                    {
                        lastOperation = operationsStack.Peek();
                        priority1.SetPriority(lastOperation);
                    }
                    else
                    {
                        operationsStack.Push(dataInput[i]);
                        continue;
                    }
                    if (priority1.GetPriority() < priority2.GetPriority())
                    {
                        operationsStack.Push(dataInput[i]);
                        continue;
                    }
                    else
                    {
                        result.Add(operationsStack.Pop());
                        operationsStack.Push(dataInput[i]);
                        continue;
                    }
                }
                else if (dataInput[i].Equals("("))
                {
                    operationsStack.Push(dataInput[i]);
                    continue;
                }
                else if (dataInput[i].Equals(")"))
                {
                    while (operationsStack.Peek() != "(")
                    {
                        result.Add(operationsStack.Pop());
                    }
                    operationsStack.Pop();
                }
                else
                {
                    Console.WriteLine("ошибка в выражении");
                    Environment.Exit(0);
                }
            }
            while (!(operationsStack.Count == 0))
            {
                result.Add(operationsStack.Pop());
            }
            return result;
        }
    }
}
