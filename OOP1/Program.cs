using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs.Stacks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> Arr;
            int[] Asd = new int[] { 10, 14, 13, 25, 45, 46,67,89,97 };
            Arr = new ArrayStack<int>(Asd);
            int C = Arr.Count + 1;
            for (int i = 0; i < C; i++)
            {
                try
                {
                    Console.WriteLine(Arr.Pop());
                }
                catch (StackException.EmptyStackException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            List<string> Lst = new List<string>(new string[] {"сос", "сас", "кек", "лол", "мда", "сес" });
            LinkedStack<string> Lt = new LinkedStack<string>(Lst);
            C = Lt.Count + 1;
            for (int i = 0; i < C; i++)
            {
                try
                {
                    Console.WriteLine(Lt.Pop());
                }
                catch (StackException.EmptyStackException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            int[] a = new int[1];
            Queue<int> q = new Queue<int>(a);
            Queue<string> s = new Queue<string>(Lst);
            Console.WriteLine(new object());
            Console.ReadLine();
            
        }
    }
}
