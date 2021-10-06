using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Queue
    {
        public void QueueOfInt()
        {
            Queue<int> ints = new Queue<int>();

            Queue<int> intsNumbers = new Queue<int>();
            for (int i = 0; i < 100; i++)
            {
                intsNumbers.Enqueue(i);
            }

            

        }

    }
}
