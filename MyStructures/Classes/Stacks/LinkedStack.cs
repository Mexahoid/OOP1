using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructs.Main;
using MyStructs.Interfaces;

namespace MyStructs.Stacks
{
    /// <summary>
    ///  Класс стека на основе связанного списка.
    /// </summary>
    /// <typeparam name="T">Тип элементов списка.</typeparam>
	public class LinkedStack<T> : IStack<T>
    {
        private int _count;
        private Node<T> _head;

        public LinkedStack()
        {
            _count = 0;
            _head = null;
        }

        public LinkedStack(IEnumerable Input) : base()
        {
            foreach (T element in Input)
                Push(element);
        }

        #region Основные методы стека

        /// <summary>
        /// Выталкивает первый элемент из структуры.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (IsEmpty)
                throw new StackException.EmptyStackException();
            T Data = _head.Data;
            _head = _head.NextNode;
            _count--;
            return Data;
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Push(T value)
        {
            _count++;
            _head = new Node<T>(value, _head);
        }

        #endregion

        #region Основные методы интерфейса IStructure

        /// <summary>
        /// Очищает структуру.
        /// </summary>
        public void Clear()
        {
            _head = null;
            _count = 0;
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
            get => _count;
        }

        /// <summary>
        /// Возвращает логическое значение в зависимости от наличия первого элемента.
        /// </summary>
        public bool IsEmpty
        {
            get => _head == null;
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
