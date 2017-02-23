using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs
{
    /// <summary>
    ///  Базовый интерфейс для всех очередей.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueue<T> : IStructurable<T>
    {
        /// <summary>
        /// Заталкивает элемент в очередь.
        /// </summary>
        /// <param name="value">Заталкиваемый элемент.</param>
        void Enqueue(T value);

        /// <summary>
        /// Вытаскивает элемент из головы очереди.
        /// </summary>
        /// <returns></returns>
        T Dequeue();
    }
    
    /// <summary>
    /// Класс очереди на основе массива.
    /// </summary>
    /// <typeparam name="T">Тип элементов массива.</typeparam>
    public class ArrayQueue<T> : IQueue<T>
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

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool isEmpty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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

    /// <summary>
    ///  Класс очереди на основе связанного списка;
    /// </summary>
    /// <typeparam name="T">Тип элементов списка.</typeparam>
    public class LinkedQueue<T> : IQueue<T>
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

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool isEmpty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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

    /// <summary>
    /// Класс очереди с приоритетами объектов.
    /// </summary>
    /// <typeparam name="T">Тип элементов очереди.</typeparam>
    public class PriorityQueue<T> : IQueue<T> where T : IComparable
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

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool isEmpty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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
