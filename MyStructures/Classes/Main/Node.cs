using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs.Main
{
    /// <summary>
    /// Класс узла структуры.
    /// </summary>
    /// <typeparam name="T">Тип данных узла.</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Данные узла.
        /// </summary>
        private T _data;

        /// <summary>
        /// Указатель на следующий узел.
        /// </summary>
        private Node<T> _nextNode;

        /// <summary>
        /// Конструктор узла.
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Next"></param>
        public Node(T Data, Node<T> Next)
        {
            this.Data = Data;
            _nextNode = Next;
        }

        /// <summary>
        /// Свойство поля данных.
        /// </summary>
        public T Data { get { return _data; } set { _data = value; } }

        /// <summary>
        /// Свойство поля ссылки на следующий узел.
        /// </summary>
        public Node<T> NextNode { get { return _nextNode; } set { _nextNode = value; } }
    }
}
