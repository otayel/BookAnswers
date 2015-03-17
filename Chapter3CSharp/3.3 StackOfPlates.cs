using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3CSharp
{
    class StackOfPlates<T>
    {
        const int STACK_CAPACITY = 2;
        List<Stack<T>> stacks;
        int currentStack;

        public StackOfPlates()
        {
            stacks = new List<Stack<T>>();
            stacks.Add(new Stack<T>(STACK_CAPACITY));
            currentStack = 0;
        }

        public void Push(T item)
        {
            if (currentStack < 0)
            {
                Console.WriteLine("No Stacks - Initializing again.");
                stacks.Add(new Stack<T>(STACK_CAPACITY));
                currentStack = 0;
            }

            if (stacks[currentStack].Count == STACK_CAPACITY)
            {
                Console.WriteLine("Stack Full - Adding new Stack.");
                currentStack++;
                stacks.Add(new Stack<T>(STACK_CAPACITY));
            }

            stacks[currentStack].Push(item);
        }

        public T Pop()
        {
            if (currentStack < 0 || stacks[currentStack].Count == 0)
            {
                throw new Exception("Empty Stack");
            }

            T item = stacks[currentStack].Pop();
            if (stacks[currentStack].Count == 0)
            {
                stacks.RemoveAt(currentStack);
                currentStack--;
            }

            return item;
        }

        public T PopAt(int index)
        {
            if (index > currentStack)
            {
                throw new Exception("Index is out of range");
            }

            T item = stacks[index].Pop();
            if (stacks[index].Count == 0)
            {
                stacks.RemoveAt(index);
                currentStack--;
            }
            else
            {
                Shift(index + 1);
            }

            return item;
        }

        private void Shift(int index)
        {
            while (index <= currentStack)
            {
                Stack<T> tempStack = new Stack<T>();
                while (stacks[index].Count > 0)
                {
                    tempStack.Push(stacks[index].Pop());
                }

                stacks[index - 1].Push(tempStack.Pop());

                while (tempStack.Count > 0)
                {
                    stacks[index].Push(tempStack.Pop());
                }

                index++;
            }

            if (stacks[currentStack].Count == 0)
            {
                stacks.RemoveAt(currentStack);
                currentStack--;
            }
        }

    }
}
