using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Whole Numbers
            byte oneBytesWorth = 55;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            //--Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            int diff = numOne - numTwo;
            Console.WriteLine(diff);

            int prod = numOne * numTwo;
            Console.WriteLine(prod);

            int quot = numOne / numTwo;
            Console.WriteLine(quot);

            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);


            Console.WriteLine("Hello");


        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //--Strings
            string stringExample = "This is a string.";

            
        }



    }
}
