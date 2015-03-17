using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSortedStack();
        }

        static void TestThreeStacks()
        {
            ThreeStacks<int> threeStacks = new ThreeStacks<int>();
            threeStacks.Push(0, 1);
            threeStacks.Push(0, 2);
            threeStacks.Push(0, 3);
            threeStacks.Push(1, 4);
            threeStacks.Push(1, 5);
            threeStacks.Push(2, 5);
            threeStacks.Push(0, 6);
            threeStacks.Push(1, 7);
            threeStacks.Push(1, 8);
        }

        static void TestStackOfPlates()
        {
            StackOfPlates<int> stack = new StackOfPlates<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);

            Console.WriteLine(stack.PopAt(0));
            Console.WriteLine(stack.PopAt(0));
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push(11);
            stack.Push(12);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        static void TestTowersOfHanoi()
        {
            TowersOfHanoi towers = new TowersOfHanoi(10);
            towers.MoveDisks();
        }

        static void TestQueueUsingStack()
        {
            QueueUsingStacks<int> queue = new QueueUsingStacks<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(5);
            queue.Enqueue(6);
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(7);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }

        static void TestSortedStack()
        {
            SortedStack stack = new SortedStack();
            stack.Push(10);
            Console.WriteLine(stack.Peek());
            stack.Push(9);
            Console.WriteLine(stack.Peek());
            stack.Push(8);
            Console.WriteLine(stack.Peek());
            stack.Push(7);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Push(1);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
