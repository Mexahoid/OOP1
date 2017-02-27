using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs.Queues;

namespace OOP1
{
    class LinkedQueueTest : QueueTest, ITest
    {
        public LinkedQueueTest() : base()
        {
            _testName = "LinkedQueueTest";
            ClearAll();
        }

        public void ClearAll()
        {
            _normQueue_int = new Queue<int>();
            _normQueue_string = new Queue<string>();
            _custQueue_int = new LinkedQueue<int>();
            _custQueue_string = new LinkedQueue<string>();
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
