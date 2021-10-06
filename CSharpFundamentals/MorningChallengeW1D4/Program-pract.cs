using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallengeW1D4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;

            num += 5;

            int anotherNum = Add(num, 10);

            Console.WriteLine(anotherNum);

         }
        public static int Add(int a, int b)
        {
            return a + b;
        }

    }
}
