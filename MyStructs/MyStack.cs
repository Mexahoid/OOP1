using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs
{
    /// <summary>
    /// Базовый интерфейс для всех стеков.
    /// </summary>
    /// <typeparam name="T">Тип элементов структуры.</typeparam>
    public interface IStack<T> : IStructurable<T>
    {
        /// <summary>
        /// Заталкивает элемент в стек.
        /// </summary>
        /// <param name="Value">Значение, добавляемое в стек.</param>
        void Push(T value);

        /// <summary>
        /// Дает ссылку на верхний, удаляя.
        /// </summary>
        /// <returns></returns>
        T Pop();
    }
    
    /// <summary>
    ///  Класс стека на основе массива.
    /// </summary>
    /// <typeparam name="T">Тип элементов массива.</typeparam>
    public class ArrayStack<T> : IStack<T>
    {
        /// <summary>
        /// Возвращает размер стека.
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
        /// Возвращает ссылку на первый элемент структуры.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Выталкивает первый элемент из структуры.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Push(T value)
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
    ///  Класс стека на основе связанного списка.
    /// </summary>
    /// <typeparam name="T">Тип элементов списка.</typeparam>
	public class LinkedStack<T> : IStack<T>
    {
        /// <summary>
        /// Возвращает размер стека.
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
        /// Возвращает ссылку на первый элемент структуры.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Выталкивает первый элемент из структуры.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Push(T value)
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
    /// Класс исключений для стеков.
    /// </summary>
    public class StackException
    {

    }
}
