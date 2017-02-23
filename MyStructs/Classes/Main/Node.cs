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
        private T data;

        /// <summary>
        /// Указатель на следующий узел.
        /// </summary>
        private Node<T> nextNode;

        /// <summary>
        /// Конструктор узла.
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Next"></param>
        public Node(T Data, Node<T> Next)
        {
            this.Data = Data;
            NextNode = Next;
        }

        /// <summary>
        /// Свойство поля данных.
        /// </summary>
        public T Data { get => data; set => data = value; }

        /// <summary>
        /// Свойство поля ссылки на следующий узел.
        /// </summary>
        public Node<T> NextNode { get => nextNode; set => nextNode = value; }
    }
}
