using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Declare and intialize variables//
            int numOne = 5;
            Console.WriteLine(numOne);
            Console.ReadKey();

            string myName = "Samir";
            Console.WriteLine(myName);
            Console.ReadKey();

            DateTime dateOne = new DateTime(2020, 12, 25);
            Console.WriteLine(dateOne);
            Console.ReadKey();

                     
        }

        //2-Create a meethod that subtracts two numbers and returns the value//
        public int SubtractTwoNumbers(int x, int y)
        {
            return x - y;
            
        }


        // 3-Create a method that takes two strings from the user and outputs a string//
        public string TakeTwoStringOutputOneString(string stringOne, string stringTwo)
        {
            return stringOne + " " + stringTwo;

        }


        //4 switch case, write a switch case that asks the user if they are wearing clothes//
        public string WearingCloth()
        {
            Console.WriteLine("Are you wearing clothes?");
            string clothes = Console.ReadLine().ToLower();
            switch (clothes)
            {
                case "yes":
                    Console.WriteLine("Fantastic");
                    break;
                case "no":
                    Console.WriteLine("Please put on some clothes");
                    break;
                default:
                    break;

            }
        }



    }
}
