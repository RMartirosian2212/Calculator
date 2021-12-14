using System;
using Xunit;
using Calculator;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void RPNTest()
        {
            RPNString RPN = new RPNString();
            string userInput =  "( 22 + 22 ) * 4";
            List<string> RPNResult = RPN.ToRPN(userInput);
            List<string> RPNExpected = new List<string>() { "22", "22", "+", "4", "*" };
            Assert.Equal(RPNExpected, RPNResult);
        }
        [Fact]
        public void CalcTest()
        {
            List<string> RPN = new List<string>() { "22", "22", "+", "4", "*" };
            Calculate calculator = new Calculate(RPN);
            int calcResult = calculator.CalcRPN();
            int calcExpected = 176;
            Assert.Equal(calcExpected, calcResult);
        }
    }
}
