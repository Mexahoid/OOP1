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
    /// Класс очереди на основе массива.
    /// </summary>
    /// <typeparam name="T">Тип элементов массива.</typeparam>
    public class ArrayQueue<T> : IQueue<T>
    {
        private int count;
        private Node<T> tail;
        private Node<T> head;

        public ArrayQueue(Array Input)
        {
            tail = null;
            head = null;
        }

        #region Основные методы IQueue

        /// <summary>
        /// Выталкивает первый элемент из структуры.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            Node<T> OutOne = head;
            if (count == 1)
                head = tail = null;
            else
                head = head.NextNode;
            count--;
            return OutOne.Data;
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Enqueue(T value)
        {
            count++;
            Node<T> NewNode = new Node<T>(value, null);
            if (IsEmpty)
                head = NewNode;
            else
                tail.NextNode = NewNode;
            tail = NewNode;
        }

        #endregion

        #region Основные методы интерфейса IStructure

        /// <summary>
        /// Очищает структуру.
        /// </summary>
        public void Clear() => head = tail = null;

        /// <summary>
        /// Возвращает ссылку на первый элемент структуры.
        /// </summary>
        /// <returns></returns>
        public T Peek() => head.Data;

        /// <summary>
        /// Возвращает размер очереди.
        /// </summary>
        public int Count
        {
            get => count;
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool IsEmpty
        {
            get => head == null;
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
