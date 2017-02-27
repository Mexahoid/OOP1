using System.Collections.Generic;
using MyStructs.Stacks;

namespace OOP1
{
    class LinkedStackTest : StackTest, ITest
    {
        public LinkedStackTest() : base()
        {
            _testName = "LinkedStackTest";
            ClearAll();
        }

        public void ClearAll()
        {
            _normStack_int = new Stack<int>();
            _normStack_string = new Stack<string>();
            _custStack_int = new LinkedStack<int>();
            _custStack_string = new LinkedStack<string>();
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
