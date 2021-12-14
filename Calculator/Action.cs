using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Action
    {
        string _operation;
        int _operand1;
        int _operand2;
        public Action(string operation, int operand1, int operand2)
        {
            _operation = operation;
            _operand1 = operand1;
            _operand2 = operand2;

        }
        public int ApplyOperation()
        {
            switch (_operation)
            {
                case "+":
                    return _operand1 + _operand2;
                case "-":
                    return _operand1 - _operand2;
                case "*":
                    return _operand1 * _operand2;
                case "/":
                    return _operand1 / _operand2;
                default:
                    return 0;
            }
        }
    }
}
