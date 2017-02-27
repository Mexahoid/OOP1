using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs.Queues;

namespace OOP1
{
    class ArrayQueueTest : QueueTest, ITest
    {
        public ArrayQueueTest() : base()
        {
            _testName = "ArrayQueueTest";
            ClearAll();
        }

        public void ClearAll()
        {
            _normQueue_int = new Queue<int>();
            _normQueue_string = new Queue<string>();
            _custQueue_int = new ArrayQueue<int>();
            _custQueue_string = new ArrayQueue<string>();
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
