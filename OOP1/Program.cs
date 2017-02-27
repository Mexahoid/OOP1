using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITest> Tests = new List<ITest>()
            {
                new ArrayStackTest(),
                new LinkedStackTest(),
                new ArrayQueueTest(),
                new LinkedQueueTest(),
                new PriorityQueueTest()
            };
            for (int i = 0; i < Tests.Count; i++)
            {
                try
                {
                    Tests[i].StartTest();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Что-то пошло не так: " + e.Message);
                }
            }
            Console.WriteLine("Тесты успешно проведены.");
            Console.ReadLine();
        }
    }
}
