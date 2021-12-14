using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Priority
    {
        public Priority()
        {

        }

        public void SetPriority(string userInput)
        {
            _userInput = userInput;
        }
        private string _userInput;
        public int GetPriority()
        {
            switch (_userInput)
            {
                case "+":
                    return 1;
                case "-":
                    return 1;
                case "*":
                    return 2;
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
