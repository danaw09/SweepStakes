using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : SweepstakesManager_interface
    {
        public void EnqueueOnQueue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Elements in queue: ");
            foreach (int number in queue)
            {
                Console.WriteLine(number);
            }
        }
    }
}
