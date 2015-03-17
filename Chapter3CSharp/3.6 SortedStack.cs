using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3CSharp
{
    class SortedStack
    {
        Stack<int> stack;

        public SortedStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int item)
        {
            if (IsEmpty() || stack.Peek() <= item)
            {
                stack.Push(item);
            }
            else
            {
                Stack<int> temp = new Stack<int>();
                while ( !IsEmpty() && stack.Peek() > item)
                {
                    temp.Push(stack.Pop());
                }

                stack.Push(item);

                while (temp.Count > 0)
                {
                    stack.Push(temp.Pop());
                }

            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                return stack.Peek();
            }
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                stack.Pop();
            }
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
    }
}
