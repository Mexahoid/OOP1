﻿using System;
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
    ///  Класс стека на основе массива.
    /// </summary>
    /// <typeparam name="T">Тип элементов массива.</typeparam>
    public class ArrayStack<T> : IStack<T>
    {
        private int _count;
        private T[] _array;

        public ArrayStack()
        {
            _count = 0;
            _array = new T[0];
        }

        public ArrayStack(IEnumerable Input) : base()
        {
            if (Input == null)
                throw new StackException.NullCollectionException();
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
            if (_count == 0)
                throw new StackException.EmptyStackException();
            T Data = _array[--_count];              //Берем с конца
            Array.Resize(ref _array, _count);
            return Data;
        }

        /// <summary>
        /// Помещает элемент в структуру.
        /// </summary>
        /// <param name="value">Значение элемента.</param>
        public void Push(T value)
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
        public T Peek()
        {
            if (_count == 0)
                throw new StackException.EmptyStackException();
            return _array[0];
        }

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
            get { return _count == 0; }
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
