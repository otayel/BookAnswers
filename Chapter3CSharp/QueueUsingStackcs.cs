using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3CSharp
{
    class QueueUsingStacks<T>
    {
        Stack<T> enqueueStack;
        Stack<T> dequeueStack;

        public QueueUsingStacks()
        {
            enqueueStack = new Stack<T>();
            dequeueStack = new Stack<T>();
        }

        public void Enqueue(T item)
        {
            enqueueStack.Push(item);
        }

        public T Dequeue()
        {
            if(dequeueStack.Count>0)
            {
                return dequeueStack.Pop();
            }
            else if(enqueueStack.Count == 0)
            {
                throw new Exception("Empty Queue");
            }
            else
            {
                while(enqueueStack.Count>0)
                {
                    dequeueStack.Push(enqueueStack.Pop());
                }

                return dequeueStack.Pop();
            }
        }
    }
}
