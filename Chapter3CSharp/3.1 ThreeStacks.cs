using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3CSharp
{
    class ThreeStacks<T>
    {
        const int INITIAL_STACK_SIZE = 3;

        T[] array;
        int[] stacksSize = new int[3];
        int[] stacksCapacity = new int[3];
        int[] stacksStart = new int[3];

        public ThreeStacks()
        {
            array = new T[INITIAL_STACK_SIZE * 3];
            for (int i = 0; i < stacksSize.Length; i++)
            {
                stacksSize[i] = 0;
            }

            for (int i = 0; i < stacksCapacity.Length; i++)
            {
                stacksCapacity[i] = INITIAL_STACK_SIZE;
            }

            for (int i = 0; i < stacksStart.Length; i++)
            {
                stacksStart[i] = i * INITIAL_STACK_SIZE;
            }
        }

        public void Push(int stackID, T value)
        {
            if (stackID >= stacksCapacity.Length)
            {
                throw new Exception("Wrong StackID.");
            }

            if (stacksSize[stackID] >= stacksCapacity[stackID])
            {
                Console.WriteLine("Stack " + stackID + " has reached its capacity, and will grow in size.");
                GrowStack(stackID);

            }

            array[stacksStart[stackID] + stacksSize[stackID]] = value;
            stacksSize[stackID]++;

            Console.WriteLine("Pushed Value into stack " + stackID);
        }

        public void Pop(int stackID)
        {
            if (stacksSize[stackID] > 0)
            {
                stacksSize[stackID]--;
            }
            else
            {
                throw new Exception("Stack " + stackID + " is empty.");
            }
        }

        public T Top(int stackID)
        {
            if (stacksSize[stackID] > 0)
            {
                return array[stacksSize[stackID] - 1];
            }
            else
            {
                throw new Exception("Stack " + stackID + " is empty.");
            }
        }

        private void GrowStack(int stackID)
        {
            int newCapacity = 0;
            for (int i = 0; i < stacksCapacity.Length; i++)
            {
                if (stackID == i)
                {
                    newCapacity += stacksCapacity[i] + INITIAL_STACK_SIZE;
                }
                else
                {
                    newCapacity += stacksCapacity[i];
                }
            }

            T[] tempArray = new T[newCapacity];

            for (int i = 0; i < stacksStart.Length; i++)
            {
                if (i == 0)
                {
                    Array.Copy(array, stacksStart[i], tempArray, stacksStart[i], stacksCapacity[i]);
                }
                else
                {
                    Array.Copy(array, stacksStart[i], tempArray, stacksStart[i - 1] + stacksCapacity[i - 1], stacksCapacity[i]);
                    stacksStart[i] = stacksStart[i - 1] + stacksCapacity[i - 1];
                }

                if (stackID == i)
                {
                    stacksCapacity[i] += INITIAL_STACK_SIZE;
                }
            }

            array = tempArray;
        }
    }
}
