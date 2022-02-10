using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    internal class OtherQueue : IQueue
    {
        public List<int> queue = new();

        public int Dequeue()
        {
            int temp = queue.First();

            queue.RemoveAt(0);

            return temp;
        }

        public void Enqueue(int item)
        {
            queue.Add(item);
        }

        public int Peek()
        {
            return queue.First();
        }
    }
}
