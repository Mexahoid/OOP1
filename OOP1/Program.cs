using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs.Stacks;
using MyStructs.Queues;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> Arr;
            int[] Asd = new int[] { 10, 14, 13, 25, 45, 46, 67, 89, 97 };
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
            List<string> Lst = new List<string>(new string[] { "сос", "сас", "кек", "лол", "мда", "сес" });
            LinkedStack<string> Lt = new LinkedStack<string>(Lst);
            List<string> g = null;
            try
            {
                LinkedStack<string> Let = new LinkedStack<string>(g);
                Console.WriteLine("Успешно создан стек из списка");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            C = Lt.Count + 1;
            for (int i = 0; i < C; i++)
            {
                try
                {
                    Console.WriteLine(Lt.Pop());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            int[] a = new int[1];
            Queue<int> q = new Queue<int>(a);
            Queue<string> s = new Queue<string>(Lst);
            Console.WriteLine(new object());
            Stack<int> St = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                St.Push(i);
            }
            for (int i = 0; i < 11; i++)
            {
                try
                {
                    Console.WriteLine(St.Pop());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("ArrayQueue");
            ArrayQueue<int> Aq = new ArrayQueue<int>(St);
            for (int i = 0; i < 10; i++)
            {
                Aq.Enqueue(10 - i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Aq.Dequeue());
            }
            Console.WriteLine("LinkedQueue");
            LinkedQueue<int> lq = new LinkedQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                lq.Enqueue(10 - i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(lq.Dequeue());
            }

            Console.WriteLine("PriorityQueue");
            PriorityQueue<int> pq = new PriorityQueue<int>();
            Random sich = new Random();
            for (int i = 0; i < 10; i++)
            {
                pq.Enqueue(sich.Next(20000));
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(pq.Dequeue());
            }

            Console.WriteLine("PriorityQueue");
            PriorityQueue<string> spq = new PriorityQueue<string>();
            for (int i = 0; i < 10; i++)
            {
                string test = "";
                for (int j = 0; j < sich.Next(20); j++)
                {
                    test += (char)(64 + sich.Next(30));
                }
                spq.Enqueue(test);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(spq.Dequeue());
            }


            Console.ReadLine();

        }
    }
}
