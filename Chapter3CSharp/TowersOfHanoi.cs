using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3CSharp
{
    class TowersOfHanoi
    {
        Stack<int> towerA;
        Stack<int> towerB;
        Stack<int> towerC;

        public TowersOfHanoi(int Count)
        {
            towerA = new Stack<int>();
            towerB = new Stack<int>();
            towerC = new Stack<int>();
            for (int i = Count; i > 0; i--)
            {
                towerA.Push(i);
            }
        }

        public void MoveDisks()
        {
            MoveDisks(towerA.Count, ref towerA, ref towerB, ref towerC);
            Console.WriteLine("Tower A: " + towerA.Count);
            Console.WriteLine("Tower B: " + towerB.Count);
            Console.WriteLine("Tower C: " + towerC.Count);
        }

        public void MoveDisks(int n, ref Stack<int> origin, ref Stack<int> buffer, ref Stack<int> destination)
        {
            if (n <= 0)
            {
                return;
            }

            MoveDisks(n - 1, ref origin, ref destination, ref buffer);
            destination.Push(origin.Pop());
            MoveDisks(n - 1, ref buffer, ref origin, ref destination);
        }
    }
}
