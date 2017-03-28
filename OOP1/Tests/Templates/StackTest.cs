using System;
using System.Collections.Generic;
using MyStructs.Interfaces;
using System.IO;

namespace OOP1
{
    class StackTest
    {
        protected Stack<int> _normStack_int;
        protected Stack<string> _normStack_string;

        protected IStack<int> _custStack_int;
        protected IStack<string> _custStack_string;

        protected string _testName;
        protected Random _sich;
        protected StreamWriter _sw;

        protected StackTest()
        {
            _sich = new Random(DateTime.Now.Millisecond);
        }

        protected void Randomize()
        {
            _sw = new StreamWriter(_testName + ".txt");
            _sw.WriteLine("\n=========\n=========\nТест для " + _testName + " от " + DateTime.Now);

            _sw.WriteLine("\n=====\nНачало проверки Push\n=====\n");

            int length = _sich.Next(1, 100);

            _sw.WriteLine("\n=====\nВводимая длина для стеков (int): " + length);

            for (int i = 0; i < length; i++)
            {
                int number = _sich.Next(_sich.Next(-100, 0), _sich.Next(1, 100));
                _sw.WriteLine(i + ", число: " + number);
                _custStack_int.Push(number);
                _normStack_int.Push(number);
            }

            length = _sich.Next(1, 100);
            _sw.WriteLine("\n=====\nВводимая длина для стеков (string): " + length);

            for (int i = 0; i < length; i++)
            {
                string text = "";
                int count = _sich.Next(1, 20);
                for (int k = 0; k < count; k++)
                    text += (char)_sich.Next(32, _sich.Next(33, 127));

                _sw.WriteLine(i + ", текст: " + text);
                _custStack_string.Push(text);
                _normStack_string.Push(text);
            }

            _sw.WriteLine("\n=====\nКонец проверки Push\n=====\n");
        }

        protected void TestOut()
        {
            _sw.WriteLine("\n====\nНачало проверки функционала стеков типа int\n====\n");

            CountTest(_normStack_int, _custStack_int);

            PeekTest(_normStack_int, _custStack_int);

            IsEmptyTest(_custStack_int);

            PopTest(_normStack_int, _custStack_int);

            IsEmptyTest(_custStack_int);

            PeekTest(_normStack_int, _custStack_int);

            _sw.WriteLine("\n====\nКонец проверки функционала стеков типа int\n====\n");


            _sw.WriteLine("\n====\nНачало проверки функционала стеков типа string\n====\n");

            CountTest(_normStack_string, _custStack_string);

            PeekTest(_normStack_string, _custStack_string);

            IsEmptyTest(_custStack_string);

            PopTest(_normStack_string, _custStack_string);

            IsEmptyTest(_custStack_string);

            PeekTest(_normStack_string, _custStack_string);

            _sw.WriteLine("\n====\nКонец проверки функционала стеков типа string\n====\n");
        }

        protected void PeekTest<T>(Stack<T> SysStack, IStack<T> Stack)
        {
            if (Stack.IsEmpty)
            {
                _sw.WriteLine("\n=====\nПроверка Peek пустого стека:");

                try
                {
                    _sw.WriteLine("\n ОШИБКА: " + SysStack.Pop());
                }
                catch (Exception e)
                {
                    _sw.WriteLine("Системное исключение: " + e.Message);
                }

                try
                {
                    _sw.WriteLine("\n ОШИБКА: " + Stack.Pop());
                }
                catch (Exception e)
                {
                    _sw.WriteLine("Ручное исключение: " + e.Message);
                }
            }
            else
            {
                _sw.WriteLine("\n=====\nПроверка Peek заполненного стека:");
                _sw.WriteLine("Системный стек, {0}", SysStack.Peek());
                _sw.WriteLine("Ручной стек, {0}", Stack.Peek());
            }
        }

        protected void CountTest<T>(Stack<T> SysStack, IStack<T> Stack)
        {
            _sw.WriteLine("\n=====\nПроверка Count:");
            _sw.WriteLine("Системный стек, длина: {0}", SysStack.Count);
            _sw.WriteLine("Ручной стек, длина: {0}\n", Stack.Count);
        }

        protected void IsEmptyTest<T>(IStack<T> Stack)
        {
            _sw.WriteLine("Проверка IsEmpty " +
                (!Stack.IsEmpty ? "заполненного" : "пустого") +
                " стека: \n=====\n");
            _sw.WriteLine("Системный стек не имеет подобного свойства");
            _sw.WriteLine("Ручной стек, {0}\n", Stack.IsEmpty);
        }

        protected void PopTest<T>(Stack<T> SysStack, IStack<T> Stack)
        {
            _sw.WriteLine("\n=====\nНачало проверки Pop\n=====\n");
            int count = SysStack.Count;
            for (int i = 0; i < count; i++)
            {
                _sw.WriteLine("Систем стек, элемент " + i + ", значение: " + SysStack.Pop());
                _sw.WriteLine("Ручной стек, элемент " + i + ", значение: " + Stack.Pop());
            }
            _sw.WriteLine("Проверка исключений при Pop для пустого стека");

            try
            {
                _sw.WriteLine("\n ОШИБКА: " + SysStack.Pop());
            }
            catch (Exception e)
            {
                _sw.WriteLine("Системное исключение: " + e.Message);
            }

            try
            {
                _sw.WriteLine("\n ОШИБКА: " + Stack.Pop());
            }
            catch (Exception e)
            {
                _sw.WriteLine("Ручное исключение: " + e.Message);
            }

            _sw.WriteLine("\n=====\nКонец проверки Pop\n=====\n");
        }
    }
}
