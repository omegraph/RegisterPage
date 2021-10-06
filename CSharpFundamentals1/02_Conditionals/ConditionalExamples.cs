using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            //bool isTrue = 17 > 5;
            //bool isFalse = 17 == 4;
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (isTrue)
            {
                //Do Something Here
            }

            int age = 20;

            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                Console.WriteLine("You're still a kid");
            }
        }


        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;
            switch (age)
            {
                case 18:
                    //Code for if age is 18
                    break;
                case 19:
                    //Code for age is 19
                    break;
            }
        }

    }

}
