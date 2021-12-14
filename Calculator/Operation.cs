using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operation
    {
        private string _userInput;
        public Operation(string userInput)
        {
            _userInput = userInput;
        }
        public bool IsOperation()
        {
            if (_userInput.Equals("+") || _userInput.Equals("-") || _userInput.Equals("*") || _userInput.Equals("/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
