using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        private List<string> _result = new List<string>();

        public Calculate(List<string> result)
        {
            _result = result;
        }
        private Stack<int> number = new Stack<int>();
        private int operand1 = 0;
        private int operand2 = 0;
        private int x;
        public int CalcRPN()
        {
            for (int i = 0; i < _result.Count; i++)
            {
                if (int.TryParse(_result[i], out x))
                {
                    number.Push(int.Parse(_result[i].ToString()));
                }
                else
                {
                    operand2 = number.Pop();
                    operand1 = number.Pop();
                    Action action = new Action(_result[i], operand1, operand2);
                    number.Push(action.ApplyOperation());
                }
            }
            Console.Write(" = " + number.Peek());
            Console.WriteLine();
            return number.Pop();
        }
    }
}
