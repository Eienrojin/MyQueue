using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    internal interface IQueue
    {
        int Peek();
        int Dequeue();
        void Enqueue(int item);
    }
}
