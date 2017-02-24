using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStructs.Stacks.ArrayStack<int> Arr;
            int[] Asd = new int[] { 10, 14, 13, 25, 45, 46,67,89,97 };
            Arr = new MyStructs.Stacks.ArrayStack<int>(Asd);
            int C = Arr.Count + 1;
            for (int i = 0; i < C; i++)
            {
                try
                {
                    Console.WriteLine(Arr.Pop());
                }
                catch (MyStructs.Stacks.StackException.EmptyStackException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
