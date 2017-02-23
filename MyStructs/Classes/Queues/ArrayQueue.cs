using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs.Queues
{
    /// <summary>
    /// Класс очереди на основе массива.
    /// </summary>
    /// <typeparam name="T">Тип элементов массива.</typeparam>
    public class ArrayQueue<T> : Interfaces.IQueue<T>
    {
        /// <summary>
        /// Возвращает размер очереди.
        /// </summary>
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
        }

        /// <summary>
        /// Очищает структуру.
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
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

        /// <summary>
        /// Возвращает ссылку на первый элемент структуры.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            throw new NotImplementedException();
        }

        #region Неиспользуемые реализации

        /// <summary>
        /// Возвращает переборщика.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Возвращает переборщика.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
