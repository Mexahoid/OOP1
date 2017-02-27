using System.Collections.Generic;
using MyStructs.Stacks;

namespace OOP1
{
    class ArrayStackTest : StackTest, ITest
    {
        public ArrayStackTest() : base()
        {
            _testName = "ArrayStackTest";
            ClearAll();
        }

        public void ClearAll()
        {
            _normStack_int = new Stack<int>();
            _normStack_string = new Stack<string>();
            _custStack_int = new ArrayStack<int>();
            _custStack_string = new ArrayStack<string>();
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
