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
        private int _count;
        private T[] _array;

        public ArrayQueue()
        {
            _count = 0;
            _array = new T[0];
        }

        public ArrayQueue(IEnumerable Input) : base()
        {
            foreach (T element in Input)
                Enqueue(element);
        }

        #region Основные методы IQueue

        /// <summary>
        /// Выталкивает первый элемент из структуры.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {

            T Data = _array[0];
            if (_count-- == 1)
                _array = new T[0];
            else
            {
                T[] tempArr = new T[_count];
                for (int i = 1; i < _count + 1; i++)
                    tempArr[i - 1] = _array[i];
                _array = tempArr;
            }
            return Data;
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Enqueue(T value)
        {
            Array.Resize(ref _array, ++_count);
            _array[_count - 1] = value;
        }

        #endregion

        #region Основные методы интерфейса IStructure

        /// <summary>
        /// Очищает структуру.
        /// </summary>
        public void Clear()
        {
            _array = new T[0];
            _count = 0;
        }

        /// <summary>
        /// Возвращает ссылку на первый элемент структуры.
        /// </summary>
        /// <returns></returns>
        public T Peek() => _array[0];

        /// <summary>
        /// Возвращает размер очереди.
        /// </summary>
        public int Count
        {
            get => _count;
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool IsEmpty
        {
            get => _count == 0;
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
