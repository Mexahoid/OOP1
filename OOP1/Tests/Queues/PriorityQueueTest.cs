using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs.Queues;

namespace OOP1
{
    class PriorityQueueTest : QueueTest, ITest
    {
        public PriorityQueueTest() : base()
        {
            _testName = "PriorityQueueTest";
            ClearAll();
        }

        public void ClearAll()
        {
            _normQueue_int = new Queue<int>();
            _normQueue_string = new Queue<string>();
            _custQueue_int = new PriorityQueue<int>();
            _custQueue_string = new PriorityQueue<string>();
        }

        public void StartTest()
        {
            ClearAll();
            Randomize();
            TestOut();
            _sw.Close();
        }
    }
}
