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
        private int count;
        private Node<T> tail;
        private Node<T> head;

        public PriorityQueue()
        {

        }

        public PriorityQueue(IEnumerable<T> Input)
        {

        }

        /// <summary>
        /// Выталкивает первый элемент из структуры.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Enqueue(T value)
        {
            throw new NotImplementedException();
        }

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
