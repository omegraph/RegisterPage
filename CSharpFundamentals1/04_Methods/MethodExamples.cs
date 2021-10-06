using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //Input
        //What we do
        //Output

        //Access Modifier   Return Type Method Signature(Name and list of parameters)
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }


        private int FindRemainder(int a, int b)
        {
            int remainder = a % b;
            return remainder;
        }

        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            int sum = AddTwoNumbers(5, 42);

        }
    }
}
