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
        private int count;
        private Node<T> head;

        public LinkedStack(IList<T> Input)
        {
            count = 0;
            int Count = Input.Count;
            for (int i = 0; i < Count; i++)
                Push(Input[i]);
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
            T Data = head.Data;
            head = head.NextNode;
            count--;
            return Data;
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Push(T value)
        {
            count++;
            head = new Node<T>(value, head);
        }

        #endregion

        #region Основные методы интерфейса IStructure

        /// <summary>
        /// Очищает структуру.
        /// </summary>
        public void Clear() => head = null;

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
