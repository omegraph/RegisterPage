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
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;        //Int16
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;               //Int32
            long largeWholeNumber = 64;         //Int64

            //--Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.234567d;
            decimal decimalExample = 1.70000m;

            //-- Character
            char letter = 'j'; //-- Single Character

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






        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //--Stringd
            string stringExample = "This is a string.";
            string name = "Samir";

            //Formating strings
            string concatenate = stringExample + " " + name;                                //-- This is a string. Samir
            string interpolate = $"{name}. Here is the string: {stringExample}";   //-- Samir. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 06, 29);
            Console.WriteLine(randomDate);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //--Collections
            //--Arrays
            string anotherExampleString = "Hello World";
            string[] stringArrays = { anotherExampleString, "Hello", "World", "!" };


            //--Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Laurence");

            //-- Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //--Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");


            //--Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

        }

    }
}
