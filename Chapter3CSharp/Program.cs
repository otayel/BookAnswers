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
    }
}
