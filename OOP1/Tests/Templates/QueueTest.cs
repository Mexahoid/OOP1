using System;
using System.Collections.Generic;
using MyStructs.Interfaces;
using System.IO;

namespace OOP1
{
    class QueueTest
    {
        protected Queue<int> _normQueue_int;
        protected Queue<string> _normQueue_string;

        protected IQueue<int> _custQueue_int;
        protected IQueue<string> _custQueue_string;

        protected string _testName;
        protected Random _sich;
        protected StreamWriter _sw;

        protected QueueTest()
        {
            _sich = new Random(DateTime.Now.Millisecond);
        }

        protected void Randomize()
        {
            _sw = new StreamWriter(_testName + ".txt");
            _sw.WriteLine("\n=========\n=========\nТест для " + _testName + " от " + DateTime.Now);

            _sw.WriteLine("\n=====\nНачало проверки Enqueue\n=====\n");

            int length = _sich.Next(1, 100);
            _sw.WriteLine("\n=====\nВводимая длина для очередей (int): " + length);

            for (int i = 0; i < length; i++)
            {
                int number = _sich.Next(_sich.Next(-100, 0), _sich.Next(1, 100));
                _sw.WriteLine(i + ", число: " + number);
                _custQueue_int.Enqueue(number);
                _normQueue_int.Enqueue(number);
            }

            length = _sich.Next(1, 100);
            _sw.WriteLine("\n=====\nВводимая длина для очередей (string): " + length);

            for (int i = 0; i < length; i++)
            {
                string text = "";
                int count = _sich.Next(1, 20);
                for (int k = 0; k < count; k++)
                    text += (char)_sich.Next(32, _sich.Next(33, 127));
                _sw.WriteLine(i + ", текст: " + text);
                _custQueue_string.Enqueue(text);
                _normQueue_string.Enqueue(text);
            }
            _sw.WriteLine("\n=====\nКонец проверки Enqueue\n=====\n");
        }

        protected void TestOut()
        {
            _sw.WriteLine("\n====\nНачало проверки функционала очередей типа int\n====\n");

            CountTest(_normQueue_int, _custQueue_int);

            PeekTest(_normQueue_int, _custQueue_int);

            IsEmptyTest(_custQueue_int);

            DequeueTest(_normQueue_int, _custQueue_int);

            IsEmptyTest(_custQueue_int);

            PeekTest(_normQueue_int, _custQueue_int);

            _sw.WriteLine("\n====\nКонец проверки функционала очередей типа int\n====\n");


            _sw.WriteLine("\n====\nНачало проверки функционала очередей типа string\n====\n");

            CountTest(_normQueue_string, _custQueue_string);

            PeekTest(_normQueue_string, _custQueue_string);

            IsEmptyTest(_custQueue_string);

            DequeueTest(_normQueue_string, _custQueue_string);

            IsEmptyTest(_custQueue_string);

            PeekTest(_normQueue_string, _custQueue_string);

            _sw.WriteLine("\n====\nКонец проверки функционала очередей типа string\n====\n");
        }

        protected void PeekTest<T>(Queue<T> SysQueue, IQueue<T> Queue)
        {
            if (Queue.IsEmpty)
            {
                _sw.WriteLine("\n=====\nПроверка Peek пустой очереди:");

                try
                {
                    _sw.WriteLine("\n ОШИБКА: " + SysQueue.Dequeue());
                }
                catch (Exception e)
                {
                    _sw.WriteLine("Системное исключение: " + e.Message);
                }

                try
                {
                    _sw.WriteLine("\n ОШИБКА: " + Queue.Dequeue());
                }
                catch (Exception e)
                {
                    _sw.WriteLine("Ручное исключение: " + e.Message);
                }
            }
            else
            {
                _sw.WriteLine("\n=====\nПроверка Peek заполненной очереди:");
                _sw.WriteLine("Системная очередь, {0}", SysQueue.Peek());
                _sw.WriteLine("Ручная очередь, {0}", Queue.Peek());
            }
        }

        protected void CountTest<T>(Queue<T> SysQueue, IQueue<T> Queue)
        {
            _sw.WriteLine("\n=====\nПроверка Count:");
            _sw.WriteLine("Системная очередь, длина: {0}", SysQueue.Count);
            _sw.WriteLine("Ручная очередь, длина: {0}\n", Queue.Count);
        }

        protected void IsEmptyTest<T>(IQueue<T> Queue)
        {
            _sw.WriteLine("\n=====\nПроверка IsEmpty " +
                (!Queue.IsEmpty ? "заполненной" : "пустой") +
                " очереди:");
            _sw.WriteLine("Системная очередь не имеет подобного свойства");
            _sw.WriteLine("Ручная очередь, {0}\n", Queue.IsEmpty);
        }

        protected void DequeueTest<T>(Queue<T> SysQueue, IQueue<T> Queue)
        {
            _sw.WriteLine("\n=====\nНачало проверки Dequeue\n=====\n");
            int count = SysQueue.Count;
            if (Queue.GetType() == typeof(MyStructs.Queues.PriorityQueue<int>)
                || Queue.GetType() == typeof(MyStructs.Queues.PriorityQueue<string>))

            {
                for (int i = 0; i < count; i++)
                {
                    _sw.WriteLine("Систем очередь, элемент " + i + ", значение: " + SysQueue.Dequeue());
                }
                for (int i = 0; i < count; i++)
                {
                    _sw.WriteLine("Ручная очередь, элемент " + i + ", значение: " + Queue.Dequeue());
                }
            }
            else
                for (int i = 0; i < count; i++)
                {
                    _sw.WriteLine("Систем очередь, элемент " + i + ", значение: " + SysQueue.Dequeue());
                    _sw.WriteLine("Ручная очередь, элемент " + i + ", значение: " + Queue.Dequeue());
                }

            _sw.WriteLine("Проверка исключений при Dequeue для пустой очереди");
            try
            {
                _sw.WriteLine("\n ОШИБКА: " + SysQueue.Dequeue());
            }
            catch (Exception e)
            {
                _sw.WriteLine("Системное исключение: " + e.Message);
            }

            try
            {
                _sw.WriteLine("\n ОШИБКА: " + Queue.Dequeue());
            }
            catch (Exception e)
            {
                _sw.WriteLine("Ручное исключение: " + e.Message);
            }

            _sw.WriteLine("\n=====\nКонец проверки Dequeue\n=====\n");
        }
    }
}
