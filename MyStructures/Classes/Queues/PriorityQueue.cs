using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs.Main;
using MyStructs.Interfaces;

namespace MyStructs.Queues
{
    /// <summary>
    /// Класс очереди с приоритетами объектов.
    /// </summary>
    /// <typeparam name="T">Тип элементов очереди.</typeparam>
    public class PriorityQueue<T> : IQueue<T> where T : IComparable
    {
        private int _count;
        private Node<T> _head;

        public PriorityQueue()
        {
            _count = 0;
            _head = null;
        }

        public PriorityQueue(IEnumerable<T> Input) : base()
        {
            foreach (T element in Input)
                Enqueue(element);
        }

        /// <summary>
        /// Выталкивает первый элемент из структуры.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            Node<T> OutOne = _head;
            if (_count-- == 1)
                _head = null;
            else
                _head = _head.NextNode;
            return OutOne.Data;
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Enqueue(T value)
        {
            Node<T> NewNode = new Node<T>(value, null);
            if (_count++ == 0)
                _head = NewNode;
            else
            {
                if (_head.Data.CompareTo(value) > -1)
                {
                    NewNode.NextNode = _head;
                    _head = NewNode;
                }
                else
                {
                    Node<T> Temp = _head;
                    while (Temp.NextNode != null)
                        if (Temp.NextNode.Data.CompareTo(value) > -1)
                            break;
                        else
                            Temp = Temp.NextNode;
                    NewNode.NextNode = Temp.NextNode;
                    Temp.NextNode = NewNode;
                }
            }
        }

        #region Основные методы интерфейса IStructure

        /// <summary>
        /// Очищает структуру.
        /// </summary>
        public void Clear()
        {
            _count = 0;
            _head = null;
        }

        /// <summary>
        /// Возвращает ссылку на первый элемент структуры.
        /// </summary>
        /// <returns></returns>
        public T Peek() => _head.Data;

        /// <summary>
        /// Возвращает размер очереди.
        /// </summary>
        public int Count
        {
            get { return _count; }
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool IsEmpty
        {
            get { return _head == null; }
        }

        #endregion

        #region Методы IEnumerable

        /// <summary>
        /// Возвращает переборщика.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator() => (IEnumerator<T>)this;

        /// <summary>
        /// Возвращает переборщика.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)this;

        #endregion
    }
}
